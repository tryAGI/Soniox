
#nullable enable

namespace Soniox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ms")]
        public int? StartMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ms")]
        public int? EndMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_audio_event")]
        public bool? IsAudioEvent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_status")]
        public string? TranslationStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        public bool? IsFinal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeToken" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="startMs"></param>
        /// <param name="endMs"></param>
        /// <param name="confidence"></param>
        /// <param name="speaker"></param>
        /// <param name="language"></param>
        /// <param name="isAudioEvent"></param>
        /// <param name="translationStatus"></param>
        /// <param name="isFinal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeToken(
            string? text,
            int? startMs,
            int? endMs,
            double? confidence,
            string? speaker,
            string? language,
            bool? isAudioEvent,
            string? translationStatus,
            bool? isFinal)
        {
            this.Text = text;
            this.StartMs = startMs;
            this.EndMs = endMs;
            this.Confidence = confidence;
            this.Speaker = speaker;
            this.Language = language;
            this.IsAudioEvent = isAudioEvent;
            this.TranslationStatus = translationStatus;
            this.IsFinal = isFinal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeToken" /> class.
        /// </summary>
        public RealtimeToken()
        {
        }

    }
}