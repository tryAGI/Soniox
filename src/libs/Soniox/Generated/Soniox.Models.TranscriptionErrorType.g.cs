
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Error type if transcription failed. `null` for successful or in-progress transcriptions.
    /// </summary>
    public sealed partial class TranscriptionErrorType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}