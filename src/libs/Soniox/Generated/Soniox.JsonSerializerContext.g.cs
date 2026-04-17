
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Soniox
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Soniox.JsonConverters.TranscriptionStatusJsonConverter),

            typeof(global::Soniox.JsonConverters.TranscriptionStatusNullableJsonConverter),

            typeof(global::Soniox.JsonConverters.TranslationConfigTypeJsonConverter),

            typeof(global::Soniox.JsonConverters.TranslationConfigTypeNullableJsonConverter),

            typeof(global::Soniox.JsonConverters.TranscriptionModeJsonConverter),

            typeof(global::Soniox.JsonConverters.TranscriptionModeNullableJsonConverter),

            typeof(global::Soniox.JsonConverters.TemporaryApiKeyUsageTypeJsonConverter),

            typeof(global::Soniox.JsonConverters.TemporaryApiKeyUsageTypeNullableJsonConverter),

            typeof(global::Soniox.JsonConverters.AnyOfJsonConverter<global::Soniox.StructuredContext, string, object>),

            typeof(global::Soniox.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetFilesPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.ApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.ApiErrorValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.ApiErrorValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.UploadFilePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetFilesCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetTranscriptionsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetTranscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.Transcription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Transcription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TranscriptionStatus), TypeInfoPropertyName = "TranscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.CreateTranscriptionPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TranslationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.AnyOf<global::Soniox.StructuredContext, string, object>), TypeInfoPropertyName = "AnyOfStructuredContextStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.StructuredContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.StructuredContextGeneralItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.StructuredContextGeneralItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.StructuredContextTranslationTerm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.StructuredContextTranslationTerm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TranslationConfigType), TypeInfoPropertyName = "TranslationConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetTranscriptionsCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TranscriptionTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.TranscriptionTranscriptToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TranscriptionTranscriptToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Language))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TranscriptionMode), TypeInfoPropertyName = "TranscriptionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.Language>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.TranslationTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TranslationTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.CreateTemporaryApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.CreateTemporaryApiKeyPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TemporaryApiKeyUsageType), TypeInfoPropertyName = "TemporaryApiKeyUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.UploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.ApiErrorValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.Transcription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.StructuredContextGeneralItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.StructuredContextTranslationTerm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.TranscriptionTranscriptToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.Language>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.TranslationTarget>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}