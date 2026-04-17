
#nullable enable

namespace Soniox
{
    /// <summary>
    /// File metadata.<br/>
    /// Example: {"client_reference_id":"some_internal_id","created_at":"2024-11-26T00:00:00Z","filename":"example.mp3","id":"84c32fc6-4fb5-4e7a-b656-b5ec70493753","size":123456}
    /// </summary>
    public sealed partial class File
    {
        /// <summary>
        /// Unique identifier of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Size of the file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Size { get; set; }

        /// <summary>
        /// UTC timestamp indicating when the file was uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Tracking identifier string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_reference_id")]
        public string? ClientReferenceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the file.
        /// </param>
        /// <param name="filename">
        /// Name of the file.
        /// </param>
        /// <param name="size">
        /// Size of the file in bytes.
        /// </param>
        /// <param name="createdAt">
        /// UTC timestamp indicating when the file was uploaded.
        /// </param>
        /// <param name="clientReferenceId">
        /// Tracking identifier string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public File(
            global::System.Guid id,
            string filename,
            long size,
            global::System.DateTime createdAt,
            string? clientReferenceId)
        {
            this.Id = id;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Size = size;
            this.CreatedAt = createdAt;
            this.ClientReferenceId = clientReferenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }
    }
}