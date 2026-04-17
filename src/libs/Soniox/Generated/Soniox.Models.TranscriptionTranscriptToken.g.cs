
#nullable enable

namespace Soniox
{
    /// <summary>
    /// The transcript token.<br/>
    /// Example: {"confidence":0.95,"end_ms":90,"start_ms":10,"text":"Hel"}
    /// </summary>
    public sealed partial class TranscriptionTranscriptToken
    {
        /// <summary>
        /// Token text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Start time of the token in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartMs { get; set; }

        /// <summary>
        /// End time of the token in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndMs { get; set; }

        /// <summary>
        /// Confidence score of the token, between 0.0 and 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Speaker identifier. Only present when speaker diarization is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// Detected language code for this token. Only present when language identification is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Boolean indicating if this token represents an audio event. Only present when audio event detection is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_audio_event")]
        public bool? IsAudioEvent { get; set; }

        /// <summary>
        /// Translation status ("none", "original" or "translation"). Only when if translation is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_status")]
        public string? TranslationStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionTranscriptToken" /> class.
        /// </summary>
        /// <param name="text">
        /// Token text content.
        /// </param>
        /// <param name="startMs">
        /// Start time of the token in milliseconds.
        /// </param>
        /// <param name="endMs">
        /// End time of the token in milliseconds.
        /// </param>
        /// <param name="confidence">
        /// Confidence score of the token, between 0.0 and 1.0.
        /// </param>
        /// <param name="speaker">
        /// Speaker identifier. Only present when speaker diarization is enabled.
        /// </param>
        /// <param name="language">
        /// Detected language code for this token. Only present when language identification is enabled.
        /// </param>
        /// <param name="isAudioEvent">
        /// Boolean indicating if this token represents an audio event. Only present when audio event detection is enabled.
        /// </param>
        /// <param name="translationStatus">
        /// Translation status ("none", "original" or "translation"). Only when if translation is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionTranscriptToken(
            string text,
            int startMs,
            int endMs,
            double confidence,
            string? speaker,
            string? language,
            bool? isAudioEvent,
            string? translationStatus)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.StartMs = startMs;
            this.EndMs = endMs;
            this.Confidence = confidence;
            this.Speaker = speaker;
            this.Language = language;
            this.IsAudioEvent = isAudioEvent;
            this.TranslationStatus = translationStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionTranscriptToken" /> class.
        /// </summary>
        public TranscriptionTranscriptToken()
        {
        }
    }
}