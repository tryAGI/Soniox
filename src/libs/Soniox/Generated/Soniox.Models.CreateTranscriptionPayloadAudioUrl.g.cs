
#nullable enable

namespace Soniox
{
    /// <summary>
    /// URL of the audio file to transcribe. Cannot be specified if `file_id` is specified.
    /// </summary>
    public sealed partial class CreateTranscriptionPayloadAudioUrl
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}