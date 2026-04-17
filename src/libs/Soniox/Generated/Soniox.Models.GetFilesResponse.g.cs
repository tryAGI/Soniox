
#nullable enable

namespace Soniox
{
    /// <summary>
    /// A list of files.<br/>
    /// Example: {"files":[{"created_at":"2024-11-26T00:00:00Z","filename":"example.mp3","id":"84c32fc6-4fb5-4e7a-b656-b5ec70493753","size":123456}],"next_page_cursor":"cursor_or_null"}
    /// </summary>
    public sealed partial class GetFilesResponse
    {
        /// <summary>
        /// List of uploaded files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.File> Files { get; set; }

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
        /// Initializes a new instance of the <see cref="GetFilesResponse" /> class.
        /// </summary>
        /// <param name="files">
        /// List of uploaded files.
        /// </param>
        /// <param name="nextPageCursor">
        /// A pagination token that references the next page of results. When more data is available, this field contains a value to pass in the cursor parameter of a subsequent request. When null, no additional results are available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFilesResponse(
            global::System.Collections.Generic.IList<global::Soniox.File> files,
            string? nextPageCursor)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.NextPageCursor = nextPageCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilesResponse" /> class.
        /// </summary>
        public GetFilesResponse()
        {
        }
    }
}