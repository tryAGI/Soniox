
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
        /// List of languages supported by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.Language> Languages { get; set; }

        /// <summary>
        /// List of available voices for this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.TTSVoice> Voices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_timestamps")]
        public bool? SupportsTimestamps { get; set; }

        /// <summary>
        /// Whether the model supports adjusting the speaking rate via the `speed` parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_speed_adjustment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsSpeedAdjustment { get; set; }

        /// <summary>
        /// Minimum supported speaking rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SpeedMin { get; set; }

        /// <summary>
        /// Maximum supported speaking rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SpeedMax { get; set; }

        /// <summary>
        /// Whether the model supports shortening the pauses between words via the `reduce_silence` parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_silence_reduction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsSilenceReduction { get; set; }

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
        /// <param name="languages">
        /// List of languages supported by the model.
        /// </param>
        /// <param name="voices">
        /// List of available voices for this model.
        /// </param>
        /// <param name="supportsSpeedAdjustment">
        /// Whether the model supports adjusting the speaking rate via the `speed` parameter.
        /// </param>
        /// <param name="speedMin">
        /// Minimum supported speaking rate.
        /// </param>
        /// <param name="speedMax">
        /// Maximum supported speaking rate.
        /// </param>
        /// <param name="supportsSilenceReduction">
        /// Whether the model supports shortening the pauses between words via the `reduce_silence` parameter.
        /// </param>
        /// <param name="aliasedModelId">
        /// If this is an alias, the id of the aliased model.
        /// </param>
        /// <param name="supportsTimestamps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSModel(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::Soniox.Language> languages,
            global::System.Collections.Generic.IList<global::Soniox.TTSVoice> voices,
            bool supportsSpeedAdjustment,
            double speedMin,
            double speedMax,
            bool supportsSilenceReduction,
            string? aliasedModelId,
            bool? supportsTimestamps)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AliasedModelId = aliasedModelId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Languages = languages ?? throw new global::System.ArgumentNullException(nameof(languages));
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.SupportsTimestamps = supportsTimestamps;
            this.SupportsSpeedAdjustment = supportsSpeedAdjustment;
            this.SpeedMin = speedMin;
            this.SpeedMax = speedMax;
            this.SupportsSilenceReduction = supportsSilenceReduction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSModel" /> class.
        /// </summary>
        public TTSModel()
        {
        }

    }
}