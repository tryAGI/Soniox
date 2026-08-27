
#nullable enable

namespace Soniox.Realtime.Tts
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TtsTimestamps
    {
        /// <summary>
        /// Characters covered by this audio frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public global::System.Collections.Generic.IList<string>? Characters { get; set; }

        /// <summary>
        /// Per-character start times in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_start_times_seconds")]
        public global::System.Collections.Generic.IList<double>? CharacterStartTimesSeconds { get; set; }

        /// <summary>
        /// Per-character end times in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_end_times_seconds")]
        public global::System.Collections.Generic.IList<double>? CharacterEndTimesSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTimestamps" /> class.
        /// </summary>
        /// <param name="characters">
        /// Characters covered by this audio frame.
        /// </param>
        /// <param name="characterStartTimesSeconds">
        /// Per-character start times in seconds.
        /// </param>
        /// <param name="characterEndTimesSeconds">
        /// Per-character end times in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsTimestamps(
            global::System.Collections.Generic.IList<string>? characters,
            global::System.Collections.Generic.IList<double>? characterStartTimesSeconds,
            global::System.Collections.Generic.IList<double>? characterEndTimesSeconds)
        {
            this.Characters = characters;
            this.CharacterStartTimesSeconds = characterStartTimesSeconds;
            this.CharacterEndTimesSeconds = characterEndTimesSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsTimestamps" /> class.
        /// </summary>
        public TtsTimestamps()
        {
        }

    }
}