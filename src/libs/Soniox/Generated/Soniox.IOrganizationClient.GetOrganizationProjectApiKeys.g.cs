#nullable enable

namespace Soniox
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// List a project's API keys<br/>
        /// Every API key of the project, newest first. The keys themselves are not returned.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.GetProjectApiKeysResponse> GetOrganizationProjectApiKeysAsync(
            global::System.Guid projectId,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List a project's API keys<br/>
        /// Every API key of the project, newest first. The keys themselves are not returned.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.GetProjectApiKeysResponse>> GetOrganizationProjectApiKeysAsResponseAsync(
            global::System.Guid projectId,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}