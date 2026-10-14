
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RegionLimitsEntry
    {
        /// <summary>
        /// Region the limits apply to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// Real-time STT sessions per minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribe_rpm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TranscribeRpm { get; set; }

        /// <summary>
        /// Concurrent real-time STT sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribe_concurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TranscribeConcurrent { get; set; }

        /// <summary>
        /// TTS requests per minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_rpm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TtsRpm { get; set; }

        /// <summary>
        /// Concurrent TTS sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts_concurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TtsConcurrent { get; set; }

        /// <summary>
        /// Async transcription requests per minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribe_async_rpm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TranscribeAsyncRpm { get; set; }

        /// <summary>
        /// Async transcriptions processed at once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribe_async_concurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TranscribeAsyncConcurrent { get; set; }

        /// <summary>
        /// Async transcriptions kept in total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribe_async_total_num_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TranscribeAsyncTotalNumFiles { get; set; }

        /// <summary>
        /// Async transcriptions waiting or in progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribe_async_pending_num_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TranscribeAsyncPendingNumFiles { get; set; }

        /// <summary>
        /// File requests per minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files_rpm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilesRpm { get; set; }

        /// <summary>
        /// Total size of stored files, in GB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files_total_size_gb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilesTotalSizeGb { get; set; }

        /// <summary>
        /// Stored files in total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files_total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FilesTotalCount { get; set; }

        /// <summary>
        /// Voice requests per minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices_rpm")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoicesRpm { get; set; }

        /// <summary>
        /// Cloned voices in total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices_total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VoicesTotalCount { get; set; }

        /// <summary>
        /// Webhook deliveries in flight at once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks_concurrent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WebhooksConcurrent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionLimitsEntry" /> class.
        /// </summary>
        /// <param name="region">
        /// Region the limits apply to.
        /// </param>
        /// <param name="transcribeRpm">
        /// Real-time STT sessions per minute.
        /// </param>
        /// <param name="transcribeConcurrent">
        /// Concurrent real-time STT sessions.
        /// </param>
        /// <param name="ttsRpm">
        /// TTS requests per minute.
        /// </param>
        /// <param name="ttsConcurrent">
        /// Concurrent TTS sessions.
        /// </param>
        /// <param name="transcribeAsyncRpm">
        /// Async transcription requests per minute.
        /// </param>
        /// <param name="transcribeAsyncConcurrent">
        /// Async transcriptions processed at once.
        /// </param>
        /// <param name="transcribeAsyncTotalNumFiles">
        /// Async transcriptions kept in total.
        /// </param>
        /// <param name="transcribeAsyncPendingNumFiles">
        /// Async transcriptions waiting or in progress.
        /// </param>
        /// <param name="filesRpm">
        /// File requests per minute.
        /// </param>
        /// <param name="filesTotalSizeGb">
        /// Total size of stored files, in GB.
        /// </param>
        /// <param name="filesTotalCount">
        /// Stored files in total.
        /// </param>
        /// <param name="voicesRpm">
        /// Voice requests per minute.
        /// </param>
        /// <param name="voicesTotalCount">
        /// Cloned voices in total.
        /// </param>
        /// <param name="webhooksConcurrent">
        /// Webhook deliveries in flight at once.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegionLimitsEntry(
            string region,
            string transcribeRpm,
            int transcribeConcurrent,
            string ttsRpm,
            int ttsConcurrent,
            string transcribeAsyncRpm,
            int transcribeAsyncConcurrent,
            int transcribeAsyncTotalNumFiles,
            int transcribeAsyncPendingNumFiles,
            string filesRpm,
            string filesTotalSizeGb,
            int filesTotalCount,
            string voicesRpm,
            int voicesTotalCount,
            int webhooksConcurrent)
        {
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.TranscribeRpm = transcribeRpm ?? throw new global::System.ArgumentNullException(nameof(transcribeRpm));
            this.TranscribeConcurrent = transcribeConcurrent;
            this.TtsRpm = ttsRpm ?? throw new global::System.ArgumentNullException(nameof(ttsRpm));
            this.TtsConcurrent = ttsConcurrent;
            this.TranscribeAsyncRpm = transcribeAsyncRpm ?? throw new global::System.ArgumentNullException(nameof(transcribeAsyncRpm));
            this.TranscribeAsyncConcurrent = transcribeAsyncConcurrent;
            this.TranscribeAsyncTotalNumFiles = transcribeAsyncTotalNumFiles;
            this.TranscribeAsyncPendingNumFiles = transcribeAsyncPendingNumFiles;
            this.FilesRpm = filesRpm ?? throw new global::System.ArgumentNullException(nameof(filesRpm));
            this.FilesTotalSizeGb = filesTotalSizeGb ?? throw new global::System.ArgumentNullException(nameof(filesTotalSizeGb));
            this.FilesTotalCount = filesTotalCount;
            this.VoicesRpm = voicesRpm ?? throw new global::System.ArgumentNullException(nameof(voicesRpm));
            this.VoicesTotalCount = voicesTotalCount;
            this.WebhooksConcurrent = webhooksConcurrent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionLimitsEntry" /> class.
        /// </summary>
        public RegionLimitsEntry()
        {
        }

    }
}