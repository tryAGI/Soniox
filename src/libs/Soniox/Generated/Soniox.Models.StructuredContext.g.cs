
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredContext
    {
        /// <summary>
        /// General context items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("general")]
        public global::System.Collections.Generic.IList<global::Soniox.StructuredContextGeneralItem>? General { get; set; }

        /// <summary>
        /// Text context.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Terms that might occur in speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms")]
        public global::System.Collections.Generic.IList<string>? Terms { get; set; }

        /// <summary>
        /// Hints how to translate specific terms. Ignored if translation is not enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_terms")]
        public global::System.Collections.Generic.IList<global::Soniox.StructuredContextTranslationTerm>? TranslationTerms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredContext" /> class.
        /// </summary>
        /// <param name="general">
        /// General context items.
        /// </param>
        /// <param name="text">
        /// Text context.
        /// </param>
        /// <param name="terms">
        /// Terms that might occur in speech.
        /// </param>
        /// <param name="translationTerms">
        /// Hints how to translate specific terms. Ignored if translation is not enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredContext(
            global::System.Collections.Generic.IList<global::Soniox.StructuredContextGeneralItem>? general,
            string? text,
            global::System.Collections.Generic.IList<string>? terms,
            global::System.Collections.Generic.IList<global::Soniox.StructuredContextTranslationTerm>? translationTerms)
        {
            this.General = general;
            this.Text = text;
            this.Terms = terms;
            this.TranslationTerms = translationTerms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredContext" /> class.
        /// </summary>
        public StructuredContext()
        {
        }
    }
}