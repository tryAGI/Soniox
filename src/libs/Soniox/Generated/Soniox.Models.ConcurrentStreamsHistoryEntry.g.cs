
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConcurrentStreamsHistoryEntry
    {
        /// <summary>
        /// Start of the aggregation period, UTC. Aligned to a multiple of `period_sec`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PeriodStart { get; set; }

        /// <summary>
        /// Aggregation period in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PeriodSec { get; set; }

        /// <summary>
        /// Lowest recorded concurrent stream count in the period. Always `0`, because that is what the per-minute tier records. Use `sample_max` for the peak.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleMin { get; set; }

        /// <summary>
        /// Peak concurrent stream count in the period. Stays exact when periods are rolled up into hours and days. `0` when the period had no activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleMax { get; set; }

        /// <summary>
        /// Sum of the recorded concurrency values in the period. Divide by `sample_count` for the average concurrency while streams were active, or by `total_count` for the average across the whole period with idle slots counted as zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_sum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleSum { get; set; }

        /// <summary>
        /// Number of values actually recorded in the period. For `period_sec=60` this is how many samples were taken during that minute, so it is usually larger than `total_count`. For hourly and daily periods it is the number of source periods that had data, at most `total_count`. `0` when the period had no activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleCount { get; set; }

        /// <summary>
        /// Number of slots the period covers. `1` for `period_sec=60`, `60` for `3600` (minutes per hour), `24` for `86400` (hours per day). `0` when the period had no activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrentStreamsHistoryEntry" /> class.
        /// </summary>
        /// <param name="periodStart">
        /// Start of the aggregation period, UTC. Aligned to a multiple of `period_sec`.
        /// </param>
        /// <param name="periodSec">
        /// Aggregation period in seconds.
        /// </param>
        /// <param name="sampleMin">
        /// Lowest recorded concurrent stream count in the period. Always `0`, because that is what the per-minute tier records. Use `sample_max` for the peak.
        /// </param>
        /// <param name="sampleMax">
        /// Peak concurrent stream count in the period. Stays exact when periods are rolled up into hours and days. `0` when the period had no activity.
        /// </param>
        /// <param name="sampleSum">
        /// Sum of the recorded concurrency values in the period. Divide by `sample_count` for the average concurrency while streams were active, or by `total_count` for the average across the whole period with idle slots counted as zero.
        /// </param>
        /// <param name="sampleCount">
        /// Number of values actually recorded in the period. For `period_sec=60` this is how many samples were taken during that minute, so it is usually larger than `total_count`. For hourly and daily periods it is the number of source periods that had data, at most `total_count`. `0` when the period had no activity.
        /// </param>
        /// <param name="totalCount">
        /// Number of slots the period covers. `1` for `period_sec=60`, `60` for `3600` (minutes per hour), `24` for `86400` (hours per day). `0` when the period had no activity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConcurrentStreamsHistoryEntry(
            global::System.DateTime periodStart,
            int periodSec,
            int sampleMin,
            int sampleMax,
            int sampleSum,
            int sampleCount,
            int totalCount)
        {
            this.PeriodStart = periodStart;
            this.PeriodSec = periodSec;
            this.SampleMin = sampleMin;
            this.SampleMax = sampleMax;
            this.SampleSum = sampleSum;
            this.SampleCount = sampleCount;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrentStreamsHistoryEntry" /> class.
        /// </summary>
        public ConcurrentStreamsHistoryEntry()
        {
        }

    }
}