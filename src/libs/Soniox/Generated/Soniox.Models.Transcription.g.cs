
#nullable enable

namespace Soniox
{
    /// <summary>
    /// A transcription.<br/>
    /// Example: {"audio_duration_ms":0,"audio_url":"https://soniox.com/media/examples/coffee_shop.mp3","client_reference_id":"some_internal_id","created_at":"2024-11-26T00:00:00Z","error_message":null,"error_type":null,"file_id":null,"filename":"coffee_shop.mp3","id":"73d4357d-cad2-4338-a60d-ec6f2044f721","language_hints":["en","fr"],"model":"stt-async-preview","status":"queued","webhook_auth_header_name":"Authorization","webhook_auth_header_value":"******************","webhook_status_code":null,"webhook_url":"https://example.com/webhook"}
    /// </summary>
    public sealed partial class Transcription
    {
        /// <summary>
        /// Unique identifier for the transcription request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Transcription status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.JsonConverters.TranscriptionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.TranscriptionStatus Status { get; set; }

        /// <summary>
        /// UTC timestamp indicating when the transcription was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Speech-to-text model used for the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// URL of the file being transcribed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// ID of the file being transcribed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// Name of the file being transcribed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Expected languages in the audio. If not specified, languages are automatically detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hints")]
        public global::System.Collections.Generic.IList<string>? LanguageHints { get; set; }

        /// <summary>
        /// When `true`, speakers are identified and separated in the transcription output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_speaker_diarization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnableSpeakerDiarization { get; set; }

        /// <summary>
        /// When `true`, language is detected for each part of the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_language_identification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnableLanguageIdentification { get; set; }

        /// <summary>
        /// Duration of the audio in milliseconds. Only available after processing begins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration_ms")]
        public int? AudioDurationMs { get; set; }

        /// <summary>
        /// Error type if transcription failed. `null` for successful or in-progress transcriptions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// Error message if transcription failed. `null` for successful or in-progress transcriptions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// URL to receive webhook notifications when transcription is completed or fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Name of the authentication header sent with webhook notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_name")]
        public string? WebhookAuthHeaderName { get; set; }

        /// <summary>
        /// Authentication header value. Always returned masked as `******************`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_value")]
        public string? WebhookAuthHeaderValue { get; set; }

        /// <summary>
        /// HTTP status code received from your server when webhook was delivered. `null` if not yet sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_status_code")]
        public int? WebhookStatusCode { get; set; }

        /// <summary>
        /// Tracking identifier string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_reference_id")]
        public string? ClientReferenceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcription" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the transcription request.
        /// </param>
        /// <param name="status">
        /// Transcription status.
        /// </param>
        /// <param name="createdAt">
        /// UTC timestamp indicating when the transcription was created.
        /// </param>
        /// <param name="model">
        /// Speech-to-text model used for the transcription.
        /// </param>
        /// <param name="filename">
        /// Name of the file being transcribed.
        /// </param>
        /// <param name="enableSpeakerDiarization">
        /// When `true`, speakers are identified and separated in the transcription output.
        /// </param>
        /// <param name="enableLanguageIdentification">
        /// When `true`, language is detected for each part of the transcription.
        /// </param>
        /// <param name="audioUrl">
        /// URL of the file being transcribed.
        /// </param>
        /// <param name="fileId">
        /// ID of the file being transcribed.
        /// </param>
        /// <param name="languageHints">
        /// Expected languages in the audio. If not specified, languages are automatically detected.
        /// </param>
        /// <param name="audioDurationMs">
        /// Duration of the audio in milliseconds. Only available after processing begins.
        /// </param>
        /// <param name="errorType">
        /// Error type if transcription failed. `null` for successful or in-progress transcriptions.
        /// </param>
        /// <param name="errorMessage">
        /// Error message if transcription failed. `null` for successful or in-progress transcriptions.
        /// </param>
        /// <param name="webhookUrl">
        /// URL to receive webhook notifications when transcription is completed or fails.
        /// </param>
        /// <param name="webhookAuthHeaderName">
        /// Name of the authentication header sent with webhook notifications.
        /// </param>
        /// <param name="webhookAuthHeaderValue">
        /// Authentication header value. Always returned masked as `******************`.
        /// </param>
        /// <param name="webhookStatusCode">
        /// HTTP status code received from your server when webhook was delivered. `null` if not yet sent.
        /// </param>
        /// <param name="clientReferenceId">
        /// Tracking identifier string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Transcription(
            global::System.Guid id,
            global::Soniox.TranscriptionStatus status,
            global::System.DateTime createdAt,
            string model,
            string filename,
            bool enableSpeakerDiarization,
            bool enableLanguageIdentification,
            string? audioUrl,
            global::System.Guid? fileId,
            global::System.Collections.Generic.IList<string>? languageHints,
            int? audioDurationMs,
            string? errorType,
            string? errorMessage,
            string? webhookUrl,
            string? webhookAuthHeaderName,
            string? webhookAuthHeaderValue,
            int? webhookStatusCode,
            string? clientReferenceId)
        {
            this.Id = id;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.AudioUrl = audioUrl;
            this.FileId = fileId;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.LanguageHints = languageHints;
            this.EnableSpeakerDiarization = enableSpeakerDiarization;
            this.EnableLanguageIdentification = enableLanguageIdentification;
            this.AudioDurationMs = audioDurationMs;
            this.ErrorType = errorType;
            this.ErrorMessage = errorMessage;
            this.WebhookUrl = webhookUrl;
            this.WebhookAuthHeaderName = webhookAuthHeaderName;
            this.WebhookAuthHeaderValue = webhookAuthHeaderValue;
            this.WebhookStatusCode = webhookStatusCode;
            this.ClientReferenceId = clientReferenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transcription" /> class.
        /// </summary>
        public Transcription()
        {
        }
    }
}