
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Optional speaking rate of the generated speech, from `0.7` to `1.3`. `1.0` is the normal speed; lower values slow speech down and higher values speed it up. Defaults to `1.0`.
    /// </summary>
    public sealed partial class CreateTTSPayloadSpeed
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}