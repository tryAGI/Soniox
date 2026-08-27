
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoiceModel
    {
        /// <summary>
        /// Name of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Has to be 'ready' for the voice to be usable with this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.JsonConverters.VoiceModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Soniox.VoiceModelStatus Status { get; set; }

        /// <summary>
        /// Machine-readable error category when status is 'failed'. Stable across releases — safe to use in control flow. `null` otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// Human-readable error message when status is 'failed' (e.g. the reference audio is too long). `null` otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceModel" /> class.
        /// </summary>
        /// <param name="model">
        /// Name of the model.
        /// </param>
        /// <param name="status">
        /// Has to be 'ready' for the voice to be usable with this model.
        /// </param>
        /// <param name="errorType">
        /// Machine-readable error category when status is 'failed'. Stable across releases — safe to use in control flow. `null` otherwise.
        /// </param>
        /// <param name="errorMessage">
        /// Human-readable error message when status is 'failed' (e.g. the reference audio is too long). `null` otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceModel(
            string model,
            global::Soniox.VoiceModelStatus status,
            string? errorType,
            string? errorMessage)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Status = status;
            this.ErrorType = errorType;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceModel" /> class.
        /// </summary>
        public VoiceModel()
        {
        }

    }
}