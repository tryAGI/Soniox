
#nullable enable

namespace Soniox.Realtime.Tts
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsTerminated
    {
        /// <summary>
        /// Stream identifier whose lifecycle has completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }

        /// <summary>
        /// True when the server has released stream resources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminated")]
        public bool? Terminated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTerminated" /> class.
        /// </summary>
        /// <param name="streamId">
        /// Stream identifier whose lifecycle has completed.
        /// </param>
        /// <param name="terminated">
        /// True when the server has released stream resources.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTerminated(
            string? streamId,
            bool? terminated)
        {
            this.StreamId = streamId;
            this.Terminated = terminated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTerminated" /> class.
        /// </summary>
        public TtsTerminated()
        {
        }

    }
}