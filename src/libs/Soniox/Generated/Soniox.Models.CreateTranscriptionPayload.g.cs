
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTranscriptionPayload
    {
        /// <summary>
        /// Speech-to-text model to use for the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// URL of the audio file to transcribe. Cannot be specified if `file_id` is specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// ID of the uploaded file to transcribe. Cannot be specified if `audio_url` is specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public global::System.Guid? FileId { get; set; }

        /// <summary>
        /// Expected languages in the audio. If not specified, languages are automatically detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hints")]
        public global::System.Collections.Generic.IList<string>? LanguageHints { get; set; }

        /// <summary>
        /// When `true`, the model will rely more on language hints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hints_strict")]
        public bool? LanguageHintsStrict { get; set; }

        /// <summary>
        /// When `true`, speakers are identified and separated in the transcription output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_speaker_diarization")]
        public bool? EnableSpeakerDiarization { get; set; }

        /// <summary>
        /// When `true`, language is detected for each part of the transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_language_identification")]
        public bool? EnableLanguageIdentification { get; set; }

        /// <summary>
        /// Translation configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation")]
        public global::Soniox.TranslationConfig? Translation { get; set; }

        /// <summary>
        /// Additional context to improve transcription accuracy and formatting of specialized terms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.JsonConverters.AnyOfJsonConverter<global::Soniox.StructuredContext, string, object>))]
        public global::Soniox.AnyOf<global::Soniox.StructuredContext, string, object>? Context { get; set; }

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
        /// Authentication header value sent with webhook notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_auth_header_value")]
        public string? WebhookAuthHeaderValue { get; set; }

        /// <summary>
        /// Optional tracking identifier string. Does not need to be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_reference_id")]
        public string? ClientReferenceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionPayload" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranscriptionPayload(
            string model,
            string? audioUrl,
            global::System.Guid? fileId,
            global::System.Collections.Generic.IList<string>? languageHints,
            bool? languageHintsStrict,
            bool? enableSpeakerDiarization,
            bool? enableLanguageIdentification,
            global::Soniox.TranslationConfig? translation,
            global::Soniox.AnyOf<global::Soniox.StructuredContext, string, object>? context,
            string? webhookUrl,
            string? webhookAuthHeaderName,
            string? webhookAuthHeaderValue,
            string? clientReferenceId)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.AudioUrl = audioUrl;
            this.FileId = fileId;
            this.LanguageHints = languageHints;
            this.LanguageHintsStrict = languageHintsStrict;
            this.EnableSpeakerDiarization = enableSpeakerDiarization;
            this.EnableLanguageIdentification = enableLanguageIdentification;
            this.Translation = translation;
            this.Context = context;
            this.WebhookUrl = webhookUrl;
            this.WebhookAuthHeaderName = webhookAuthHeaderName;
            this.WebhookAuthHeaderValue = webhookAuthHeaderValue;
            this.ClientReferenceId = clientReferenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionPayload" /> class.
        /// </summary>
        public CreateTranscriptionPayload()
        {
        }
    }
}