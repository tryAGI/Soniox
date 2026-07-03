
#nullable enable

namespace Soniox.Realtime.Tts
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsCancel
    {
        /// <summary>
        /// Stream identifier to cancel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }

        /// <summary>
        /// True to cancel the active stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancel")]
        public bool? Cancel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCancel" /> class.
        /// </summary>
        /// <param name="streamId">
        /// Stream identifier to cancel.
        /// </param>
        /// <param name="cancel">
        /// True to cancel the active stream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsCancel(
            string? streamId,
            bool? cancel)
        {
            this.StreamId = streamId;
            this.Cancel = cancel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsCancel" /> class.
        /// </summary>
        public TtsCancel()
        {
        }

    }
}