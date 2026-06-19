
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Machine-readable error category when status is 'failed'. Stable across releases — safe to use in control flow. `null` otherwise.
    /// </summary>
    public sealed partial class VoiceModelErrorType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}