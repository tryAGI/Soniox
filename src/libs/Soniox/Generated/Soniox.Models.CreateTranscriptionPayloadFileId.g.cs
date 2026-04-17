
#nullable enable

namespace Soniox
{
    /// <summary>
    /// ID of the uploaded file to transcribe. Cannot be specified if `audio_url` is specified.
    /// </summary>
    public sealed partial class CreateTranscriptionPayloadFileId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}