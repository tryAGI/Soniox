
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTranscriptionsCountResponse
    {
        /// <summary>
        /// Total number of transcriptions across all scopes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Number of transcriptions created via Public API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_api")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicApi { get; set; }

        /// <summary>
        /// Number of transcriptions created via the Playground.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playground")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Playground { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranscriptionsCountResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of transcriptions across all scopes.
        /// </param>
        /// <param name="publicApi">
        /// Number of transcriptions created via Public API.
        /// </param>
        /// <param name="playground">
        /// Number of transcriptions created via the Playground.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTranscriptionsCountResponse(
            int total,
            int publicApi,
            int playground)
        {
            this.Total = total;
            this.PublicApi = publicApi;
            this.Playground = playground;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTranscriptionsCountResponse" /> class.
        /// </summary>
        public GetTranscriptionsCountResponse()
        {
        }
    }
}