#nullable enable

namespace Soniox
{
    public partial interface IConcurrentStreamsHistoryClient
    {
        /// <summary>
        /// Get concurrent streams history<br/>
        /// Returns historical concurrent stream counts for the project, aggregated per period. The project is implied by the API key used for authentication. Region-scoped.<br/>
        /// Every aggregation period in the requested window is returned, with no gaps. Periods with no recorded activity have every field set to `0`.
        /// </summary>
        /// <param name="startTime">
        /// Start of the time window (inclusive). Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-28T09:00:00Z`). Filters by `period_start`.
        /// </param>
        /// <param name="endTime">
        /// End of the time window (exclusive). Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-28T09:00:00Z`) and strictly after `start_time`. Filters by `period_start`.
        /// </param>
        /// <param name="periodSec">
        /// Aggregation period in seconds. One of `60` (per-minute), `3600` (hourly), `86400` (daily). The period also caps how long the requested window may be.
        /// </param>
        /// <param name="kind">
        /// Stream kind to return. `stt` covers Speech-to-Text WebSocket sessions, `tts` covers Text-to-Speech WebSocket streams and REST requests.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.GetConcurrentStreamsHistoryResponse> GetConcurrentStreamsHistoryAsync(
            string startTime,
            string endTime,
            int periodSec,
            global::Soniox.GetConcurrentStreamsHistoryKind2 kind,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get concurrent streams history<br/>
        /// Returns historical concurrent stream counts for the project, aggregated per period. The project is implied by the API key used for authentication. Region-scoped.<br/>
        /// Every aggregation period in the requested window is returned, with no gaps. Periods with no recorded activity have every field set to `0`.
        /// </summary>
        /// <param name="startTime">
        /// Start of the time window (inclusive). Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-28T09:00:00Z`). Filters by `period_start`.
        /// </param>
        /// <param name="endTime">
        /// End of the time window (exclusive). Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-28T09:00:00Z`) and strictly after `start_time`. Filters by `period_start`.
        /// </param>
        /// <param name="periodSec">
        /// Aggregation period in seconds. One of `60` (per-minute), `3600` (hourly), `86400` (daily). The period also caps how long the requested window may be.
        /// </param>
        /// <param name="kind">
        /// Stream kind to return. `stt` covers Speech-to-Text WebSocket sessions, `tts` covers Text-to-Speech WebSocket streams and REST requests.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Soniox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Soniox.AutoSDKHttpResponse<global::Soniox.GetConcurrentStreamsHistoryResponse>> GetConcurrentStreamsHistoryAsResponseAsync(
            string startTime,
            string endTime,
            int periodSec,
            global::Soniox.GetConcurrentStreamsHistoryKind2 kind,
            global::Soniox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}