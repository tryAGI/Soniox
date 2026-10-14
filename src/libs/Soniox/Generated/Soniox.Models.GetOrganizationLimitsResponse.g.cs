
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationLimitsResponse
    {
        /// <summary>
        /// Organization budget in effect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_budget_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MonthlyBudgetUsd { get; set; }

        /// <summary>
        /// Highest budget the organization may set for itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_budget_max_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MonthlyBudgetMaxUsd { get; set; }

        /// <summary>
        /// Usage at which the organization is emailed. Null when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_budget_notification_usd")]
        public string? MonthlyBudgetNotificationUsd { get; set; }

        /// <summary>
        /// Limits per region the organization has access to, defaults filled in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.RegionLimitsEntry> Regions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationLimitsResponse" /> class.
        /// </summary>
        /// <param name="monthlyBudgetUsd">
        /// Organization budget in effect.
        /// </param>
        /// <param name="monthlyBudgetMaxUsd">
        /// Highest budget the organization may set for itself.
        /// </param>
        /// <param name="regions">
        /// Limits per region the organization has access to, defaults filled in.
        /// </param>
        /// <param name="monthlyBudgetNotificationUsd">
        /// Usage at which the organization is emailed. Null when unset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationLimitsResponse(
            string monthlyBudgetUsd,
            string monthlyBudgetMaxUsd,
            global::System.Collections.Generic.IList<global::Soniox.RegionLimitsEntry> regions,
            string? monthlyBudgetNotificationUsd)
        {
            this.MonthlyBudgetUsd = monthlyBudgetUsd ?? throw new global::System.ArgumentNullException(nameof(monthlyBudgetUsd));
            this.MonthlyBudgetMaxUsd = monthlyBudgetMaxUsd ?? throw new global::System.ArgumentNullException(nameof(monthlyBudgetMaxUsd));
            this.MonthlyBudgetNotificationUsd = monthlyBudgetNotificationUsd;
            this.Regions = regions ?? throw new global::System.ArgumentNullException(nameof(regions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationLimitsResponse" /> class.
        /// </summary>
        public GetOrganizationLimitsResponse()
        {
        }

    }
}