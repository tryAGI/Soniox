
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTranscriptionsResponse
    {
        /// <summary>
        /// List of transcriptions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.Transcription> Transcriptions { get; set; }

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
        /// Initializes a new instance of the <see cref="GetTranscriptionsResponse" /> class.
        /// </summary>
        /// <param name="transcriptions">
        /// List of transcriptions.
        /// </param>
        /// <param name="nextPageCursor">
        /// A pagination token that references the next page of results. When more data is available, this field contains a value to pass in the cursor parameter of a subsequent request. When null, no additional results are available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTranscriptionsResponse(
            global::System.Collections.Generic.IList<global::Soniox.Transcription> transcriptions,
            string? nextPageCursor)
        {
            this.Transcriptions = transcriptions ?? throw new global::System.ArgumentNullException(nameof(transcriptions));
            this.NextPageCursor = nextPageCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranscriptionsResponse" /> class.
        /// </summary>
        public GetTranscriptionsResponse()
        {
        }
    }
}