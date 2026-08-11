#nullable enable

namespace Soniox
{
    public partial interface IUsageSummaryClient
    {
        /// <summary>
        /// Get usage summary<br/>
        /// Returns daily cost and activity for the project, broken down per model and summed across all models. The project is implied by the API key used for authentication.<br/>
        /// Usage is aggregated by whole UTC day. The window is half-open, `[start_time, end_time)`, and a day is included when the window covers any part of it, so an `end_time` exactly at midnight excludes that day. The window must not cover more than 366 UTC days.
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
        global::System.Threading.Tasks.Task<global::Soniox.GetUsageSummaryResponse> GetUsageSummaryAsync(
            string startTime,
            string endTime,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get usage summary<br/>
        /// Returns daily cost and activity for the project, broken down per model and summed across all models. The project is implied by the API key used for authentication.<br/>
        /// Usage is aggregated by whole UTC day. The window is half-open, `[start_time, end_time)`, and a day is included when the window covers any part of it, so an `end_time` exactly at midnight excludes that day. The window must not cover more than 366 UTC days.
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
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.GetUsageSummaryResponse>> GetUsageSummaryAsResponseAsync(
            string startTime,
            string endTime,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}