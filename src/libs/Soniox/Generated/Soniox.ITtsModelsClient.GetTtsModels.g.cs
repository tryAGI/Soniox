#nullable enable

namespace Soniox
{
    public partial interface ITtsModelsClient
    {
        /// <summary>
        /// Get TTS models<br/>
        /// Retrieves list of available TTS models and their attributes.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.GetTTSModelsResponse> GetTtsModelsAsync(
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}