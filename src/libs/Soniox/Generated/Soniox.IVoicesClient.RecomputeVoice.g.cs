#nullable enable

namespace Soniox
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Recompute voice<br/>
        /// Prepares the voice for use with available models it is not ready for yet. Use this after a new model is released to make an existing voice usable with it. Models the voice is already prepared for are left unchanged.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.Voice> RecomputeVoiceAsync(
            global::System.Guid voiceId,

            global::Soniox.RecomputeVoicePayload request,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recompute voice<br/>
        /// Prepares the voice for use with available models it is not ready for yet. Use this after a new model is released to make an existing voice usable with it. Models the voice is already prepared for are left unchanged.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.Voice>> RecomputeVoiceAsResponseAsync(
            global::System.Guid voiceId,

            global::Soniox.RecomputeVoicePayload request,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recompute voice<br/>
        /// Prepares the voice for use with available models it is not ready for yet. Use this after a new model is released to make an existing voice usable with it. Models the voice is already prepared for are left unchanged.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="model">
        /// The model to prepare this voice for. If omitted, the voice is prepared for every available model it is not ready for yet.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.Voice> RecomputeVoiceAsync(
            global::System.Guid voiceId,
            string? model = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}