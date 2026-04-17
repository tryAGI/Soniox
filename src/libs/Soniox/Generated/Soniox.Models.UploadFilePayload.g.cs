
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadFilePayload
    {
        /// <summary>
        /// Optional tracking identifier string. Does not need to be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_reference_id")]
        public string? ClientReferenceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFilePayload" /> class.
        /// </summary>
        /// <param name="clientReferenceId">
        /// Optional tracking identifier string. Does not need to be unique.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadFilePayload(
            string? clientReferenceId)
        {
            this.ClientReferenceId = clientReferenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFilePayload" /> class.
        /// </summary>
        public UploadFilePayload()
        {
        }
    }
}