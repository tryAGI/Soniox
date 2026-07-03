
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Live counts.
    /// </summary>
    public sealed partial class CurrentValues
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribe_concurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TranscribeConcurrent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_concurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TtsConcurrent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentValues" /> class.
        /// </summary>
        /// <param name="transcribeConcurrent"></param>
        /// <param name="ttsConcurrent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CurrentValues(
            int transcribeConcurrent,
            int ttsConcurrent)
        {
            this.TranscribeConcurrent = transcribeConcurrent;
            this.TtsConcurrent = ttsConcurrent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentValues" /> class.
        /// </summary>
        public CurrentValues()
        {
        }

    }
}