
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Optional. When `true`, shortens the pauses between words so the generated speech flows more naturally. Defaults to `false`. Only supported on models with `supports_silence_reduction` set to `true`; enabling it on any other model returns an `invalid_request` error.
    /// </summary>
    public sealed partial class CreateTTSPayloadReduceSilence
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}