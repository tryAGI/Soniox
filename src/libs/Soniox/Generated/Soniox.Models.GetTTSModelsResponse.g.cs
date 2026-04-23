
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Example: {"models":[{"aliased_model_id":null,"id":"tts-rt-v1-preview","languages":[{"code":"af","name":"Afrikaans"},{"code":"ar","name":"Arabic"},{"code":"az","name":"Azerbaijani"},{"code":"be","name":"Belarusian"},{"code":"bg","name":"Bulgarian"},{"code":"bn","name":"Bengali"},{"code":"bs","name":"Bosnian"},{"code":"ca","name":"Catalan"},{"code":"cs","name":"Czech"},{"code":"cy","name":"Welsh"},{"code":"da","name":"Danish"},{"code":"de","name":"German"},{"code":"el","name":"Greek"},{"code":"en","name":"English"},{"code":"es","name":"Spanish"},{"code":"et","name":"Estonian"},{"code":"eu","name":"Basque"},{"code":"fa","name":"Persian"},{"code":"fi","name":"Finnish"},{"code":"fr","name":"French"},{"code":"gl","name":"Galician"},{"code":"gu","name":"Gujarati"},{"code":"he","name":"Hebrew"},{"code":"hi","name":"Hindi"},{"code":"hr","name":"Croatian"},{"code":"hu","name":"Hungarian"},{"code":"id","name":"Indonesian"},{"code":"is","name":"Icelandic"},{"code":"it","name":"Italian"},{"code":"ja","name":"Japanese"},{"code":"kk","name":"Kazakh"},{"code":"kn","name":"Kannada"},{"code":"ko","name":"Korean"},{"code":"lt","name":"Lithuanian"},{"code":"lv","name":"Latvian"},{"code":"mk","name":"Macedonian"},{"code":"ml","name":"Malayalam"},{"code":"mr","name":"Marathi"},{"code":"ms","name":"Malay"},{"code":"nl","name":"Dutch"},{"code":"no","name":"Norwegian"},{"code":"pa","name":"Punjabi"},{"code":"pl","name":"Polish"},{"code":"pt","name":"Portuguese"},{"code":"ro","name":"Romanian"},{"code":"ru","name":"Russian"},{"code":"sk","name":"Slovak"},{"code":"sl","name":"Slovenian"},{"code":"sq","name":"Albanian"},{"code":"sr","name":"Serbian"},{"code":"su","name":"Sundanese"},{"code":"sv","name":"Swedish"},{"code":"sw","name":"Swahili"},{"code":"ta","name":"Tamil"},{"code":"te","name":"Telugu"},{"code":"th","name":"Thai"},{"code":"tl","name":"Tagalog"},{"code":"tr","name":"Turkish"},{"code":"uk","name":"Ukrainian"},{"code":"ur","name":"Urdu"},{"code":"uz","name":"Uzbek"},{"code":"vi","name":"Vietnamese"},{"code":"zh","name":"Chinese"}],"name":"TTS RT v1 Preview","voices":[{"id":"Maya"},{"id":"Daniel"},{"id":"Noah"},{"id":"Nina"},{"id":"Emma"},{"id":"Jack"},{"id":"Adrian"},{"id":"Claire"},{"id":"Grace"},{"id":"Owen"},{"id":"Mina"},{"id":"Kenji"}]}]}
    /// </summary>
    public sealed partial class GetTTSModelsResponse
    {
        /// <summary>
        /// List of available TTS models and their attributes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.TTSModel> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTTSModelsResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// List of available TTS models and their attributes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTTSModelsResponse(
            global::System.Collections.Generic.IList<global::Soniox.TTSModel> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTTSModelsResponse" /> class.
        /// </summary>
        public GetTTSModelsResponse()
        {
        }
    }
}