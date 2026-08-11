#nullable enable

namespace Soniox
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Generate speech<br/>
        /// Generates audio from text using the TTS REST endpoint.
        /// </summary>
        /// <param name="xRequestId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GenerateTtsAsync(

            global::Soniox.CreateTTSPayload request,
            string? xRequestId = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech<br/>
        /// Generates audio from text using the TTS REST endpoint.
        /// </summary>
        /// <param name="xRequestId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GenerateTtsAsStreamAsync(

            global::Soniox.CreateTTSPayload request,
            string? xRequestId = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech<br/>
        /// Generates audio from text using the TTS REST endpoint.
        /// </summary>
        /// <param name="xRequestId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<byte[]>> GenerateTtsAsResponseAsync(

            global::Soniox.CreateTTSPayload request,
            string? xRequestId = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate speech<br/>
        /// Generates audio from text using the TTS REST endpoint.
        /// </summary>
        /// <param name="xRequestId"></param>
        /// <param name="model">
        /// TTS model to use.<br/>
        /// Default Value: tts-rt-v2
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GenerateTtsAsync(
            string language,
            string voice,
            string audioFormat,
            string text,
            string? xRequestId = default,
            string model = "tts-rt-v2",
            int? sampleRate = default,
            int? bitrate = default,
            string? clientReferenceId = default,
            double? speed = default,
            bool? reduceSilence = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}