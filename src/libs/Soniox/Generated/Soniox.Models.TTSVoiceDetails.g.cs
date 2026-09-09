
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TTSVoiceDetails
    {
        /// <summary>
        /// Unique identifier of the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Description of the TTS voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Gender of the TTS voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.JsonConverters.TTSVoiceGenderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.TTSVoiceGender Gender { get; set; }

        /// <summary>
        /// Perceived age of the speaker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.JsonConverters.TTSVoiceAgeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.TTSVoiceAge Age { get; set; }

        /// <summary>
        /// Accent of the voice, e.g. `american`, `british`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Accent { get; set; }

        /// <summary>
        /// Tags describing what the voice is suited for, e.g. `narration`, `conversational`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_case")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UseCase { get; set; }

        /// <summary>
        /// Tags describing how the voice sounds, e.g. `warm`, `energetic`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Style { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSVoiceDetails" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the voice.
        /// </param>
        /// <param name="description">
        /// Description of the TTS voice.
        /// </param>
        /// <param name="gender">
        /// Gender of the TTS voice.
        /// </param>
        /// <param name="age">
        /// Perceived age of the speaker.
        /// </param>
        /// <param name="accent">
        /// Accent of the voice, e.g. `american`, `british`.
        /// </param>
        /// <param name="useCase">
        /// Tags describing what the voice is suited for, e.g. `narration`, `conversational`.
        /// </param>
        /// <param name="style">
        /// Tags describing how the voice sounds, e.g. `warm`, `energetic`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSVoiceDetails(
            string id,
            string description,
            global::Soniox.TTSVoiceGender gender,
            global::Soniox.TTSVoiceAge age,
            string accent,
            global::System.Collections.Generic.IList<string> useCase,
            global::System.Collections.Generic.IList<string> style)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Gender = gender;
            this.Age = age;
            this.Accent = accent ?? throw new global::System.ArgumentNullException(nameof(accent));
            this.UseCase = useCase ?? throw new global::System.ArgumentNullException(nameof(useCase));
            this.Style = style ?? throw new global::System.ArgumentNullException(nameof(style));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSVoiceDetails" /> class.
        /// </summary>
        public TTSVoiceDetails()
        {
        }

    }
}