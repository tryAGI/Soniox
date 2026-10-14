#nullable enable

namespace Soniox
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// List the organization's projects<br/>
        /// Every project of the organization, oldest first.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.GetOrganizationProjectsResponse> GetOrganizationProjectsAsync(
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the organization's projects<br/>
        /// Every project of the organization, oldest first.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.GetOrganizationProjectsResponse>> GetOrganizationProjectsAsResponseAsync(
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}