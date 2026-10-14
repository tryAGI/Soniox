
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationProjectsResponse
    {
        /// <summary>
        /// Projects of the organization, oldest first. Deleted projects are not included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.OrganizationProjectEntry> Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationProjectsResponse" /> class.
        /// </summary>
        /// <param name="projects">
        /// Projects of the organization, oldest first. Deleted projects are not included.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationProjectsResponse(
            global::System.Collections.Generic.IList<global::Soniox.OrganizationProjectEntry> projects)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationProjectsResponse" /> class.
        /// </summary>
        public GetOrganizationProjectsResponse()
        {
        }

    }
}