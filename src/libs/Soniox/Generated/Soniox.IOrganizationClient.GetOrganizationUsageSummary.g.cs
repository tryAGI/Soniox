#nullable enable

namespace Soniox
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Get the organization's usage summary<br/>
        /// Cost and activity per day, for each project of the organization and each model it used. Projects since deleted are included, so the per-project costs add up to the total. The window is half-open, [start_time, end_time), aggregated by whole UTC day, and must not cover more than 366 days.
        /// </summary>
        /// <param name="startTime">
        /// Start of the window (inclusive). Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-01T00:00:00Z`). Its UTC day is included.
        /// </param>
        /// <param name="endTime">
        /// End of the window (exclusive). Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-03T00:00:00Z`) and strictly after `start_time`. Its UTC day is included unless it falls exactly on midnight.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.GetOrganizationUsageSummaryResponse> GetOrganizationUsageSummaryAsync(
            string startTime,
            string endTime,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the organization's usage summary<br/>
        /// Cost and activity per day, for each project of the organization and each model it used. Projects since deleted are included, so the per-project costs add up to the total. The window is half-open, [start_time, end_time), aggregated by whole UTC day, and must not cover more than 366 days.
        /// </summary>
        /// <param name="startTime">
        /// Start of the window (inclusive). Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-01T00:00:00Z`). Its UTC day is included.
        /// </param>
        /// <param name="endTime">
        /// End of the window (exclusive). Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-03T00:00:00Z`) and strictly after `start_time`. Its UTC day is included unless it falls exactly on midnight.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.GetOrganizationUsageSummaryResponse>> GetOrganizationUsageSummaryAsResponseAsync(
            string startTime,
            string endTime,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}