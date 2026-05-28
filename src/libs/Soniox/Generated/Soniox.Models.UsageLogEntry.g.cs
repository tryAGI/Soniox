
#nullable enable

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageLogEntry
    {
        /// <summary>
        /// Unique identifier of the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Uuid { get; set; }

        /// <summary>
        /// Scope of the request (api / playground).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestScope { get; set; }

        /// <summary>
        /// Client reference ID supplied on the original request. Empty string if none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_reference_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientReferenceId { get; set; }

        /// <summary>
        /// Model identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// When the request started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// When the request ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTextTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputAudioTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputAudioDurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTextTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputAudioTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputAudioDurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CostUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputCostUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputTextCostUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InputAudioCostUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputCostUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_text_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputTextCostUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputAudioCostUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLogEntry" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Unique identifier of the request.
        /// </param>
        /// <param name="requestScope">
        /// Scope of the request (api / playground).
        /// </param>
        /// <param name="clientReferenceId">
        /// Client reference ID supplied on the original request. Empty string if none.
        /// </param>
        /// <param name="model">
        /// Model identifier.
        /// </param>
        /// <param name="startTime">
        /// When the request started.
        /// </param>
        /// <param name="endTime">
        /// When the request ended.
        /// </param>
        /// <param name="inputTextTokens"></param>
        /// <param name="inputAudioTokens"></param>
        /// <param name="inputAudioDurationMs"></param>
        /// <param name="outputTextTokens"></param>
        /// <param name="outputAudioTokens"></param>
        /// <param name="outputAudioDurationMs"></param>
        /// <param name="costUsd"></param>
        /// <param name="inputCostUsd"></param>
        /// <param name="inputTextCostUsd"></param>
        /// <param name="inputAudioCostUsd"></param>
        /// <param name="outputCostUsd"></param>
        /// <param name="outputTextCostUsd"></param>
        /// <param name="outputAudioCostUsd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageLogEntry(
            global::System.Guid uuid,
            string requestScope,
            string clientReferenceId,
            string model,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            int inputTextTokens,
            int inputAudioTokens,
            int inputAudioDurationMs,
            int outputTextTokens,
            int outputAudioTokens,
            int outputAudioDurationMs,
            string costUsd,
            string inputCostUsd,
            string inputTextCostUsd,
            string inputAudioCostUsd,
            string outputCostUsd,
            string outputTextCostUsd,
            string outputAudioCostUsd)
        {
            this.Uuid = uuid;
            this.RequestScope = requestScope ?? throw new global::System.ArgumentNullException(nameof(requestScope));
            this.ClientReferenceId = clientReferenceId ?? throw new global::System.ArgumentNullException(nameof(clientReferenceId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.InputTextTokens = inputTextTokens;
            this.InputAudioTokens = inputAudioTokens;
            this.InputAudioDurationMs = inputAudioDurationMs;
            this.OutputTextTokens = outputTextTokens;
            this.OutputAudioTokens = outputAudioTokens;
            this.OutputAudioDurationMs = outputAudioDurationMs;
            this.CostUsd = costUsd ?? throw new global::System.ArgumentNullException(nameof(costUsd));
            this.InputCostUsd = inputCostUsd ?? throw new global::System.ArgumentNullException(nameof(inputCostUsd));
            this.InputTextCostUsd = inputTextCostUsd ?? throw new global::System.ArgumentNullException(nameof(inputTextCostUsd));
            this.InputAudioCostUsd = inputAudioCostUsd ?? throw new global::System.ArgumentNullException(nameof(inputAudioCostUsd));
            this.OutputCostUsd = outputCostUsd ?? throw new global::System.ArgumentNullException(nameof(outputCostUsd));
            this.OutputTextCostUsd = outputTextCostUsd ?? throw new global::System.ArgumentNullException(nameof(outputTextCostUsd));
            this.OutputAudioCostUsd = outputAudioCostUsd ?? throw new global::System.ArgumentNullException(nameof(outputAudioCostUsd));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLogEntry" /> class.
        /// </summary>
        public UsageLogEntry()
        {
        }

    }
}