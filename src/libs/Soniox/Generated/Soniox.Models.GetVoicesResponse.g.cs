
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetVoicesResponse
    {
        /// <summary>
        /// List of voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.Voice> Voices { get; set; }

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
        /// Initializes a new instance of the <see cref="GetVoicesResponse" /> class.
        /// </summary>
        /// <param name="voices">
        /// List of voices.
        /// </param>
        /// <param name="nextPageCursor">
        /// A pagination token that references the next page of results. When more data is available, this field contains a value to pass in the cursor parameter of a subsequent request. When null, no additional results are available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVoicesResponse(
            global::System.Collections.Generic.IList<global::Soniox.Voice> voices,
            string? nextPageCursor)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.NextPageCursor = nextPageCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesResponse" /> class.
        /// </summary>
        public GetVoicesResponse()
        {
        }

    }
}