
#nullable enable

namespace Soniox.Realtime.Tts
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtsAudio
    {
        /// <summary>
        /// Stream identifier this audio belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }

        /// <summary>
        /// Base64-encoded audio bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// True when this is the final audio chunk for the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end")]
        public bool? AudioEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamps")]
        public global::Soniox.Realtime.Tts.TtsTimestamps? Timestamps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAudio" /> class.
        /// </summary>
        /// <param name="streamId">
        /// Stream identifier this audio belongs to.
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio bytes.
        /// </param>
        /// <param name="audioEnd">
        /// True when this is the final audio chunk for the stream.
        /// </param>
        /// <param name="timestamps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsAudio(
            string? streamId,
            string? audio,
            bool? audioEnd,
            global::Soniox.Realtime.Tts.TtsTimestamps? timestamps)
        {
            this.StreamId = streamId;
            this.Audio = audio;
            this.AudioEnd = audioEnd;
            this.Timestamps = timestamps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsAudio" /> class.
        /// </summary>
        public TtsAudio()
        {
        }

    }
}