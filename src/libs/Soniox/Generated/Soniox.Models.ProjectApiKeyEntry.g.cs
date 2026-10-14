
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectApiKeyEntry
    {
        /// <summary>
        /// Unique identifier of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Leading characters of the key, so keys can be told apart.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyPrefix { get; set; }

        /// <summary>
        /// Label of the API key. `null` for keys created without one.
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
        /// Who created the key: the email address of a console user, or the admin key that created it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// The admin key that created it. Null for a console-made key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_key_id")]
        public global::System.Guid? CreatedByKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKeyEntry" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the API key.
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
        /// Who created the key: the email address of a console user, or the admin key that created it.
        /// </param>
        /// <param name="name">
        /// Label of the API key. `null` for keys created without one.
        /// </param>
        /// <param name="createdByKeyId">
        /// The admin key that created it. Null for a console-made key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectApiKeyEntry(
            global::System.Guid id,
            string keyPrefix,
            global::System.Collections.Generic.IList<global::Soniox.ApiKeyPermission> permissions,
            global::System.DateTime createdAt,
            string createdBy,
            string? name,
            global::System.Guid? createdByKeyId)
        {
            this.Id = id;
            this.KeyPrefix = keyPrefix ?? throw new global::System.ArgumentNullException(nameof(keyPrefix));
            this.Name = name;
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreatedByKeyId = createdByKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectApiKeyEntry" /> class.
        /// </summary>
        public ProjectApiKeyEntry()
        {
        }

    }
}