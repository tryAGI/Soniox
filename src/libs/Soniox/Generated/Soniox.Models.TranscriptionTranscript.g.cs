
#nullable enable

namespace Soniox
{
    /// <summary>
    /// The transcription text.<br/>
    /// Example: {"id":"19b6d61d-02db-4c25-bc71-b4094dc310c8","text":"Hello","tokens":[{"confidence":0.95,"end_ms":90,"start_ms":10,"text":"Hel"},{"confidence":0.98,"end_ms":160,"start_ms":110,"text":"lo"}]}
    /// </summary>
    public sealed partial class TranscriptionTranscript
    {
        /// <summary>
        /// Unique identifier of the transcription this transcript belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Complete transcribed text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// List of detailed token information with timestamps and metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.TranscriptionTranscriptToken> Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionTranscript" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the transcription this transcript belongs to.
        /// </param>
        /// <param name="text">
        /// Complete transcribed text content.
        /// </param>
        /// <param name="tokens">
        /// List of detailed token information with timestamps and metadata.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionTranscript(
            global::System.Guid id,
            string text,
            global::System.Collections.Generic.IList<global::Soniox.TranscriptionTranscriptToken> tokens)
        {
            this.Id = id;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionTranscript" /> class.
        /// </summary>
        public TranscriptionTranscript()
        {
        }
    }
}