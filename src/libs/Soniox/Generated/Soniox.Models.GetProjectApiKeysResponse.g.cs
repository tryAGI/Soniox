
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetProjectApiKeysResponse
    {
        /// <summary>
        /// API keys of the project, newest first. Never the key itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.ProjectApiKeyEntry> ApiKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectApiKeysResponse" /> class.
        /// </summary>
        /// <param name="apiKeys">
        /// API keys of the project, newest first. Never the key itself.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetProjectApiKeysResponse(
            global::System.Collections.Generic.IList<global::Soniox.ProjectApiKeyEntry> apiKeys)
        {
            this.ApiKeys = apiKeys ?? throw new global::System.ArgumentNullException(nameof(apiKeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectApiKeysResponse" /> class.
        /// </summary>
        public GetProjectApiKeysResponse()
        {
        }

    }
}