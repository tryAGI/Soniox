#nullable enable

namespace Soniox
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Get the organization's usage for a month<br/>
        /// Cost of one calendar month for the organization and each of its projects, with the budget it is measured against.
        /// </summary>
        /// <param name="month">
        /// Calendar month as YYYY-MM, UTC. Defaults to the current month.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.GetOrganizationMonthlyUsageResponse> GetOrganizationMonthlyUsageAsync(
            string? month = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the organization's usage for a month<br/>
        /// Cost of one calendar month for the organization and each of its projects, with the budget it is measured against.
        /// </summary>
        /// <param name="month">
        /// Calendar month as YYYY-MM, UTC. Defaults to the current month.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.GetOrganizationMonthlyUsageResponse>> GetOrganizationMonthlyUsageAsResponseAsync(
            string? month = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}