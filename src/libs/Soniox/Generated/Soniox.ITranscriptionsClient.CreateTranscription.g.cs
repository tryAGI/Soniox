#nullable enable

namespace Soniox
{
    public partial interface ITranscriptionsClient
    {
        /// <summary>
        /// Create transcription<br/>
        /// Creates a new transcription.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.Transcription> CreateTranscriptionAsync(

            global::Soniox.CreateTranscriptionPayload request,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create transcription<br/>
        /// Creates a new transcription.
        /// </summary>
        /// <param name="model">
        /// Speech-to-text model to use for the transcription.
        /// </param>
        /// <param name="audioUrl">
        /// URL of the audio file to transcribe. Cannot be specified if `file_id` is specified.
        /// </param>
        /// <param name="fileId">
        /// ID of the uploaded file to transcribe. Cannot be specified if `audio_url` is specified.
        /// </param>
        /// <param name="languageHints">
        /// Expected languages in the audio. If not specified, languages are automatically detected.
        /// </param>
        /// <param name="languageHintsStrict">
        /// When `true`, the model will rely more on language hints.
        /// </param>
        /// <param name="enableSpeakerDiarization">
        /// When `true`, speakers are identified and separated in the transcription output.
        /// </param>
        /// <param name="enableLanguageIdentification">
        /// When `true`, language is detected for each part of the transcription.
        /// </param>
        /// <param name="translation">
        /// Translation configuration.
        /// </param>
        /// <param name="context">
        /// Additional context to improve transcription accuracy and formatting of specialized terms.
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications when transcription is completed or fails.
        /// </param>
        /// <param name="webhookAuthHeaderName">
        /// Name of the authentication header sent with webhook notifications.
        /// </param>
        /// <param name="webhookAuthHeaderValue">
        /// Authentication header value sent with webhook notifications.
        /// </param>
        /// <param name="clientReferenceId">
        /// Optional tracking identifier string. Does not need to be unique.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.Transcription> CreateTranscriptionAsync(
            string model,
            string? audioUrl = default,
            global::System.Guid? fileId = default,
            global::System.Collections.Generic.IList<string>? languageHints = default,
            bool? languageHintsStrict = default,
            bool? enableSpeakerDiarization = default,
            bool? enableLanguageIdentification = default,
            global::Soniox.TranslationConfig? translation = default,
            global::Soniox.AnyOf<global::Soniox.StructuredContext, string, object>? context = default,
            string? webhookUrl = default,
            string? webhookAuthHeaderName = default,
            string? webhookAuthHeaderValue = default,
            string? clientReferenceId = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}