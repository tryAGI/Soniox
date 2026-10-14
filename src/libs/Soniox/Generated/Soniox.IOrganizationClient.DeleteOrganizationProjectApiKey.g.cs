#nullable enable

namespace Soniox
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Delete a project API key<br/>
        /// Deletes one API key of the project. Requests made with it are refused from then on.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="keyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteOrganizationProjectApiKeyAsync(
            global::System.Guid projectId,
            global::System.Guid keyId,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a project API key<br/>
        /// Deletes one API key of the project. Requests made with it are refused from then on.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="keyId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse> DeleteOrganizationProjectApiKeyAsResponseAsync(
            global::System.Guid projectId,
            global::System.Guid keyId,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}