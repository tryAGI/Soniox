
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TTSModel
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
        /// List of available voices for this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.TTSVoice> Voices { get; set; }

        /// <summary>
        /// List of languages supported by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.Language> Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the model.
        /// </param>
        /// <param name="name">
        /// Name of the model.
        /// </param>
        /// <param name="voices">
        /// List of available voices for this model.
        /// </param>
        /// <param name="languages">
        /// List of languages supported by the model.
        /// </param>
        /// <param name="aliasedModelId">
        /// If this is an alias, the id of the aliased model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSModel(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::Soniox.TTSVoice> voices,
            global::System.Collections.Generic.IList<global::Soniox.Language> languages,
            string? aliasedModelId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AliasedModelId = aliasedModelId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSModel" /> class.
        /// </summary>
        public TTSModel()
        {
        }
    }
}