
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// Unique identifier of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// If this is an alias, the id of the aliased model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliased_model_id")]
        public string? AliasedModelId { get; set; }

        /// <summary>
        /// Name of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Version of context supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_version")]
        public int? ContextVersion { get; set; }

        /// <summary>
        /// Transcription mode of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.JsonConverters.TranscriptionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.TranscriptionMode TranscriptionMode { get; set; }

        /// <summary>
        /// List of languages supported by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.Language> Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_language_hints_strict")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsLanguageHintsStrict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_max_endpoint_delay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsMaxEndpointDelay { get; set; }

        /// <summary>
        /// List of supported one-way translation targets. If list is empty, check for one_way_translation field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation_targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.TranslationTarget> TranslationTargets { get; set; }

        /// <summary>
        /// List of supported two-way translation pairs.  If list is empty, check for two_way_translation field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("two_way_translation_pairs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TwoWayTranslationPairs { get; set; }

        /// <summary>
        /// When contains string 'all_languages', any laguage from languages can be used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("one_way_translation")]
        public string? OneWayTranslation { get; set; }

        /// <summary>
        /// When contains string 'all_languages',' any laguage pair from languages can be used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("two_way_translation")]
        public string? TwoWayTranslation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the model.
        /// </param>
        /// <param name="name">
        /// Name of the model.
        /// </param>
        /// <param name="transcriptionMode">
        /// Transcription mode of the model.
        /// </param>
        /// <param name="languages">
        /// List of languages supported by the model.
        /// </param>
        /// <param name="supportsLanguageHintsStrict"></param>
        /// <param name="supportsMaxEndpointDelay"></param>
        /// <param name="translationTargets">
        /// List of supported one-way translation targets. If list is empty, check for one_way_translation field
        /// </param>
        /// <param name="twoWayTranslationPairs">
        /// List of supported two-way translation pairs.  If list is empty, check for two_way_translation field
        /// </param>
        /// <param name="aliasedModelId">
        /// If this is an alias, the id of the aliased model.
        /// </param>
        /// <param name="contextVersion">
        /// Version of context supported.
        /// </param>
        /// <param name="oneWayTranslation">
        /// When contains string 'all_languages', any laguage from languages can be used
        /// </param>
        /// <param name="twoWayTranslation">
        /// When contains string 'all_languages',' any laguage pair from languages can be used
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            string id,
            string name,
            global::Soniox.TranscriptionMode transcriptionMode,
            global::System.Collections.Generic.IList<global::Soniox.Language> languages,
            bool supportsLanguageHintsStrict,
            bool supportsMaxEndpointDelay,
            global::System.Collections.Generic.IList<global::Soniox.TranslationTarget> translationTargets,
            global::System.Collections.Generic.IList<string> twoWayTranslationPairs,
            string? aliasedModelId,
            int? contextVersion,
            string? oneWayTranslation,
            string? twoWayTranslation)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AliasedModelId = aliasedModelId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ContextVersion = contextVersion;
            this.TranscriptionMode = transcriptionMode;
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.SupportsLanguageHintsStrict = supportsLanguageHintsStrict;
            this.SupportsMaxEndpointDelay = supportsMaxEndpointDelay;
            this.TranslationTargets = translationTargets ?? throw new global::System.ArgumentNullException(nameof(translationTargets));
            this.TwoWayTranslationPairs = twoWayTranslationPairs ?? throw new global::System.ArgumentNullException(nameof(twoWayTranslationPairs));
            this.OneWayTranslation = oneWayTranslation;
            this.TwoWayTranslation = twoWayTranslation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}