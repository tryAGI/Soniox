
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFilesPayload
    {
        /// <summary>
        /// Maximum number of files to return.<br/>
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
        /// Initializes a new instance of the <see cref="GetFilesPayload" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of files to return.<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor for the next page of results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFilesPayload(
            int? limit,
            string? cursor)
        {
            this.Limit = limit;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilesPayload" /> class.
        /// </summary>
        public GetFilesPayload()
        {
        }
    }
}