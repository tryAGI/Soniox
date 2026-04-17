
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SourceLanguages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_source_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ExcludeSourceLanguages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationTarget" /> class.
        /// </summary>
        /// <param name="targetLanguage"></param>
        /// <param name="sourceLanguages"></param>
        /// <param name="excludeSourceLanguages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationTarget(
            string targetLanguage,
            global::System.Collections.Generic.IList<string> sourceLanguages,
            global::System.Collections.Generic.IList<string> excludeSourceLanguages)
        {
            this.TargetLanguage = targetLanguage ?? throw new global::System.ArgumentNullException(nameof(targetLanguage));
            this.SourceLanguages = sourceLanguages ?? throw new global::System.ArgumentNullException(nameof(sourceLanguages));
            this.ExcludeSourceLanguages = excludeSourceLanguages ?? throw new global::System.ArgumentNullException(nameof(excludeSourceLanguages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationTarget" /> class.
        /// </summary>
        public TranslationTarget()
        {
        }
    }
}