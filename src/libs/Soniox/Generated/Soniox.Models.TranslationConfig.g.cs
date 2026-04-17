
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.JsonConverters.TranslationConfigTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.TranslationConfigType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        public string? TargetLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_a")]
        public string? LanguageA { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_b")]
        public string? LanguageB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationConfig" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="targetLanguage"></param>
        /// <param name="languageA"></param>
        /// <param name="languageB"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationConfig(
            global::Soniox.TranslationConfigType type,
            string? targetLanguage,
            string? languageA,
            string? languageB)
        {
            this.Type = type;
            this.TargetLanguage = targetLanguage;
            this.LanguageA = languageA;
            this.LanguageB = languageB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationConfig" /> class.
        /// </summary>
        public TranslationConfig()
        {
        }
    }
}