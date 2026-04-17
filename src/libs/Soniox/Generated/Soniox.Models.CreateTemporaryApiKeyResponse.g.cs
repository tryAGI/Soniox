
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Example: {"api_key":"temp:WYJ67RBEFUWQXXPKYPD2UGXKWB","expires_at":"2025-02-22T22:47:37.150Z"}
    /// </summary>
    public sealed partial class CreateTemporaryApiKeyResponse
    {
        /// <summary>
        /// Created temporary API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// UTC timestamp indicating when generated temporary API key will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemporaryApiKeyResponse" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Created temporary API key.
        /// </param>
        /// <param name="expiresAt">
        /// UTC timestamp indicating when generated temporary API key will expire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTemporaryApiKeyResponse(
            string apiKey,
            global::System.DateTime expiresAt)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemporaryApiKeyResponse" /> class.
        /// </summary>
        public CreateTemporaryApiKeyResponse()
        {
        }
    }
}