
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetOrganizationBalanceResponse
    {
        /// <summary>
        /// Prepaid balance left to spend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_balance_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvailableBalanceUsd { get; set; }

        /// <summary>
        /// Part of the available balance that was granted, not paid for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("free_balance_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FreeBalanceUsd { get; set; }

        /// <summary>
        /// Prepaid balance spent so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_balance_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UsedBalanceUsd { get; set; }

        /// <summary>
        /// Usage is invoiced instead of drawn from the prepaid balance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoice_billing_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool InvoiceBillingEnabled { get; set; }

        /// <summary>
        /// The prepaid balance is spent and requests are refused. Always false with invoice billing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_exhausted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BalanceExhausted { get; set; }

        /// <summary>
        /// The balance is topped up automatically below the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autopay_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutopayEnabled { get; set; }

        /// <summary>
        /// Balance below which a top-up is charged. Null without a billing setup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autopay_threshold_usd")]
        public string? AutopayThresholdUsd { get; set; }

        /// <summary>
        /// Amount of one top-up. Null without a billing setup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autopay_amount_usd")]
        public string? AutopayAmountUsd { get; set; }

        /// <summary>
        /// A payment method is on file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_payment_method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPaymentMethod { get; set; }

        /// <summary>
        /// The last payment attempt failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_payment_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasPaymentError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationBalanceResponse" /> class.
        /// </summary>
        /// <param name="availableBalanceUsd">
        /// Prepaid balance left to spend.
        /// </param>
        /// <param name="freeBalanceUsd">
        /// Part of the available balance that was granted, not paid for.
        /// </param>
        /// <param name="usedBalanceUsd">
        /// Prepaid balance spent so far.
        /// </param>
        /// <param name="invoiceBillingEnabled">
        /// Usage is invoiced instead of drawn from the prepaid balance.
        /// </param>
        /// <param name="balanceExhausted">
        /// The prepaid balance is spent and requests are refused. Always false with invoice billing.
        /// </param>
        /// <param name="autopayEnabled">
        /// The balance is topped up automatically below the threshold.
        /// </param>
        /// <param name="hasPaymentMethod">
        /// A payment method is on file.
        /// </param>
        /// <param name="hasPaymentError">
        /// The last payment attempt failed.
        /// </param>
        /// <param name="autopayThresholdUsd">
        /// Balance below which a top-up is charged. Null without a billing setup.
        /// </param>
        /// <param name="autopayAmountUsd">
        /// Amount of one top-up. Null without a billing setup.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationBalanceResponse(
            string availableBalanceUsd,
            string freeBalanceUsd,
            string usedBalanceUsd,
            bool invoiceBillingEnabled,
            bool balanceExhausted,
            bool autopayEnabled,
            bool hasPaymentMethod,
            bool hasPaymentError,
            string? autopayThresholdUsd,
            string? autopayAmountUsd)
        {
            this.AvailableBalanceUsd = availableBalanceUsd ?? throw new global::System.ArgumentNullException(nameof(availableBalanceUsd));
            this.FreeBalanceUsd = freeBalanceUsd ?? throw new global::System.ArgumentNullException(nameof(freeBalanceUsd));
            this.UsedBalanceUsd = usedBalanceUsd ?? throw new global::System.ArgumentNullException(nameof(usedBalanceUsd));
            this.InvoiceBillingEnabled = invoiceBillingEnabled;
            this.BalanceExhausted = balanceExhausted;
            this.AutopayEnabled = autopayEnabled;
            this.AutopayThresholdUsd = autopayThresholdUsd;
            this.AutopayAmountUsd = autopayAmountUsd;
            this.HasPaymentMethod = hasPaymentMethod;
            this.HasPaymentError = hasPaymentError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationBalanceResponse" /> class.
        /// </summary>
        public GetOrganizationBalanceResponse()
        {
        }

    }
}