
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Example: {"model":"tts-rt-v1","language":"en","voice":"Adrian","audio_format":"wav","text":"Hello from Soniox Text-to-Speech.","sample_rate":24000,"bitrate":128000,"client_reference_id":"some_internal_id","speed":1.2,"reduce_silence":true}
    /// </summary>
    public sealed partial class CreateTTSPayload
    {
        /// <summary>
        /// TTS model to use.<br/>
        /// Default Value: tts-rt-v1
        /// </summary>
        /// <default>"tts-rt-v1"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; } = "tts-rt-v1";

        /// <summary>
        /// Language code of the input text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Voice to use: a built-in voice name (for example `Adrian`) or the ID of a [cloned voice](https://soniox.com/docs/tts/concepts/voice-cloning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// Output audio format (for example `mp3`, `wav`, `pcm_s16le`, `pcm_s16be`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioFormat { get; set; }

        /// <summary>
        /// Input text to generate audio from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Optional output sample rate in Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Optional output bitrate in bits per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Optional tracking identifier string. Does not need to be unique. Ignored if the request authenticates with a temporary API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_reference_id")]
        public string? ClientReferenceId { get; set; }

        /// <summary>
        /// Optional speaking rate of the generated speech, from `0.7` to `1.3`. `1.0` is the normal speed; lower values slow speech down and higher values speed it up. Defaults to `1.0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Optional. When `true`, shortens the pauses between words so the generated speech flows more naturally. Defaults to `false`. Only supported on models with `supports_silence_reduction` set to `true`; enabling it on any other model returns an `invalid_request` error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reduce_silence")]
        public bool? ReduceSilence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTTSPayload" /> class.
        /// </summary>
        /// <param name="model">
        /// TTS model to use.<br/>
        /// Default Value: tts-rt-v1
        /// </param>
        /// <param name="language">
        /// Language code of the input text.
        /// </param>
        /// <param name="voice">
        /// Voice to use: a built-in voice name (for example `Adrian`) or the ID of a [cloned voice](https://soniox.com/docs/tts/concepts/voice-cloning).
        /// </param>
        /// <param name="audioFormat">
        /// Output audio format (for example `mp3`, `wav`, `pcm_s16le`, `pcm_s16be`).
        /// </param>
        /// <param name="text">
        /// Input text to generate audio from.
        /// </param>
        /// <param name="sampleRate">
        /// Optional output sample rate in Hz.
        /// </param>
        /// <param name="bitrate">
        /// Optional output bitrate in bits per second.
        /// </param>
        /// <param name="clientReferenceId">
        /// Optional tracking identifier string. Does not need to be unique. Ignored if the request authenticates with a temporary API key.
        /// </param>
        /// <param name="speed">
        /// Optional speaking rate of the generated speech, from `0.7` to `1.3`. `1.0` is the normal speed; lower values slow speech down and higher values speed it up. Defaults to `1.0`.
        /// </param>
        /// <param name="reduceSilence">
        /// Optional. When `true`, shortens the pauses between words so the generated speech flows more naturally. Defaults to `false`. Only supported on models with `supports_silence_reduction` set to `true`; enabling it on any other model returns an `invalid_request` error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTTSPayload(
            string model,
            string language,
            string voice,
            string audioFormat,
            string text,
            int? sampleRate,
            int? bitrate,
            string? clientReferenceId,
            double? speed,
            bool? reduceSilence)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.AudioFormat = audioFormat ?? throw new global::System.ArgumentNullException(nameof(audioFormat));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.SampleRate = sampleRate;
            this.Bitrate = bitrate;
            this.ClientReferenceId = clientReferenceId;
            this.Speed = speed;
            this.ReduceSilence = reduceSilence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTTSPayload" /> class.
        /// </summary>
        public CreateTTSPayload()
        {
        }

    }
}