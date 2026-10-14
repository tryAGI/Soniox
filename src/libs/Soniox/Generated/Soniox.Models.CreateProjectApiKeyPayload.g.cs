
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateProjectApiKeyPayload
    {
        /// <summary>
        /// Label of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// What the key may call, as `resource:level`. At least one; one level per resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.ApiKeyPermission> Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectApiKeyPayload" /> class.
        /// </summary>
        /// <param name="name">
        /// Label of the API key.
        /// </param>
        /// <param name="permissions">
        /// What the key may call, as `resource:level`. At least one; one level per resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectApiKeyPayload(
            string name,
            global::System.Collections.Generic.IList<global::Soniox.ApiKeyPermission> permissions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectApiKeyPayload" /> class.
        /// </summary>
        public CreateProjectApiKeyPayload()
        {
        }

    }
}