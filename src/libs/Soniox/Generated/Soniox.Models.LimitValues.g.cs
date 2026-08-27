
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Configured limits
    /// </summary>
    public sealed partial class LimitValues
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribe_concurrent")]
        public int? TranscribeConcurrent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_concurrent")]
        public int? TtsConcurrent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitValues" /> class.
        /// </summary>
        /// <param name="transcribeConcurrent"></param>
        /// <param name="ttsConcurrent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LimitValues(
            int? transcribeConcurrent,
            int? ttsConcurrent)
        {
            this.TranscribeConcurrent = transcribeConcurrent;
            this.TtsConcurrent = ttsConcurrent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitValues" /> class.
        /// </summary>
        public LimitValues()
        {
        }

    }
}