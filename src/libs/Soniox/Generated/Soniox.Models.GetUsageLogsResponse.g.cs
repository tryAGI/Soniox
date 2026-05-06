
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUsageLogsResponse
    {
        /// <summary>
        /// Per-request usage log entries ordered by end_time, uuid (per `sort`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.UsageLogEntry> UsageLogs { get; set; }

        /// <summary>
        /// A pagination token that references the next page of results. When more data is available, this field contains a value to pass in the cursor parameter of a subsequent request. When null, no additional results are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_cursor")]
        public string? NextPageCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageLogsResponse" /> class.
        /// </summary>
        /// <param name="usageLogs">
        /// Per-request usage log entries ordered by end_time, uuid (per `sort`).
        /// </param>
        /// <param name="nextPageCursor">
        /// A pagination token that references the next page of results. When more data is available, this field contains a value to pass in the cursor parameter of a subsequent request. When null, no additional results are available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageLogsResponse(
            global::System.Collections.Generic.IList<global::Soniox.UsageLogEntry> usageLogs,
            string? nextPageCursor)
        {
            this.UsageLogs = usageLogs ?? throw new global::System.ArgumentNullException(nameof(usageLogs));
            this.NextPageCursor = nextPageCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageLogsResponse" /> class.
        /// </summary>
        public GetUsageLogsResponse()
        {
        }
    }
}