
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Hints how to translate specific terms. Ignored if translation is not enabled.
    /// </summary>
    public sealed partial class StructuredContextTranslationTerms
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}