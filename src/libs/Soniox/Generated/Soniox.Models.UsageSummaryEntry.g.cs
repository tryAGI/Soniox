
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
        /// Part of `total_cost_usd` from requests made with an API key, in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_api_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalApiCostUsd { get; set; }

        /// <summary>
        /// Part of `total_cost_usd` from requests made in the Soniox Console playground, in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_playground_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalPlaygroundCostUsd { get; set; }

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
        /// Cost of requests made with an API key per day, in USD, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ApiCostUsd { get; set; }

        /// <summary>
        /// Cost of requests made in the Soniox Console playground per day, in USD, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playground_cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PlaygroundCostUsd { get; set; }

        /// <summary>
        /// Number of requests over the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_num_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalNumRequests { get; set; }

        /// <summary>
        /// Input text tokens over the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalInputTextTokens { get; set; }

        /// <summary>
        /// Input audio tokens over the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_audio_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalInputAudioTokens { get; set; }

        /// <summary>
        /// Input audio over the window, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_input_audio_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalInputAudioDurationMs { get; set; }

        /// <summary>
        /// Output text tokens over the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalOutputTextTokens { get; set; }

        /// <summary>
        /// Output audio tokens over the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_output_audio_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalOutputAudioTokens { get; set; }

        /// <summary>
        /// Output audio over the window, in milliseconds.
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
        /// Input text tokens per day, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> InputTextTokens { get; set; }

        /// <summary>
        /// Input audio tokens per day, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> InputAudioTokens { get; set; }

        /// <summary>
        /// Input audio per day, in milliseconds, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> InputAudioDurationMs { get; set; }

        /// <summary>
        /// Output text tokens per day, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_text_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> OutputTextTokens { get; set; }

        /// <summary>
        /// Output audio tokens per day, aligned to `days`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_audio_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> OutputAudioTokens { get; set; }

        /// <summary>
        /// Output audio per day, in milliseconds, aligned to `days`.
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
        /// <param name="totalApiCostUsd">
        /// Part of `total_cost_usd` from requests made with an API key, in USD.
        /// </param>
        /// <param name="totalPlaygroundCostUsd">
        /// Part of `total_cost_usd` from requests made in the Soniox Console playground, in USD.
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
        /// <param name="apiCostUsd">
        /// Cost of requests made with an API key per day, in USD, aligned to `days`.
        /// </param>
        /// <param name="playgroundCostUsd">
        /// Cost of requests made in the Soniox Console playground per day, in USD, aligned to `days`.
        /// </param>
        /// <param name="totalNumRequests">
        /// Number of requests over the window.
        /// </param>
        /// <param name="totalInputTextTokens">
        /// Input text tokens over the window.
        /// </param>
        /// <param name="totalInputAudioTokens">
        /// Input audio tokens over the window.
        /// </param>
        /// <param name="totalInputAudioDurationMs">
        /// Input audio over the window, in milliseconds.
        /// </param>
        /// <param name="totalOutputTextTokens">
        /// Output text tokens over the window.
        /// </param>
        /// <param name="totalOutputAudioTokens">
        /// Output audio tokens over the window.
        /// </param>
        /// <param name="totalOutputAudioDurationMs">
        /// Output audio over the window, in milliseconds.
        /// </param>
        /// <param name="totalDurationMs">
        /// Billed session duration over the window, in milliseconds, for models billed by duration. `0` for Speech-to-Text and Text-to-Speech models.
        /// </param>
        /// <param name="numRequests">
        /// Number of requests per day, aligned to `days`.
        /// </param>
        /// <param name="inputTextTokens">
        /// Input text tokens per day, aligned to `days`.
        /// </param>
        /// <param name="inputAudioTokens">
        /// Input audio tokens per day, aligned to `days`.
        /// </param>
        /// <param name="inputAudioDurationMs">
        /// Input audio per day, in milliseconds, aligned to `days`.
        /// </param>
        /// <param name="outputTextTokens">
        /// Output text tokens per day, aligned to `days`.
        /// </param>
        /// <param name="outputAudioTokens">
        /// Output audio tokens per day, aligned to `days`.
        /// </param>
        /// <param name="outputAudioDurationMs">
        /// Output audio per day, in milliseconds, aligned to `days`.
        /// </param>
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
            string totalApiCostUsd,
            string totalPlaygroundCostUsd,
            global::System.Collections.Generic.IList<string> costUsd,
            global::System.Collections.Generic.IList<string> inputCostUsd,
            global::System.Collections.Generic.IList<string> outputCostUsd,
            global::System.Collections.Generic.IList<string> durationCostUsd,
            global::System.Collections.Generic.IList<string> apiCostUsd,
            global::System.Collections.Generic.IList<string> playgroundCostUsd,
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
            this.TotalApiCostUsd = totalApiCostUsd ?? throw new global::System.ArgumentNullException(nameof(totalApiCostUsd));
            this.TotalPlaygroundCostUsd = totalPlaygroundCostUsd ?? throw new global::System.ArgumentNullException(nameof(totalPlaygroundCostUsd));
            this.CostUsd = costUsd ?? throw new global::System.ArgumentNullException(nameof(costUsd));
            this.InputCostUsd = inputCostUsd ?? throw new global::System.ArgumentNullException(nameof(inputCostUsd));
            this.OutputCostUsd = outputCostUsd ?? throw new global::System.ArgumentNullException(nameof(outputCostUsd));
            this.DurationCostUsd = durationCostUsd ?? throw new global::System.ArgumentNullException(nameof(durationCostUsd));
            this.ApiCostUsd = apiCostUsd ?? throw new global::System.ArgumentNullException(nameof(apiCostUsd));
            this.PlaygroundCostUsd = playgroundCostUsd ?? throw new global::System.ArgumentNullException(nameof(playgroundCostUsd));
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