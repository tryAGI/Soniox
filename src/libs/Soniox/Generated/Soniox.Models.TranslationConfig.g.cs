
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranslationConfig
    {
        /// <summary>
        /// `one_way` translates into `target_language`. `two_way` translates between `language_a` and `language_b`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.JsonConverters.TranslationConfigTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.TranslationConfigType Type { get; set; }

        /// <summary>
        /// Language to translate the transcript into. Required for `one_way`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language")]
        public string? TargetLanguage { get; set; }

        /// <summary>
        /// First language for two-way translation. Required for `two_way`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_a")]
        public string? LanguageA { get; set; }

        /// <summary>
        /// Second language for two-way translation. Required for `two_way`.
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
        /// <param name="type">
        /// `one_way` translates into `target_language`. `two_way` translates between `language_a` and `language_b`.
        /// </param>
        /// <param name="targetLanguage">
        /// Language to translate the transcript into. Required for `one_way`.
        /// </param>
        /// <param name="languageA">
        /// First language for two-way translation. Required for `two_way`.
        /// </param>
        /// <param name="languageB">
        /// Second language for two-way translation. Required for `two_way`.
        /// </param>
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