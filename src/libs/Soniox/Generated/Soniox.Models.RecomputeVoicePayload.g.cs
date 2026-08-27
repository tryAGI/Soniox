
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RecomputeVoicePayload
    {
        /// <summary>
        /// The model to prepare this voice for. If omitted, the voice is prepared for every available model it is not ready for yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecomputeVoicePayload" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to prepare this voice for. If omitted, the voice is prepared for every available model it is not ready for yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecomputeVoicePayload(
            string? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecomputeVoicePayload" /> class.
        /// </summary>
        public RecomputeVoicePayload()
        {
        }

    }
}