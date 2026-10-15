
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectApiKeyResponse
    {
        /// <summary>
        /// Unique identifier of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The API key. Returned only here; it cannot be retrieved again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Leading characters of the key, so keys can be told apart.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyPrefix { get; set; }

        /// <summary>
        /// Label of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// What the key may call, as `resource:level`; write includes read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.ApiKeyPermission> Permissions { get; set; }

        /// <summary>
        /// When the key was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The organization API key that created it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// Id of the organization API key that created this key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CreatedByKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectApiKeyResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the API key.
        /// </param>
        /// <param name="key">
        /// The API key. Returned only here; it cannot be retrieved again.
        /// </param>
        /// <param name="keyPrefix">
        /// Leading characters of the key, so keys can be told apart.
        /// </param>
        /// <param name="permissions">
        /// What the key may call, as `resource:level`; write includes read.
        /// </param>
        /// <param name="createdAt">
        /// When the key was created.
        /// </param>
        /// <param name="createdBy">
        /// The organization API key that created it.
        /// </param>
        /// <param name="createdByKeyId">
        /// Id of the organization API key that created this key.
        /// </param>
        /// <param name="name">
        /// Label of the API key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectApiKeyResponse(
            global::System.Guid id,
            string key,
            string keyPrefix,
            global::System.Collections.Generic.IList<global::Soniox.ApiKeyPermission> permissions,
            global::System.DateTime createdAt,
            string createdBy,
            global::System.Guid createdByKeyId,
            string? name)
        {
            this.Id = id;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.KeyPrefix = keyPrefix ?? throw new global::System.ArgumentNullException(nameof(keyPrefix));
            this.Name = name;
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreatedByKeyId = createdByKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectApiKeyResponse" /> class.
        /// </summary>
        public CreateProjectApiKeyResponse()
        {
        }

    }
}