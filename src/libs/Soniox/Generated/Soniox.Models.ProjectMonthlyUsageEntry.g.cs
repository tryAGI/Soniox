
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectMonthlyUsageEntry
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
        /// Cost of the month for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UsageUsd { get; set; }

        /// <summary>
        /// Part of the usage covered by granted balance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("free_usage_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FreeUsageUsd { get; set; }

        /// <summary>
        /// Part of the usage that is invoiced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoiced_usage_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvoicedUsageUsd { get; set; }

        /// <summary>
        /// Part of the usage made through the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_usage_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiUsageUsd { get; set; }

        /// <summary>
        /// Part of the usage made in the Soniox Console playground.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playground_usage_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlaygroundUsageUsd { get; set; }

        /// <summary>
        /// Project budget. Null means only the organization budget applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_budget_usd")]
        public string? MonthlyBudgetUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMonthlyUsageEntry" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the project.
        /// </param>
        /// <param name="name">
        /// Name of the project.
        /// </param>
        /// <param name="usageUsd">
        /// Cost of the month for this project.
        /// </param>
        /// <param name="freeUsageUsd">
        /// Part of the usage covered by granted balance.
        /// </param>
        /// <param name="invoicedUsageUsd">
        /// Part of the usage that is invoiced.
        /// </param>
        /// <param name="apiUsageUsd">
        /// Part of the usage made through the API.
        /// </param>
        /// <param name="playgroundUsageUsd">
        /// Part of the usage made in the Soniox Console playground.
        /// </param>
        /// <param name="monthlyBudgetUsd">
        /// Project budget. Null means only the organization budget applies.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectMonthlyUsageEntry(
            global::System.Guid id,
            string name,
            string usageUsd,
            string freeUsageUsd,
            string invoicedUsageUsd,
            string apiUsageUsd,
            string playgroundUsageUsd,
            string? monthlyBudgetUsd)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UsageUsd = usageUsd ?? throw new global::System.ArgumentNullException(nameof(usageUsd));
            this.FreeUsageUsd = freeUsageUsd ?? throw new global::System.ArgumentNullException(nameof(freeUsageUsd));
            this.InvoicedUsageUsd = invoicedUsageUsd ?? throw new global::System.ArgumentNullException(nameof(invoicedUsageUsd));
            this.ApiUsageUsd = apiUsageUsd ?? throw new global::System.ArgumentNullException(nameof(apiUsageUsd));
            this.PlaygroundUsageUsd = playgroundUsageUsd ?? throw new global::System.ArgumentNullException(nameof(playgroundUsageUsd));
            this.MonthlyBudgetUsd = monthlyBudgetUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMonthlyUsageEntry" /> class.
        /// </summary>
        public ProjectMonthlyUsageEntry()
        {
        }

    }
}