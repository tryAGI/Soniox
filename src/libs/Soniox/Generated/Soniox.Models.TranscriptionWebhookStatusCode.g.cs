
#nullable enable

namespace Soniox
{
    /// <summary>
    /// HTTP status code received from your server when webhook was delivered. `null` if not yet sent.
    /// </summary>
    public sealed partial class TranscriptionWebhookStatusCode
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}