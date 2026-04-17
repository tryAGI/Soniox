
#nullable enable

namespace Soniox
{
    /// <summary>
    /// A pagination token that references the next page of results. When more data is available, this field contains a value to pass in the cursor parameter of a subsequent request. When null, no additional results are available.
    /// </summary>
    public sealed partial class GetTranscriptionsResponseNextPageCursor
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}