
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
        /// Whether the model supports returning timestamps for generated audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_timestamps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsTimestamps { get; set; }

        /// <summary>
        /// Whether the model supports voice cloning (custom voices).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_voice_cloning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsVoiceCloning { get; set; }

        /// <summary>
        /// Whether the model supports adjusting the speech speed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_speed_adjustment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsSpeedAdjustment { get; set; }

        /// <summary>
        /// Minimum supported speech speed. Null when the model does not support speed adjustment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_min")]
        public double? SpeedMin { get; set; }

        /// <summary>
        /// Maximum supported speech speed. Null when the model does not support speed adjustment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_max")]
        public double? SpeedMax { get; set; }

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
        /// <param name="supportsTimestamps">
        /// Whether the model supports returning timestamps for generated audio.
        /// </param>
        /// <param name="supportsVoiceCloning">
        /// Whether the model supports voice cloning (custom voices).
        /// </param>
        /// <param name="supportsSpeedAdjustment">
        /// Whether the model supports adjusting the speech speed.
        /// </param>
        /// <param name="aliasedModelId">
        /// If this is an alias, the id of the aliased model.
        /// </param>
        /// <param name="speedMin">
        /// Minimum supported speech speed. Null when the model does not support speed adjustment.
        /// </param>
        /// <param name="speedMax">
        /// Maximum supported speech speed. Null when the model does not support speed adjustment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSModel(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::Soniox.TTSVoice> voices,
            global::System.Collections.Generic.IList<global::Soniox.Language> languages,
            bool supportsTimestamps,
            bool supportsVoiceCloning,
            bool supportsSpeedAdjustment,
            string? aliasedModelId,
            double? speedMin,
            double? speedMax)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AliasedModelId = aliasedModelId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.SupportsTimestamps = supportsTimestamps;
            this.SupportsVoiceCloning = supportsVoiceCloning;
            this.SupportsSpeedAdjustment = supportsSpeedAdjustment;
            this.SpeedMin = speedMin;
            this.SpeedMax = speedMax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSModel" /> class.
        /// </summary>
        public TTSModel()
        {
        }

    }
}