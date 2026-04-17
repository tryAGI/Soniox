#nullable enable
#pragma warning disable MEAI001 // MEAI speech-to-text abstractions are preview-gated; opt in.

using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Soniox;

/// <summary>
/// Implements <see cref="ISpeechToTextClient"/> on <see cref="SonioxClient"/>.
/// <para>
/// Non-streaming <c>GetTextAsync</c> uploads the audio to <c>/v1/files</c>,
/// creates an async transcription job via <c>/v1/transcriptions</c>, polls
/// until <c>completed</c>, and returns the fetched transcript.
/// </para>
/// <para>
/// Streaming <c>GetStreamingTextAsync</c> opens a WebSocket connection to
/// <c>wss://stt-rt.soniox.com/transcribe-websocket</c>, sends the initial
/// configuration message, streams the audio as binary frames, and yields
/// non-final (interim) and final token groups as
/// <see cref="SpeechToTextResponseUpdate"/>s.
/// </para>
/// </summary>
public partial class SonioxClient : ISpeechToTextClient
{
    /// <summary>
    /// Default model id used for async (pre-recorded) transcription when the
    /// caller does not supply <see cref="SpeechToTextOptions.ModelId"/>.
    /// </summary>
    public const string DefaultAsyncModel = "stt-async-preview";

    /// <summary>
    /// Default model id used for real-time (streaming) transcription when the
    /// caller does not supply <see cref="SpeechToTextOptions.ModelId"/>.
    /// </summary>
    public const string DefaultRealtimeModel = "stt-rt-preview";

    /// <summary>
    /// WebSocket endpoint for Soniox real-time transcription.
    /// </summary>
    public const string RealtimeWebSocketUrl = "wss://stt-rt.soniox.com/transcribe-websocket";

    private SpeechToTextClientMetadata? _speechMetadata;

    /// <inheritdoc />
    object? ISpeechToTextClient.GetService(Type serviceType, object? serviceKey) =>
        serviceType is null ? throw new ArgumentNullException(nameof(serviceType)) :
        serviceKey is not null ? null :
        serviceType == typeof(SpeechToTextClientMetadata) ? (_speechMetadata ??= new("soniox", new Uri(DefaultBaseUrl))) :
        serviceType.IsInstanceOfType(this) ? this :
        null;

    /// <inheritdoc />
    async Task<SpeechToTextResponse> ISpeechToTextClient.GetTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(audioSpeechStream);

        // Buffer the audio stream to a byte[] — Soniox's file upload API is
        // byte-oriented (multipart/form-data).
        byte[] audioBytes;
        if (audioSpeechStream is MemoryStream msAligned
            && msAligned.Position == 0
            && msAligned.TryGetBuffer(out var seg)
            && seg.Array is not null
            && seg.Offset == 0
            && seg.Count == msAligned.Length)
        {
            audioBytes = seg.Array;
        }
        else
        {
            using var copyStream = new MemoryStream();
            await audioSpeechStream.CopyToAsync(copyStream, 81920, cancellationToken).ConfigureAwait(false);
            audioBytes = copyStream.ToArray();
        }

        string filename = (options?.AdditionalProperties?.TryGetValue("filename", out var fn) == true && fn is string fns)
            ? fns
            : $"audio-{Guid.NewGuid():N}.bin";

