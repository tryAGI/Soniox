
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetFilesCountResponse
    {
        /// <summary>
        /// Total number of files across all sources.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Number of files uploaded via Public API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_api")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicApi { get; set; }

        /// <summary>
        /// Number of files uploaded via the Playground.
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
        /// Initializes a new instance of the <see cref="GetFilesCountResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of files across all sources.
        /// </param>
        /// <param name="publicApi">
        /// Number of files uploaded via Public API.
        /// </param>
        /// <param name="playground">
        /// Number of files uploaded via the Playground.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetFilesCountResponse(
            int total,
            int publicApi,
            int playground)
        {
            this.Total = total;
            this.PublicApi = publicApi;
            this.Playground = playground;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFilesCountResponse" /> class.
        /// </summary>
        public GetFilesCountResponse()
        {
        }
    }
}