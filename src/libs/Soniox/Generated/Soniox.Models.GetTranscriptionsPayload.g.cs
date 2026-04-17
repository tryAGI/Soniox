
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTranscriptionsPayload
    {
        /// <summary>
        /// Maximum number of transcriptions to return.<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

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
        /// Initializes a new instance of the <see cref="GetTranscriptionsPayload" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of transcriptions to return.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor for the next page of results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTranscriptionsPayload(
            int? limit,
            string? cursor)
        {
            this.Limit = limit;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranscriptionsPayload" /> class.
        /// </summary>
        public GetTranscriptionsPayload()
        {
        }
    }
}