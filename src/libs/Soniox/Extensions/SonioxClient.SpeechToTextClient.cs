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
            AdditionalProperties = new AdditionalPropertiesDictionary
            {
                [SonioxSpeechToTextPropertyNames.Tokens] = transcript.Tokens
                    .Select(static token => new SonioxRealtimeToken(
                        Text: token.Text,
                        StartMs: token.StartMs,
                        EndMs: token.EndMs,
                        Confidence: token.Confidence,
                        Speaker: token.Speaker,
                        Language: token.Language,
                        IsAudioEvent: token.IsAudioEvent,
                        TranslationStatus: token.TranslationStatus,
                        IsFinal: true))
                    .ToArray(),
            },
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
        List<string>? languageHints = null;
        string? audioFormat = null;
        int? sampleRate = null;
        int? numChannels = null;
        bool? languageHintsStrict = null;
        bool? enableSpeakerDiarization = null;
        bool? enableLanguageIdentification = null;
        bool? enableEndpointDetection = null;
        int? maxEndpointDelayMs = null;
        double? endpointSensitivity = null;
        int? endpointLatencyAdjustmentLevel = null;
        string? clientReferenceId = null;

        if (options?.AdditionalProperties is { } props)
        {
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.AudioFormat, out var afObj) && afObj is string afs)
            {
                audioFormat = afs;
            }
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.SampleRate, out var srObj) && srObj is int sr)
            {
                sampleRate = sr;
            }
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.NumChannels, out var ncObj) && ncObj is int nc)
            {
                numChannels = nc;
            }
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.LanguageHints, out var lhObj))
            {
                languageHints = lhObj switch
                {
                    string singleHint when !string.IsNullOrWhiteSpace(singleHint) => new List<string> { singleHint },
                    IEnumerable<string> hints => hints.Where(static hint => !string.IsNullOrWhiteSpace(hint)).ToList(),
                    _ => null,
                };
            }
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.LanguageHintsStrict, out var lhsObj) && lhsObj is bool lhs)
            {
                languageHintsStrict = lhs;
            }
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.EnableSpeakerDiarization, out var dObj) && dObj is bool d)
            {
                enableSpeakerDiarization = d;
            }
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.EnableLanguageIdentification, out var lidObj) && lidObj is bool lid)
            {
                enableLanguageIdentification = lid;
            }
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.EnableEndpointDetection, out var eedObj) && eedObj is bool eed)
            {
                enableEndpointDetection = eed;
            }
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.MaxEndpointDelayMs, out var medObj) && medObj is int med)
            {
                maxEndpointDelayMs = med;
            }
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.EndpointSensitivity, out var esObj) && esObj is double es)
            {
                endpointSensitivity = es;
            }
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.EndpointLatencyAdjustmentLevel, out var elaObj) && elaObj is int ela)
            {
                endpointLatencyAdjustmentLevel = ela;
            }
            if (props.TryGetValue(SonioxSpeechToTextPropertyNames.ClientReferenceId, out var crObj) && crObj is string cr)
            {
                clientReferenceId = cr;
            }
        }

        string? responseId = Guid.NewGuid().ToString("N");

        var realtime = new Realtime.SonioxRealtimeClient();
        await using (realtime.ConfigureAwait(false))
        {
            await realtime.ConnectSpeechToTextAsync(cancellationToken: cancellationToken).ConfigureAwait(false);

            var configuredLanguageHints = languageHints is { Count: > 0 }
                ? languageHints
                : !string.IsNullOrEmpty(language)
                    ? new List<string> { language }
                    : null;

            await realtime.SendRealtimeConfigAsync(
                new Realtime.RealtimeConfig
                {
                    ApiKey = apiKey,
                    Model = model,
                    AudioFormat = audioFormat ?? "auto",
                    SampleRate = sampleRate,
                    NumChannels = numChannels,
                    LanguageHints = configuredLanguageHints,
                    LanguageHintsStrict = languageHintsStrict,
                    EnableSpeakerDiarization = enableSpeakerDiarization,
                    EnableLanguageIdentification = enableLanguageIdentification,
                    EnableEndpointDetection = enableEndpointDetection,
                    MaxEndpointDelayMs = maxEndpointDelayMs,
                    EndpointSensitivity = endpointSensitivity,
                    EndpointLatencyAdjustmentLevel = endpointLatencyAdjustmentLevel,
                    ClientReferenceId = clientReferenceId,
                },
                cancellationToken).ConfigureAwait(false);

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
                        await realtime.SendAsync(
                            new ArraySegment<byte>(buffer, 0, bytesRead),
                            WebSocketMessageType.Binary,
                            endOfMessage: true,
                            cancellationToken).ConfigureAwait(false);
                    }

                    await realtime.SendAsync(
                        ArraySegment<byte>.Empty,
                        WebSocketMessageType.Binary,
                        endOfMessage: true,
                        cancellationToken).ConfigureAwait(false);
                }
                catch (OperationCanceledException)
                {
                }
            }, cancellationToken);

            await foreach (var @event in realtime.ReceiveUpdatesAsync(cancellationToken).ConfigureAwait(false))
            {
                if (@event.IsRealtimeError && @event.RealtimeError is { } error)
                {
                    throw new InvalidOperationException($"Soniox WebSocket error {error.ErrorCode}: {error.ErrorMessage}");
                }

                if (@event.IsRealtimeResult && @event.RealtimeResult is { } result)
                {
                    var update = ParseServerFrame(result, responseId, out bool isFinished);
                    if (update is not null)
                    {
                        yield return update;
                    }

                    if (isFinished)
                    {
                        break;
                    }
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
            catch (WebSocketException)
            {
                // The receive loop can finish before the final empty frame is sent.
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
        var finalTokens = new List<SonioxRealtimeToken>();
        var interimTokens = new List<SonioxRealtimeToken>();
        foreach (var token in tokensEl.EnumerateArray())
        {
            var parsedToken = ParseToken(token);
            string text = parsedToken.Text;
            bool isFinalTok = parsedToken.IsFinal;

            if (isFinalTok)
            {
                finalText.Append(text);
                finalTokens.Add(parsedToken);
            }
            else
            {
                interimText.Append(text);
                interimTokens.Add(parsedToken);
            }
        }

        if (finalText.Length > 0)
        {
            return CreateUpdate(
                finalText.ToString(),
                SpeechToTextResponseUpdateKind.TextUpdated,
                responseId,
                json,
                TryGetInt(root, SonioxSpeechToTextPropertyNames.FinalAudioProcessedMs),
                TryGetInt(root, SonioxSpeechToTextPropertyNames.TotalAudioProcessedMs),
                finalTokens);
        }

        if (interimText.Length > 0)
        {
            return CreateUpdate(
                interimText.ToString(),
                SpeechToTextResponseUpdateKind.TextUpdating,
                responseId,
                json,
                TryGetInt(root, SonioxSpeechToTextPropertyNames.FinalAudioProcessedMs),
                TryGetInt(root, SonioxSpeechToTextPropertyNames.TotalAudioProcessedMs),
                interimTokens);
        }

        return null;
    }

    private static SpeechToTextResponseUpdate? ParseServerFrame(
        Realtime.RealtimeResult frame,
        string? responseId,
        out bool finished)
    {
        ArgumentNullException.ThrowIfNull(frame);

        finished = frame.Finished == true;

        if (frame.Tokens is not { Count: > 0 } tokens)
        {
            return null;
        }

        var finalText = new StringBuilder();
        var interimText = new StringBuilder();
        var finalTokens = new List<SonioxRealtimeToken>();
        var interimTokens = new List<SonioxRealtimeToken>();
        foreach (var token in tokens)
        {
            var parsedToken = ParseToken(token);
            if (parsedToken.IsFinal)
            {
                finalText.Append(parsedToken.Text);
                finalTokens.Add(parsedToken);
            }
            else
            {
                interimText.Append(parsedToken.Text);
                interimTokens.Add(parsedToken);
            }
        }

        if (finalText.Length > 0)
        {
            return CreateUpdate(
                finalText.ToString(),
                SpeechToTextResponseUpdateKind.TextUpdated,
                responseId,
                frame,
                frame.FinalAudioProcMs,
                frame.TotalAudioProcMs,
                finalTokens);
        }

        if (interimText.Length > 0)
        {
            return CreateUpdate(
                interimText.ToString(),
                SpeechToTextResponseUpdateKind.TextUpdating,
                responseId,
                frame,
                frame.FinalAudioProcMs,
                frame.TotalAudioProcMs,
                interimTokens);
        }

        return null;
    }

    private static SpeechToTextResponseUpdate CreateUpdate(
        string text,
        SpeechToTextResponseUpdateKind kind,
        string? responseId,
        object rawRepresentation,
        int? finalAudioProcessedMs,
        int? totalAudioProcessedMs,
        IReadOnlyList<SonioxRealtimeToken> tokens)
    {
        var update = new SpeechToTextResponseUpdate(text)
        {
            Kind = kind,
            ResponseId = responseId,
            RawRepresentation = rawRepresentation,
            StartTime = tokens.Where(static token => token.StartMs is not null).Select(static token => TimeSpan.FromMilliseconds(token.StartMs!.Value)).DefaultIfEmpty().Min(),
            EndTime = tokens.Where(static token => token.EndMs is not null).Select(static token => TimeSpan.FromMilliseconds(token.EndMs!.Value)).DefaultIfEmpty().Max(),
            AdditionalProperties = new AdditionalPropertiesDictionary
            {
                [SonioxSpeechToTextPropertyNames.Tokens] = tokens,
            },
        };

        var speakers = tokens
            .Select(static token => token.Speaker)
            .Where(static speaker => !string.IsNullOrWhiteSpace(speaker))
            .Distinct(StringComparer.Ordinal)
            .ToArray();
        if (speakers.Length > 0)
        {
            update.AdditionalProperties[SonioxSpeechToTextPropertyNames.Speakers] = speakers;
        }

        var languages = tokens
            .Select(static token => token.Language)
            .Where(static language => !string.IsNullOrWhiteSpace(language))
            .Distinct(StringComparer.Ordinal)
            .ToArray();
        if (languages.Length > 0)
        {
            update.AdditionalProperties[SonioxSpeechToTextPropertyNames.Languages] = languages;
        }

        if (finalAudioProcessedMs is int finalAudioValue)
        {
            update.AdditionalProperties[SonioxSpeechToTextPropertyNames.FinalAudioProcessedMs] = finalAudioValue;
        }

        if (totalAudioProcessedMs is int totalAudioValue)
        {
            update.AdditionalProperties[SonioxSpeechToTextPropertyNames.TotalAudioProcessedMs] = totalAudioValue;
        }

        return update;
    }

    private static SonioxRealtimeToken ParseToken(JsonElement token)
    {
        return new SonioxRealtimeToken(
            Text: TryGetString(token, "text") ?? string.Empty,
            StartMs: TryGetInt(token, "start_ms"),
            EndMs: TryGetInt(token, "end_ms"),
            Confidence: TryGetDouble(token, "confidence"),
            Speaker: TryGetString(token, "speaker"),
            Language: TryGetString(token, "language"),
            IsAudioEvent: TryGetBool(token, "is_audio_event"),
            TranslationStatus: TryGetString(token, "translation_status"),
            IsFinal: TryGetBool(token, "is_final") == true);
    }

    private static SonioxRealtimeToken ParseToken(Realtime.RealtimeToken token)
    {
        return new SonioxRealtimeToken(
            Text: token.Text ?? string.Empty,
            StartMs: token.StartMs,
            EndMs: token.EndMs,
            Confidence: token.Confidence,
            Speaker: token.Speaker,
            Language: token.Language,
            IsAudioEvent: token.IsAudioEvent,
            TranslationStatus: token.TranslationStatus,
            IsFinal: token.IsFinal == true);
    }

    private static string? TryGetString(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) && property.ValueKind == JsonValueKind.String
            ? property.GetString()
            : null;
    }

    private static int? TryGetInt(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) && property.ValueKind == JsonValueKind.Number && property.TryGetInt32(out var value)
            ? value
            : null;
    }

    private static double? TryGetDouble(JsonElement element, string propertyName)
    {
        return element.TryGetProperty(propertyName, out var property) && property.ValueKind == JsonValueKind.Number && property.TryGetDouble(out var value)
            ? value
            : null;
    }

    private static bool? TryGetBool(JsonElement element, string propertyName)
    {
        if (!element.TryGetProperty(propertyName, out var property))
        {
            return null;
        }

        return property.ValueKind switch
        {
            JsonValueKind.True => true,
            JsonValueKind.False => false,
            _ => null,
        };
    }
}
