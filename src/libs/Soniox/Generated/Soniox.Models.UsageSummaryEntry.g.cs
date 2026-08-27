
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageSummaryEntry
    {
        /// <summary>
        /// Model identifier. `null` on the `total` entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// One UTC day (`YYYY-MM-DD`) per element, in ascending order. Every day in the requested window is present, including days with no usage. All the per-day arrays below align to this axis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.DateTime> Days { get; set; }

        /// <summary>
        /// Total cost over the window, in USD. Equals `total_input_cost_usd` + `total_output_cost_usd` + `total_duration_cost_usd`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalCostUsd { get; set; }

        /// <summary>
        /// Total cost of input tokens over the window, in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalInputCostUsd { get; set; }

        /// <summary>
        /// Total cost of output tokens over the window, in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalOutputCostUsd { get; set; }

        /// <summary>
        /// Total cost over the window for models billed by session duration rather than by tokens, in USD. `0` for Speech-to-Text and Text-to-Speech models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalDurationCostUsd { get; set; }

        /// <summary>
        /// Cost per day, in USD, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CostUsd { get; set; }

        /// <summary>
        /// Cost of input tokens per day, in USD, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InputCostUsd { get; set; }

        /// <summary>
        /// Cost of output tokens per day, in USD, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OutputCostUsd { get; set; }

        /// <summary>
        /// Duration-billed cost per day, in USD, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DurationCostUsd { get; set; }

        /// <summary>
        /// Number of requests over the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_num_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalNumRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalInputTextTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_audio_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalInputAudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_audio_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalInputAudioDurationMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalOutputTextTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_audio_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalOutputAudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_audio_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalOutputAudioDurationMs { get; set; }

        /// <summary>
        /// Billed session duration over the window, in milliseconds, for models billed by duration. `0` for Speech-to-Text and Text-to-Speech models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalDurationMs { get; set; }

        /// <summary>
        /// Number of requests per day, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> NumRequests { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> InputTextTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> InputAudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> InputAudioDurationMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> OutputTextTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> OutputAudioTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> OutputAudioDurationMs { get; set; }

        /// <summary>
        /// Billed session duration per day, in milliseconds, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSummaryEntry" /> class.
        /// </summary>
        /// <param name="days">
        /// One UTC day (`YYYY-MM-DD`) per element, in ascending order. Every day in the requested window is present, including days with no usage. All the per-day arrays below align to this axis.
        /// </param>
        /// <param name="totalCostUsd">
        /// Total cost over the window, in USD. Equals `total_input_cost_usd` + `total_output_cost_usd` + `total_duration_cost_usd`.
        /// </param>
        /// <param name="totalInputCostUsd">
        /// Total cost of input tokens over the window, in USD.
        /// </param>
        /// <param name="totalOutputCostUsd">
        /// Total cost of output tokens over the window, in USD.
        /// </param>
        /// <param name="totalDurationCostUsd">
        /// Total cost over the window for models billed by session duration rather than by tokens, in USD. `0` for Speech-to-Text and Text-to-Speech models.
        /// </param>
        /// <param name="costUsd">
        /// Cost per day, in USD, aligned to `days`.
        /// </param>
        /// <param name="inputCostUsd">
        /// Cost of input tokens per day, in USD, aligned to `days`.
        /// </param>
        /// <param name="outputCostUsd">
        /// Cost of output tokens per day, in USD, aligned to `days`.
        /// </param>
        /// <param name="durationCostUsd">
        /// Duration-billed cost per day, in USD, aligned to `days`.
        /// </param>
        /// <param name="totalNumRequests">
        /// Number of requests over the window.
        /// </param>
        /// <param name="totalInputTextTokens"></param>
        /// <param name="totalInputAudioTokens"></param>
        /// <param name="totalInputAudioDurationMs"></param>
        /// <param name="totalOutputTextTokens"></param>
        /// <param name="totalOutputAudioTokens"></param>
        /// <param name="totalOutputAudioDurationMs"></param>
        /// <param name="totalDurationMs">
        /// Billed session duration over the window, in milliseconds, for models billed by duration. `0` for Speech-to-Text and Text-to-Speech models.
        /// </param>
        /// <param name="numRequests">
        /// Number of requests per day, aligned to `days`.
        /// </param>
        /// <param name="inputTextTokens"></param>
        /// <param name="inputAudioTokens"></param>
        /// <param name="inputAudioDurationMs"></param>
        /// <param name="outputTextTokens"></param>
        /// <param name="outputAudioTokens"></param>
        /// <param name="outputAudioDurationMs"></param>
        /// <param name="durationMs">
        /// Billed session duration per day, in milliseconds, aligned to `days`.
        /// </param>
        /// <param name="model">
        /// Model identifier. `null` on the `total` entry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageSummaryEntry(
            global::System.Collections.Generic.IList<global::System.DateTime> days,
            string totalCostUsd,
            string totalInputCostUsd,
            string totalOutputCostUsd,
            string totalDurationCostUsd,
            global::System.Collections.Generic.IList<string> costUsd,
            global::System.Collections.Generic.IList<string> inputCostUsd,
            global::System.Collections.Generic.IList<string> outputCostUsd,
            global::System.Collections.Generic.IList<string> durationCostUsd,
            int totalNumRequests,
            int totalInputTextTokens,
            int totalInputAudioTokens,
            int totalInputAudioDurationMs,
            int totalOutputTextTokens,
            int totalOutputAudioTokens,
            int totalOutputAudioDurationMs,
            int totalDurationMs,
            global::System.Collections.Generic.IList<int> numRequests,
            global::System.Collections.Generic.IList<int> inputTextTokens,
            global::System.Collections.Generic.IList<int> inputAudioTokens,
            global::System.Collections.Generic.IList<int> inputAudioDurationMs,
            global::System.Collections.Generic.IList<int> outputTextTokens,
            global::System.Collections.Generic.IList<int> outputAudioTokens,
            global::System.Collections.Generic.IList<int> outputAudioDurationMs,
            global::System.Collections.Generic.IList<int> durationMs,
            string? model)
        {
            this.Model = model;
            this.Days = days ?? throw new global::System.ArgumentNullException(nameof(days));
            this.TotalCostUsd = totalCostUsd ?? throw new global::System.ArgumentNullException(nameof(totalCostUsd));
            this.TotalInputCostUsd = totalInputCostUsd ?? throw new global::System.ArgumentNullException(nameof(totalInputCostUsd));
            this.TotalOutputCostUsd = totalOutputCostUsd ?? throw new global::System.ArgumentNullException(nameof(totalOutputCostUsd));
            this.TotalDurationCostUsd = totalDurationCostUsd ?? throw new global::System.ArgumentNullException(nameof(totalDurationCostUsd));
            this.CostUsd = costUsd ?? throw new global::System.ArgumentNullException(nameof(costUsd));
            this.InputCostUsd = inputCostUsd ?? throw new global::System.ArgumentNullException(nameof(inputCostUsd));
            this.OutputCostUsd = outputCostUsd ?? throw new global::System.ArgumentNullException(nameof(outputCostUsd));
            this.DurationCostUsd = durationCostUsd ?? throw new global::System.ArgumentNullException(nameof(durationCostUsd));
            this.TotalNumRequests = totalNumRequests;
            this.TotalInputTextTokens = totalInputTextTokens;
            this.TotalInputAudioTokens = totalInputAudioTokens;
            this.TotalInputAudioDurationMs = totalInputAudioDurationMs;
            this.TotalOutputTextTokens = totalOutputTextTokens;
            this.TotalOutputAudioTokens = totalOutputAudioTokens;
            this.TotalOutputAudioDurationMs = totalOutputAudioDurationMs;
            this.TotalDurationMs = totalDurationMs;
            this.NumRequests = numRequests ?? throw new global::System.ArgumentNullException(nameof(numRequests));
            this.InputTextTokens = inputTextTokens ?? throw new global::System.ArgumentNullException(nameof(inputTextTokens));
            this.InputAudioTokens = inputAudioTokens ?? throw new global::System.ArgumentNullException(nameof(inputAudioTokens));
            this.InputAudioDurationMs = inputAudioDurationMs ?? throw new global::System.ArgumentNullException(nameof(inputAudioDurationMs));
            this.OutputTextTokens = outputTextTokens ?? throw new global::System.ArgumentNullException(nameof(outputTextTokens));
            this.OutputAudioTokens = outputAudioTokens ?? throw new global::System.ArgumentNullException(nameof(outputAudioTokens));
            this.OutputAudioDurationMs = outputAudioDurationMs ?? throw new global::System.ArgumentNullException(nameof(outputAudioDurationMs));
            this.DurationMs = durationMs ?? throw new global::System.ArgumentNullException(nameof(durationMs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSummaryEntry" /> class.
        /// </summary>
        public UsageSummaryEntry()
        {
        }

    }
}