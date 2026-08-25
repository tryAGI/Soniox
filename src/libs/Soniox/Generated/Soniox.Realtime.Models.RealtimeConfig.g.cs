
#nullable enable

namespace Soniox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConfig
    {
        /// <summary>
        /// Soniox API key. Permanent and temporary API keys are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Realtime STT model id, for example stt-rt-v5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Audio format; use auto for containerized streams or raw_* values with sample_rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioFormat { get; set; }

        /// <summary>
        /// Sample rate in Hz for raw audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Channel count for raw audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_channels")]
        public int? NumChannels { get; set; }

        /// <summary>
        /// Expected languages in the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hints")]
        public global::System.Collections.Generic.IList<string>? LanguageHints { get; set; }

        /// <summary>
        /// Bias recognition more strongly toward language_hints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_hints_strict")]
        public bool? LanguageHintsStrict { get; set; }

        /// <summary>
        /// Text or structured context to improve recognition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.Realtime.JsonConverters.OneOfJsonConverter<string, object>))]
        public global::Soniox.Realtime.OneOf<string, object>? Context { get; set; }

        /// <summary>
        /// Identify speakers in token metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_speaker_diarization")]
        public bool? EnableSpeakerDiarization { get; set; }

        /// <summary>
        /// Include detected language in token metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_language_identification")]
        public bool? EnableLanguageIdentification { get; set; }

        /// <summary>
        /// Enable endpoint detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_endpoint_detection")]
        public bool? EnableEndpointDetection { get; set; }

        /// <summary>
        /// Maximum endpoint delay in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_endpoint_delay_ms")]
        public int? MaxEndpointDelayMs { get; set; }

        /// <summary>
        /// Endpoint detection sensitivity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_sensitivity")]
        public double? EndpointSensitivity { get; set; }

        /// <summary>
        /// Endpoint latency adjustment level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_latency_adjustment_level")]
        public int? EndpointLatencyAdjustmentLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation")]
        public global::Soniox.Realtime.TranslationConfig? Translation { get; set; }

        /// <summary>
        /// Optional tracking identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_reference_id")]
        public string? ClientReferenceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConfig" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Soniox API key. Permanent and temporary API keys are supported.
        /// </param>
        /// <param name="model">
        /// Realtime STT model id, for example stt-rt-v5.
        /// </param>
        /// <param name="audioFormat">
        /// Audio format; use auto for containerized streams or raw_* values with sample_rate.
        /// </param>
        /// <param name="sampleRate">
        /// Sample rate in Hz for raw audio.
        /// </param>
        /// <param name="numChannels">
        /// Channel count for raw audio.
        /// </param>
        /// <param name="languageHints">
        /// Expected languages in the audio.
        /// </param>
        /// <param name="languageHintsStrict">
        /// Bias recognition more strongly toward language_hints.
        /// </param>
        /// <param name="context">
        /// Text or structured context to improve recognition.
        /// </param>
        /// <param name="enableSpeakerDiarization">
        /// Identify speakers in token metadata.
        /// </param>
        /// <param name="enableLanguageIdentification">
        /// Include detected language in token metadata.
        /// </param>
        /// <param name="enableEndpointDetection">
        /// Enable endpoint detection.
        /// </param>
        /// <param name="maxEndpointDelayMs">
        /// Maximum endpoint delay in milliseconds.
        /// </param>
        /// <param name="endpointSensitivity">
        /// Endpoint detection sensitivity.
        /// </param>
        /// <param name="endpointLatencyAdjustmentLevel">
        /// Endpoint latency adjustment level.
        /// </param>
        /// <param name="translation"></param>
        /// <param name="clientReferenceId">
        /// Optional tracking identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConfig(
            string apiKey,
            string model,
            string audioFormat,
            int? sampleRate,
            int? numChannels,
            global::System.Collections.Generic.IList<string>? languageHints,
            bool? languageHintsStrict,
            global::Soniox.Realtime.OneOf<string, object>? context,
            bool? enableSpeakerDiarization,
            bool? enableLanguageIdentification,
            bool? enableEndpointDetection,
            int? maxEndpointDelayMs,
            double? endpointSensitivity,
            int? endpointLatencyAdjustmentLevel,
            global::Soniox.Realtime.TranslationConfig? translation,
            string? clientReferenceId)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.AudioFormat = audioFormat ?? throw new global::System.ArgumentNullException(nameof(audioFormat));
            this.SampleRate = sampleRate;
            this.NumChannels = numChannels;
            this.LanguageHints = languageHints;
            this.LanguageHintsStrict = languageHintsStrict;
            this.Context = context;
            this.EnableSpeakerDiarization = enableSpeakerDiarization;
            this.EnableLanguageIdentification = enableLanguageIdentification;
            this.EnableEndpointDetection = enableEndpointDetection;
            this.MaxEndpointDelayMs = maxEndpointDelayMs;
            this.EndpointSensitivity = endpointSensitivity;
            this.EndpointLatencyAdjustmentLevel = endpointLatencyAdjustmentLevel;
            this.Translation = translation;
            this.ClientReferenceId = clientReferenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConfig" /> class.
        /// </summary>
        public RealtimeConfig()
        {
        }

    }
}