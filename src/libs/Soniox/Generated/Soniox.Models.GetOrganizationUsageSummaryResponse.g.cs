
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationUsageSummaryResponse
    {
        /// <summary>
        /// Cost and activity across every project of the organization. Equals the sum of the `projects` entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.UsageSummaryEntry Total { get; set; }

        /// <summary>
        /// Projects with usage in the window, highest cost first. Projects deleted since are included, so the per-project costs add up to `total`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.OrganizationUsageSummaryProject> Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationUsageSummaryResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Cost and activity across every project of the organization. Equals the sum of the `projects` entries.
        /// </param>
        /// <param name="projects">
        /// Projects with usage in the window, highest cost first. Projects deleted since are included, so the per-project costs add up to `total`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationUsageSummaryResponse(
            global::Soniox.UsageSummaryEntry total,
            global::System.Collections.Generic.IList<global::Soniox.OrganizationUsageSummaryProject> projects)
        {
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationUsageSummaryResponse" /> class.
        /// </summary>
        public GetOrganizationUsageSummaryResponse()
        {
        }

    }
}