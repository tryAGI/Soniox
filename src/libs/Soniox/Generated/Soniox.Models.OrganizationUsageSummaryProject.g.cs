
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationUsageSummaryProject
    {
        /// <summary>
        /// Unique identifier of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Name of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Cost and activity across all models of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.UsageSummaryEntry Total { get; set; }

        /// <summary>
        /// Per-model cost and activity, highest cost first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.UsageSummaryEntry> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUsageSummaryProject" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the project.
        /// </param>
        /// <param name="name">
        /// Name of the project.
        /// </param>
        /// <param name="total">
        /// Cost and activity across all models of the project.
        /// </param>
        /// <param name="models">
        /// Per-model cost and activity, highest cost first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationUsageSummaryProject(
            global::System.Guid id,
            string name,
            global::Soniox.UsageSummaryEntry total,
            global::System.Collections.Generic.IList<global::Soniox.UsageSummaryEntry> models)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUsageSummaryProject" /> class.
        /// </summary>
        public OrganizationUsageSummaryProject()
        {
        }

    }
}