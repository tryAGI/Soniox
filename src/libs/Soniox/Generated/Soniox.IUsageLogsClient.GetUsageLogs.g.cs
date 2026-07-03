#nullable enable

namespace Soniox
{
    public partial interface IUsageLogsClient
    {
        /// <summary>
        /// Get usage logs<br/>
        /// Returns per-request usage log entries for the project. The project is implied by the API key used for authentication. Filters by request end time. The window between start_time and end_time must not exceed 31 days. start_time must not be earlier than 91 days ago.
        /// </summary>
        /// <param name="startTime">
        /// Start of the time window (inclusive). Filters by request end time. Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-28T09:00:00Z`).
        /// </param>
        /// <param name="endTime">
        /// End of the time window (exclusive). Filters by request end time. Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-28T09:00:00Z`).
        /// </param>
        /// <param name="limit">
        /// Maximum number of usage log entries to return.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="sort">
        /// Sort order by end_time.Use `end_time_desc` to get the most recent entries first. When paginating, pass the same `sort` value alongside the cursor.<br/>
        /// Default Value: end_time_asc
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor for the next page of results.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.GetUsageLogsResponse> GetUsageLogsAsync(
            string startTime,
            string endTime,
            int? limit = default,
            global::Soniox.GetUsageLogsSort2? sort = default,
            string? cursor = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get usage logs<br/>
        /// Returns per-request usage log entries for the project. The project is implied by the API key used for authentication. Filters by request end time. The window between start_time and end_time must not exceed 31 days. start_time must not be earlier than 91 days ago.
        /// </summary>
        /// <param name="startTime">
        /// Start of the time window (inclusive). Filters by request end time. Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-28T09:00:00Z`).
        /// </param>
        /// <param name="endTime">
        /// End of the time window (exclusive). Filters by request end time. Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-28T09:00:00Z`).
        /// </param>
        /// <param name="limit">
        /// Maximum number of usage log entries to return.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="sort">
        /// Sort order by end_time.Use `end_time_desc` to get the most recent entries first. When paginating, pass the same `sort` value alongside the cursor.<br/>
        /// Default Value: end_time_asc
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor for the next page of results.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.GetUsageLogsResponse>> GetUsageLogsAsResponseAsync(
            string startTime,
            string endTime,
            int? limit = default,
            global::Soniox.GetUsageLogsSort2? sort = default,
            string? cursor = default,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}