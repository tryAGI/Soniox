
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Maximum WebSocket connection duration in seconds. If exceeded, the connection will be dropped. If not set, no limit is applied.
    /// </summary>
    public sealed partial class CreateTemporaryApiKeyPayloadMaxSessionDurationSeconds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}