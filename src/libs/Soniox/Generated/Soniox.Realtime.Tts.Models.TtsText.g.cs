
#nullable enable

namespace Soniox.Realtime.Tts
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TtsText
    {
        /// <summary>
        /// Stream identifier to append text to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StreamId { get; set; }

        /// <summary>
        /// Text chunk to synthesize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// True when this is the final text chunk for the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TextEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsText" /> class.
        /// </summary>
        /// <param name="streamId">
        /// Stream identifier to append text to.
        /// </param>
        /// <param name="text">
        /// Text chunk to synthesize.
        /// </param>
        /// <param name="textEnd">
        /// True when this is the final text chunk for the stream.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtsText(
            string streamId,
            string text,
            bool textEnd)
        {
            this.StreamId = streamId ?? throw new global::System.ArgumentNullException(nameof(streamId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.TextEnd = textEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtsText" /> class.
        /// </summary>
        public TtsText()
        {
        }

    }
}