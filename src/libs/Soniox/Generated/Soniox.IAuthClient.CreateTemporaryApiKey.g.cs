#nullable enable

namespace Soniox
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Create temporary API key<br/>
        /// Creates a short-lived API key for specific temporary use cases. The key will automatically expire after the specified duration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.CreateTemporaryApiKeyResponse> CreateTemporaryApiKeyAsync(

            global::Soniox.CreateTemporaryApiKeyPayload request,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create temporary API key<br/>
        /// Creates a short-lived API key for specific temporary use cases. The key will automatically expire after the specified duration.
        /// </summary>
        /// <param name="usageType">
        /// Intended usage of the temporary API key.
        /// </param>
        /// <param name="expiresInSeconds">
        /// Duration in seconds until the temporary API key expires.
        /// </param>
        /// <param name="clientReferenceId">
        /// Optional tracking identifier string. Does not need to be unique.
        /// </param>
        /// <param name="singleUse">
        /// If true, the temporary API key can be used only once.
        /// </param>
        /// <param name="maxSessionDurationSeconds">
        /// Maximum WebSocket connection duration in seconds. If exceeded, the connection will be dropped. If not set, no limit is applied.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.CreateTemporaryApiKeyResponse> CreateTemporaryApiKeyAsync(
            int expiresInSeconds,
            global::Soniox.TemporaryApiKeyUsageType usageType = default,
            string? clientReferenceId = default,
            bool? singleUse = default,
            int? maxSessionDurationSeconds = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}