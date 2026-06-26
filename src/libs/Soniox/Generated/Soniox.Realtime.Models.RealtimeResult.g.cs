
#nullable enable

namespace Soniox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<global::Soniox.Realtime.RealtimeToken>? Tokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final_audio_proc_ms")]
        public int? FinalAudioProcMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_audio_proc_ms")]
        public int? TotalAudioProcMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished")]
        public bool? Finished { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResult" /> class.
        /// </summary>
        /// <param name="tokens"></param>
        /// <param name="finalAudioProcMs"></param>
        /// <param name="totalAudioProcMs"></param>
        /// <param name="finished"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResult(
            global::System.Collections.Generic.IList<global::Soniox.Realtime.RealtimeToken>? tokens,
            int? finalAudioProcMs,
            int? totalAudioProcMs,
            bool? finished)
        {
            this.Tokens = tokens;
            this.FinalAudioProcMs = finalAudioProcMs;
            this.TotalAudioProcMs = totalAudioProcMs;
            this.Finished = finished;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResult" /> class.
        /// </summary>
        public RealtimeResult()
        {
        }

    }
}