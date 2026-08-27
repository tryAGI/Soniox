
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScopeValues
    {
        /// <summary>
        /// Live counts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.CurrentValues Current { get; set; }

        /// <summary>
        /// Configured limits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.LimitValues Limits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeValues" /> class.
        /// </summary>
        /// <param name="current">
        /// Live counts.
        /// </param>
        /// <param name="limits">
        /// Configured limits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScopeValues(
            global::Soniox.CurrentValues current,
            global::Soniox.LimitValues limits)
        {
            this.Current = current ?? throw new global::System.ArgumentNullException(nameof(current));
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScopeValues" /> class.
        /// </summary>
        public ScopeValues()
        {
        }

    }
}