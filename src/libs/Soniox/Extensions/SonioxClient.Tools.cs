#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace Soniox;

/// <summary>
/// Extensions for using SonioxClient operations as MEAI AIFunction tools with
/// any IChatClient.
/// </summary>
[System.CLSCompliant(false)]
public static class SonioxClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that transcribes a hosted audio URL using
    /// Soniox's async transcription API (upload-free). Polls until the job
    /// completes and returns the final transcript text.
    /// </summary>
    public static AIFunction AsTranscribeTool(this SonioxClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Publicly reachable HTTPS URL of the audio file to transcribe.")] string audioUrl,
                [Description("Model id. Defaults to 'stt-async-preview'.")] string? model,
                [Description("Optional ISO language hints (e.g. 'en', 'es'). Auto-detects if omitted.")] IList<string>? languageHints,
                [Description("Enable speaker diarization. Defaults to false.")] bool? enableSpeakerDiarization,
                [Description("Enable per-token language identification. Defaults to false.")] bool? enableLanguageIdentification,
                CancellationToken cancellationToken) =>
            {
                var created = await client.Transcriptions.CreateTranscriptionAsync(
                    model: model is { Length: > 0 } ? model : SonioxClient.DefaultAsyncModel,
                    audioUrl: audioUrl,
                    languageHints: languageHints,
                    enableSpeakerDiarization: enableSpeakerDiarization,
                    enableLanguageIdentification: enableLanguageIdentification,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                while (created.Status is TranscriptionStatus.Queued or TranscriptionStatus.Processing)
                {
                    await Task.Delay(1000, cancellationToken).ConfigureAwait(false);
                    created = await client.Transcriptions.GetTranscriptionAsync(
                        transcriptionId: created.Id,
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                }

                if (created.Status is TranscriptionStatus.Error)
                {
                    return new
                    {
                        Id = created.Id.ToString(),
                        Status = created.Status.ToValueString(),
                        created.ErrorType,
                        created.ErrorMessage,
                        Text = (string?)null,
                    };
                }

                var transcript = await client.Transcriptions.GetTranscriptionTranscriptAsync(
                    transcriptionId: created.Id,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Id = created.Id.ToString(),
                    Status = created.Status.ToValueString(),
                    created.ErrorType,
                    created.ErrorMessage,
                    Text = (string?)transcript.Text,
                };
            },
            name: "Soniox_Transcribe",
            description: "Transcribe an audio URL with Soniox's async transcription API. Polls until the job completes and returns the transcript text.");
    }

    /// <summary>
    /// Creates an AIFunction tool that fetches the current status of a
    /// Soniox transcription job by id.
    /// </summary>
    public static AIFunction AsGetTranscriptionTool(this SonioxClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Transcription id (UUID) returned from create_transcription.")] string transcriptionId,
                CancellationToken cancellationToken) =>
            {
                if (!Guid.TryParse(transcriptionId, out var id))
                {
                    throw new ArgumentException("transcriptionId must be a valid UUID.", nameof(transcriptionId));
                }

                var transcription = await client.Transcriptions.GetTranscriptionAsync(
                    transcriptionId: id,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                string? text = null;
                if (transcription.Status is TranscriptionStatus.Completed)
                {
                    var transcript = await client.Transcriptions.GetTranscriptionTranscriptAsync(
                        transcriptionId: id,
                        cancellationToken: cancellationToken).ConfigureAwait(false);
                    text = transcript.Text;
                }

                return new
                {
                    Id = transcription.Id.ToString(),
                    Status = transcription.Status.ToValueString(),
                    transcription.Model,
                    transcription.AudioDurationMs,
                    transcription.ErrorType,
                    transcription.ErrorMessage,
                    Text = text,
                };
            },
            name: "Soniox_GetTranscription",
            description: "Get the status and (if complete) transcript of a previously-created Soniox transcription.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists Soniox speech-to-text models
    /// with their supported languages and transcription modes.
    /// </summary>
    public static AIFunction AsListModelsTool(this SonioxClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Models.GetModelsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    Models = (response.Models ?? new List<Model>())
                        .Select(m => new
                        {
                            m.Id,
                            m.Name,
                            Mode = m.TranscriptionMode.ToValueString(),
                            Languages = (m.Languages ?? new List<Language>())
                                .Select(l => new { l.Code, l.Name }).ToList(),
                            m.SupportsLanguageHintsStrict,
                            m.SupportsMaxEndpointDelay,
                            m.OneWayTranslation,
                            m.TwoWayTranslation,
                        })
                        .ToList(),
                };
            },
            name: "Soniox_ListModels",
            description: "List available Soniox speech-to-text models with their supported languages, transcription mode, and translation capabilities.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists Soniox-supported languages by
    /// aggregating the <c>languages</c> array across all models.
    /// </summary>
    public static AIFunction AsListLanguagesTool(this SonioxClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Models.GetModelsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var distinct = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                foreach (var model in response.Models ?? new List<Model>())
                {
                    foreach (var language in model.Languages ?? new List<Language>())
                    {
                        if (!string.IsNullOrEmpty(language.Code))
                        {
                            distinct[language.Code] = language.Name ?? language.Code;
                        }
                    }
                }

                return new
                {
                    Languages = distinct
                        .OrderBy(kv => kv.Key, StringComparer.OrdinalIgnoreCase)
                        .Select(kv => new { Code = kv.Key, Name = kv.Value })
                        .ToList(),
                };
            },
            name: "Soniox_ListLanguages",
            description: "List all languages supported by Soniox speech-to-text models (aggregated across models).");
    }

    /// <summary>
    /// Creates an AIFunction tool that mints a short-lived temporary API key
    /// suitable for client-side (browser/mobile) WebSocket streaming.
    /// </summary>
    public static AIFunction AsCreateTemporaryApiKeyTool(this SonioxClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("Expiration in seconds from now. Must be > 0.")] int expiresInSeconds,
                [Description("Intended usage. 'transcribe_websocket' for real-time WS or 'transcribe_async' for async jobs.")] string? usageType,
                [Description("Optional tracking identifier to correlate with your own records.")] string? clientReferenceId,
                CancellationToken cancellationToken) =>
            {
                var usage = usageType is { Length: > 0 } u
                    ? (TemporaryApiKeyUsageTypeExtensions.ToEnum(u) ?? TemporaryApiKeyUsageType.TranscribeWebsocket)
                    : TemporaryApiKeyUsageType.TranscribeWebsocket;

                var response = await client.Auth.CreateTemporaryApiKeyAsync(
                    expiresInSeconds: expiresInSeconds,
                    usageType: usage,
                    clientReferenceId: clientReferenceId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return response;
            },
            name: "Soniox_CreateTemporaryApiKey",
            description: "Mint a short-lived Soniox API key scoped for client-side WebSocket streaming or async transcription use.");
    }
}
