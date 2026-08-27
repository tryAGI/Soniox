
#nullable enable

namespace Soniox.Realtime.Tts
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TtsKeepAlive
    {
        /// <summary>
        /// True to keep an already-authenticated WebSocket connection alive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_alive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool KeepAlive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsKeepAlive" /> class.
        /// </summary>
        /// <param name="keepAlive">
        /// True to keep an already-authenticated WebSocket connection alive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsKeepAlive(
            bool keepAlive)
        {
            this.KeepAlive = keepAlive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsKeepAlive" /> class.
        /// </summary>
        public TtsKeepAlive()
        {
        }

    }
}