        var uploaded = await Files.UploadFileAsync(
            file: audioBytes,
            filename: filename,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        string model = options?.ModelId is { Length: > 0 } m ? m : DefaultAsyncModel;
        IList<string>? languageHints = options?.SpeechLanguage is { Length: > 0 } lang
            ? new List<string> { lang }
            : null;

        var transcription = await Transcriptions.CreateTranscriptionAsync(
            model: model,
            fileId: uploaded.Id,
            languageHints: languageHints,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        // Poll until the job reaches a terminal state.
        string id = transcription.Id.ToString();
        while (transcription.Status is TranscriptionStatus.Queued or TranscriptionStatus.Processing)
        {
            await Task.Delay(1000, cancellationToken).ConfigureAwait(false);
            transcription = await Transcriptions.GetTranscriptionAsync(
                transcriptionId: transcription.Id,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        if (transcription.Status is TranscriptionStatus.Error)
        {
            throw new InvalidOperationException(
                $"Soniox transcription {id} failed: {transcription.ErrorType} — {transcription.ErrorMessage}");
        }

        var transcript = await Transcriptions.GetTranscriptionTranscriptAsync(
            transcriptionId: transcription.Id,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        TimeSpan? endTime = transcription.AudioDurationMs is int ms && ms > 0
            ? TimeSpan.FromMilliseconds(ms)
            : null;

        return new SpeechToTextResponse(transcript.Text)
        {
            RawRepresentation = transcript,
            ResponseId = id,
            ModelId = transcription.Model,
            StartTime = TimeSpan.Zero,
            EndTime = endTime,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<SpeechToTextResponseUpdate> ISpeechToTextClient.GetStreamingTextAsync(
        Stream audioSpeechStream,
        SpeechToTextOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(audioSpeechStream);

        // Pull the API key from the Authorizations list populated by the
        // Bearer constructor. Soniox passes the key inside the initial JSON
        // config message (not via the WebSocket's Authorization header).
        string? apiKey = null;
        for (int i = 0; i < Authorizations.Count; i++)
        {
            var auth = Authorizations[i];
            if (auth is { Type: "Http", Value: { Length: > 0 } value })
            {
                apiKey = value;
                break;
            }
        }

        if (string.IsNullOrEmpty(apiKey))
        {
            throw new InvalidOperationException(
                "No API key found in SonioxClient.Authorizations. Construct the client with a (permanent or temporary) API key.");
        }

        string model = options?.ModelId is { Length: > 0 } m ? m : DefaultRealtimeModel;
        string? language = options?.SpeechLanguage;
        string? audioFormat = null;
        int? sampleRate = null;
        int? numChannels = null;
        bool? enableSpeakerDiarization = null;
        bool? enableLanguageIdentification = null;

        if (options?.AdditionalProperties is { } props)
        {
            if (props.TryGetValue("audio_format", out var afObj) && afObj is string afs)
            {
                audioFormat = afs;
            }
            if (props.TryGetValue("sample_rate", out var srObj) && srObj is int sr)
            {
                sampleRate = sr;
            }
            if (props.TryGetValue("num_channels", out var ncObj) && ncObj is int nc)
            {
                numChannels = nc;
            }
            if (props.TryGetValue("enable_speaker_diarization", out var dObj) && dObj is bool d)
            {
                enableSpeakerDiarization = d;
            }
            if (props.TryGetValue("enable_language_identification", out var lidObj) && lidObj is bool lid)
            {
                enableLanguageIdentification = lid;
            }
        }

        using var ws = new ClientWebSocket();

        string? responseId = Guid.NewGuid().ToString("N");

        await ws.ConnectAsync(new Uri(RealtimeWebSocketUrl), cancellationToken).ConfigureAwait(false);

        // Initial configuration message (required first frame).
        {
            using var buf = new MemoryStream();
            using (var writer = new Utf8JsonWriter(buf))
            {
                writer.WriteStartObject();
                writer.WriteString("api_key", apiKey);
                writer.WriteString("model", model);
                writer.WriteString("audio_format", audioFormat ?? "auto");
                if (sampleRate is int srv)
                {
                    writer.WriteNumber("sample_rate", srv);
                }
                if (numChannels is int ncv)
                {
                    writer.WriteNumber("num_channels", ncv);
                }
                if (!string.IsNullOrEmpty(language))
                {
                    writer.WritePropertyName("language_hints");
                    writer.WriteStartArray();
                    writer.WriteStringValue(language);
                    writer.WriteEndArray();
                }
                if (enableSpeakerDiarization is bool ed)
                {
                    writer.WriteBoolean("enable_speaker_diarization", ed);
                }
                if (enableLanguageIdentification is bool el)
                {
                    writer.WriteBoolean("enable_language_identification", el);
                }
                writer.WriteEndObject();
            }

            var configBytes = buf.ToArray();
            await ws.SendAsync(
                new ArraySegment<byte>(configBytes),
                WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken).ConfigureAwait(false);
        }

        yield return new SpeechToTextResponseUpdate
        {
            Kind = SpeechToTextResponseUpdateKind.SessionOpen,
            ResponseId = responseId,
        };

        // Stream audio in a background task. End-of-stream is signaled with
        // an empty binary frame.
        var sendTask = Task.Run(async () =>
        {
            try
            {
                var buffer = new byte[8192];
                int bytesRead;
                while ((bytesRead = await audioSpeechStream.ReadAsync(
                    buffer.AsMemory(0, buffer.Length),
                    cancellationToken).ConfigureAwait(false)) > 0)
                {
                    await ws.SendAsync(
                        new ArraySegment<byte>(buffer, 0, bytesRead),
                        WebSocketMessageType.Binary,
                        endOfMessage: true,
                        cancellationToken).ConfigureAwait(false);
                }

                await ws.SendAsync(
                    ArraySegment<byte>.Empty,
                    WebSocketMessageType.Binary,
                    endOfMessage: true,
                    cancellationToken).ConfigureAwait(false);
            }
            catch (OperationCanceledException)
            {
            }
        }, cancellationToken);

        var readBuffer = new byte[64 * 1024];
        var pending = new StringBuilder();
        while (ws.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
        {
            WebSocketReceiveResult rcv;
            try
            {
                rcv = await ws.ReceiveAsync(
                    new ArraySegment<byte>(readBuffer),
                    cancellationToken).ConfigureAwait(false);
            }
            catch (WebSocketException)
            {
                break;
            }
            catch (OperationCanceledException)
            {
                break;
            }

            if (rcv.MessageType == WebSocketMessageType.Close)
            {
                break;
            }

            if (rcv.MessageType != WebSocketMessageType.Text)
            {
                continue;
            }

            pending.Append(Encoding.UTF8.GetString(readBuffer, 0, rcv.Count));
            if (!rcv.EndOfMessage)
            {
                continue;
            }

            var json = pending.ToString();
            pending.Clear();

            var update = ParseServerFrame(json, responseId, out bool isFinished);
            if (update is not null)
            {
                yield return update;
            }

            if (isFinished)
            {
                break;
            }
        }

        yield return new SpeechToTextResponseUpdate
        {
            Kind = SpeechToTextResponseUpdateKind.SessionClose,
            ResponseId = responseId,
        };

        try
        {
            await sendTask.ConfigureAwait(false);
        }
        catch (OperationCanceledException)
        {
        }

        if (ws.State is WebSocketState.Open or WebSocketState.CloseReceived)
        {
            try
            {
                await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "done", CancellationToken.None).ConfigureAwait(false);
            }
            catch (WebSocketException)
            {
                // Ignore close errors — the session is already over.
            }
            catch (OperationCanceledException)
            {
                // Ignore cancellation during close.
            }
        }
    }

    /// <summary>
    /// Parses one Soniox real-time server frame and maps it to a MEAI
    /// <see cref="SpeechToTextResponseUpdate"/>.
    /// <para>
    /// Frames look like <c>{"tokens":[...],"final_audio_proc_ms":...,"total_audio_proc_ms":...,"finished":bool}</c>.
    /// Tokens carry <c>is_final</c>; we concatenate final tokens into a
    /// <c>TextUpdated</c> update and non-final ones into a
    /// <c>TextUpdating</c> update. Error frames throw.
    /// </para>
    /// </summary>
    [System.CLSCompliant(false)]
    public static SpeechToTextResponseUpdate? ParseServerFrame(
        string json,
        string? responseId,
        out bool finished)
    {
        ArgumentNullException.ThrowIfNull(json);

        finished = false;

        using var doc = JsonDocument.Parse(json);
        var root = doc.RootElement;

        if (root.TryGetProperty("error_code", out var errCode))
        {
            int code = errCode.ValueKind == JsonValueKind.Number ? errCode.GetInt32() : 0;
            string message = root.TryGetProperty("error_message", out var em) && em.ValueKind == JsonValueKind.String
                ? em.GetString() ?? string.Empty
                : string.Empty;
            throw new InvalidOperationException($"Soniox WebSocket error {code}: {message}");
        }

        if (root.TryGetProperty("finished", out var finProp) && finProp.ValueKind == JsonValueKind.True)
        {
            finished = true;
        }

        if (!root.TryGetProperty("tokens", out var tokensEl) || tokensEl.ValueKind != JsonValueKind.Array)
        {
            return null;
        }

        var finalText = new StringBuilder();
        var interimText = new StringBuilder();
        foreach (var token in tokensEl.EnumerateArray())
        {
            string text = token.TryGetProperty("text", out var t) && t.ValueKind == JsonValueKind.String
                ? t.GetString() ?? string.Empty
                : string.Empty;
            bool isFinalTok = token.TryGetProperty("is_final", out var f) && f.ValueKind == JsonValueKind.True;

            if (isFinalTok)
            {
                finalText.Append(text);
            }
            else
            {
                interimText.Append(text);
            }
        }

        if (finalText.Length > 0)
        {
            return new SpeechToTextResponseUpdate(finalText.ToString())
            {
                Kind = SpeechToTextResponseUpdateKind.TextUpdated,
                ResponseId = responseId,
                RawRepresentation = json,
            };
        }

        if (interimText.Length > 0)
        {
            return new SpeechToTextResponseUpdate(interimText.ToString())
            {
                Kind = SpeechToTextResponseUpdateKind.TextUpdating,
                ResponseId = responseId,
                RawRepresentation = json,
            };
        }

        return null;
    }
}
