
#nullable enable

namespace Soniox
{
    /// <summary>
    /// The model to prepare this voice for. If omitted, the voice is prepared for every available model it is not ready for yet.
    /// </summary>
    public sealed partial class RecomputeVoicePayloadModel
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}