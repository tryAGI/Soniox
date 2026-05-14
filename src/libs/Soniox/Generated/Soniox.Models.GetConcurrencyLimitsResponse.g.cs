
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConcurrencyLimitsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.ScopeValues Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.ScopeValues Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConcurrencyLimitsResponse" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="organization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConcurrencyLimitsResponse(
            global::Soniox.ScopeValues project,
            global::Soniox.ScopeValues organization)
        {
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConcurrencyLimitsResponse" /> class.
        /// </summary>
        public GetConcurrencyLimitsResponse()
        {
        }

    }
}