#nullable enable

namespace Soniox
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Create a project API key<br/>
        /// Creates an API key for the project. The key is returned once, in this response, and cannot be retrieved again.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.CreateProjectApiKeyResponse> CreateOrganizationProjectApiKeyAsync(
            global::System.Guid projectId,

            global::Soniox.CreateProjectApiKeyPayload request,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project API key<br/>
        /// Creates an API key for the project. The key is returned once, in this response, and cannot be retrieved again.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.CreateProjectApiKeyResponse>> CreateOrganizationProjectApiKeyAsResponseAsync(
            global::System.Guid projectId,

            global::Soniox.CreateProjectApiKeyPayload request,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project API key<br/>
        /// Creates an API key for the project. The key is returned once, in this response, and cannot be retrieved again.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Label of the API key.
        /// </param>
        /// <param name="permissions">
        /// What the key may call, as `resource:level`. At least one; one level per resource.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.CreateProjectApiKeyResponse> CreateOrganizationProjectApiKeyAsync(
            global::System.Guid projectId,
            string name,
            global::System.Collections.Generic.IList<global::Soniox.ApiKeyPermission> permissions,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}