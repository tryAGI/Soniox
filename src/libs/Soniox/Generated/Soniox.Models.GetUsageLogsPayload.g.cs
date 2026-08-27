
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageLogsPayload
    {
        /// <summary>
        /// Start of the time window (inclusive). Filters by request end time. Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-28T09:00:00Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTime { get; set; }

        /// <summary>
        /// End of the time window (exclusive). Filters by request end time. Must be an ISO 8601 timestamp in UTC (e.g. `2026-04-28T09:00:00Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTime { get; set; }

        /// <summary>
        /// Maximum number of usage log entries to return.<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Sort order by end_time.Use `end_time_desc` to get the most recent entries first. When paginating, pass the same `sort` value alongside the cursor.<br/>
        /// Default Value: end_time_asc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.JsonConverters.GetUsageLogsPayloadSortJsonConverter))]
        public global::Soniox.GetUsageLogsPayloadSort? Sort { get; set; }

        /// <summary>
        /// Pagination cursor for the next page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageLogsPayload" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageLogsPayload(
            string startTime,
            string endTime,
            int? limit,
            global::Soniox.GetUsageLogsPayloadSort? sort,
            string? cursor)
        {
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.EndTime = endTime ?? throw new global::System.ArgumentNullException(nameof(endTime));
            this.Limit = limit;
            this.Sort = sort;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageLogsPayload" /> class.
        /// </summary>
        public GetUsageLogsPayload()
        {
        }

    }
}