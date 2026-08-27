
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetConcurrentStreamsHistoryResponse
    {
        /// <summary>
        /// Stream kind these entries describe (`stt` or `tts`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.JsonConverters.ConcurrentStreamKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.ConcurrentStreamKind Kind { get; set; }

        /// <summary>
        /// Per-period concurrent stream aggregates for the authenticated project, ordered by `period_start` ascending. Every aggregation period in the requested window is returned, with no gaps. Periods with no recorded activity have every field set to `0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.ConcurrentStreamsHistoryEntry> Entries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConcurrentStreamsHistoryResponse" /> class.
        /// </summary>
        /// <param name="kind">
        /// Stream kind these entries describe (`stt` or `tts`).
        /// </param>
        /// <param name="entries">
        /// Per-period concurrent stream aggregates for the authenticated project, ordered by `period_start` ascending. Every aggregation period in the requested window is returned, with no gaps. Periods with no recorded activity have every field set to `0`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConcurrentStreamsHistoryResponse(
            global::Soniox.ConcurrentStreamKind kind,
            global::System.Collections.Generic.IList<global::Soniox.ConcurrentStreamsHistoryEntry> entries)
        {
            this.Kind = kind;
            this.Entries = entries ?? throw new global::System.ArgumentNullException(nameof(entries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConcurrentStreamsHistoryResponse" /> class.
        /// </summary>
        public GetConcurrentStreamsHistoryResponse()
        {
        }

    }
}