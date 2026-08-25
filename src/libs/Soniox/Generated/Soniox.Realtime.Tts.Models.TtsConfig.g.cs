
#nullable enable

namespace Soniox.Realtime.Tts
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsConfig
    {
        /// <summary>
        /// Soniox API key. Permanent and temporary API keys are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Client-generated stream identifier unique among active streams on the connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StreamId { get; set; }

        /// <summary>
        /// Text-to-Speech model id, for example tts-rt-v2.<br/>
        /// Default Value: tts-rt-v2
        /// </summary>
        /// <default>"tts-rt-v2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; } = "tts-rt-v2";

        /// <summary>
        /// Input language code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Built-in voice name or cloned voice id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// Output audio format, for example wav, mp3, opus, flac, or raw PCM formats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioFormat { get; set; }

        /// <summary>
        /// Optional output sample rate in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Optional codec bitrate in bits per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Optional tracking identifier recorded in usage logs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_reference_id")]
        public string? ClientReferenceId { get; set; }

        /// <summary>
        /// Request character-level timestamps in audio responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_timestamps")]
        public bool? ReturnTimestamps { get; set; }

        /// <summary>
        /// Optional speaking rate from 0.7 to 1.3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsConfig" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Soniox API key. Permanent and temporary API keys are supported.
        /// </param>
        /// <param name="streamId">
        /// Client-generated stream identifier unique among active streams on the connection.
        /// </param>
        /// <param name="model">
        /// Text-to-Speech model id, for example tts-rt-v2.<br/>
        /// Default Value: tts-rt-v2
        /// </param>
        /// <param name="language">
        /// Input language code.
        /// </param>
        /// <param name="voice">
        /// Built-in voice name or cloned voice id.
        /// </param>
        /// <param name="audioFormat">
        /// Output audio format, for example wav, mp3, opus, flac, or raw PCM formats.
        /// </param>
        /// <param name="sampleRate">
        /// Optional output sample rate in Hz.
        /// </param>
        /// <param name="bitrate">
        /// Optional codec bitrate in bits per second.
        /// </param>
        /// <param name="clientReferenceId">
        /// Optional tracking identifier recorded in usage logs.
        /// </param>
        /// <param name="returnTimestamps">
        /// Request character-level timestamps in audio responses.
        /// </param>
        /// <param name="speed">
        /// Optional speaking rate from 0.7 to 1.3.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsConfig(
            string apiKey,
            string streamId,
            string model,
            string language,
            string voice,
            string audioFormat,
            int? sampleRate,
            int? bitrate,
            string? clientReferenceId,
            bool? returnTimestamps,
            double? speed)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.StreamId = streamId ?? throw new global::System.ArgumentNullException(nameof(streamId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.AudioFormat = audioFormat ?? throw new global::System.ArgumentNullException(nameof(audioFormat));
            this.SampleRate = sampleRate;
            this.Bitrate = bitrate;
            this.ClientReferenceId = clientReferenceId;
            this.ReturnTimestamps = returnTimestamps;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsConfig" /> class.
        /// </summary>
        public TtsConfig()
        {
        }

    }
}