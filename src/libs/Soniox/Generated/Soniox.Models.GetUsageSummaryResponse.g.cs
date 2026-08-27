
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsageSummaryResponse
    {
        /// <summary>
        /// Cost and activity across all models. Its `model` is `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.UsageSummaryEntry Total { get; set; }

        /// <summary>
        /// One entry per model that recorded usage in the window. Empty when the project had no usage.
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
        /// Initializes a new instance of the <see cref="GetUsageSummaryResponse" /> class.
        /// </summary>
        /// <param name="total">
        /// Cost and activity across all models. Its `model` is `null`.
        /// </param>
        /// <param name="models">
        /// One entry per model that recorded usage in the window. Empty when the project had no usage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageSummaryResponse(
            global::Soniox.UsageSummaryEntry total,
            global::System.Collections.Generic.IList<global::Soniox.UsageSummaryEntry> models)
        {
            this.Total = total ?? throw new global::System.ArgumentNullException(nameof(total));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageSummaryResponse" /> class.
        /// </summary>
        public GetUsageSummaryResponse()
        {
        }

    }
}