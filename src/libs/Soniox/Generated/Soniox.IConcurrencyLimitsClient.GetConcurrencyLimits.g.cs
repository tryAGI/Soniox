#nullable enable

namespace Soniox
{
    public partial interface IConcurrencyLimitsClient
    {
        /// <summary>
        /// Get current concurrent sessions and configured limits<br/>
        /// Current concurrent counts plus configured concurrency limits for the project and its organization. Region-scoped.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.GetConcurrencyLimitsResponse> GetConcurrencyLimitsAsync(
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get current concurrent sessions and configured limits<br/>
        /// Current concurrent counts plus configured concurrency limits for the project and its organization. Region-scoped.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.GetConcurrencyLimitsResponse>> GetConcurrencyLimitsAsResponseAsync(
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}