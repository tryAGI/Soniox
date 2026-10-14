
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationMonthlyUsageResponse
    {
        /// <summary>
        /// The month, as YYYY-MM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("month")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Month { get; set; }

        /// <summary>
        /// Cost of the month across every project.
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
        /// Organization budget in effect. Null for a month other than the current one: only today's budget is stored, so it says nothing about a month that has closed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_budget_usd")]
        public string? MonthlyBudgetUsd { get; set; }

        /// <summary>
        /// Usage at which the organization is emailed. Null when unset, and for a month other than the current one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_budget_notification_usd")]
        public string? MonthlyBudgetNotificationUsd { get; set; }

        /// <summary>
        /// Budget minus usage, never below zero. Null for a month other than the current one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining_budget_usd")]
        public string? RemainingBudgetUsd { get; set; }

        /// <summary>
        /// Usage reached the budget and requests are refused. Null for a month other than the current one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_exhausted")]
        public bool? BudgetExhausted { get; set; }

        /// <summary>
        /// Projects with usage this month, highest cost first. Projects deleted since are included, so the per-project costs add up to `usage_usd`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.ProjectMonthlyUsageEntry> Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMonthlyUsageResponse" /> class.
        /// </summary>
        /// <param name="month">
        /// The month, as YYYY-MM.
        /// </param>
        /// <param name="usageUsd">
        /// Cost of the month across every project.
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
        /// <param name="projects">
        /// Projects with usage this month, highest cost first. Projects deleted since are included, so the per-project costs add up to `usage_usd`.
        /// </param>
        /// <param name="monthlyBudgetUsd">
        /// Organization budget in effect. Null for a month other than the current one: only today's budget is stored, so it says nothing about a month that has closed.
        /// </param>
        /// <param name="monthlyBudgetNotificationUsd">
        /// Usage at which the organization is emailed. Null when unset, and for a month other than the current one.
        /// </param>
        /// <param name="remainingBudgetUsd">
        /// Budget minus usage, never below zero. Null for a month other than the current one.
        /// </param>
        /// <param name="budgetExhausted">
        /// Usage reached the budget and requests are refused. Null for a month other than the current one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationMonthlyUsageResponse(
            string month,
            string usageUsd,
            string freeUsageUsd,
            string invoicedUsageUsd,
            string apiUsageUsd,
            string playgroundUsageUsd,
            global::System.Collections.Generic.IList<global::Soniox.ProjectMonthlyUsageEntry> projects,
            string? monthlyBudgetUsd,
            string? monthlyBudgetNotificationUsd,
            string? remainingBudgetUsd,
            bool? budgetExhausted)
        {
            this.Month = month ?? throw new global::System.ArgumentNullException(nameof(month));
            this.UsageUsd = usageUsd ?? throw new global::System.ArgumentNullException(nameof(usageUsd));
            this.FreeUsageUsd = freeUsageUsd ?? throw new global::System.ArgumentNullException(nameof(freeUsageUsd));
            this.InvoicedUsageUsd = invoicedUsageUsd ?? throw new global::System.ArgumentNullException(nameof(invoicedUsageUsd));
            this.ApiUsageUsd = apiUsageUsd ?? throw new global::System.ArgumentNullException(nameof(apiUsageUsd));
            this.PlaygroundUsageUsd = playgroundUsageUsd ?? throw new global::System.ArgumentNullException(nameof(playgroundUsageUsd));
            this.MonthlyBudgetUsd = monthlyBudgetUsd;
            this.MonthlyBudgetNotificationUsd = monthlyBudgetNotificationUsd;
            this.RemainingBudgetUsd = remainingBudgetUsd;
            this.BudgetExhausted = budgetExhausted;
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMonthlyUsageResponse" /> class.
        /// </summary>
        public GetOrganizationMonthlyUsageResponse()
        {
        }

    }
}