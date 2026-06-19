
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

            typeof(global::Soniox.JsonConverters.VoiceModelStatusJsonConverter),

            typeof(global::Soniox.JsonConverters.VoiceModelStatusNullableJsonConverter),

            typeof(global::Soniox.JsonConverters.TranscriptionModeJsonConverter),

            typeof(global::Soniox.JsonConverters.TranscriptionModeNullableJsonConverter),

            typeof(global::Soniox.JsonConverters.TTSVoiceGenderJsonConverter),

            typeof(global::Soniox.JsonConverters.TTSVoiceGenderNullableJsonConverter),

            typeof(global::Soniox.JsonConverters.GetUsageLogsPayloadSortJsonConverter),

            typeof(global::Soniox.JsonConverters.GetUsageLogsPayloadSortNullableJsonConverter),

            typeof(global::Soniox.JsonConverters.UsageLogsSortJsonConverter),

            typeof(global::Soniox.JsonConverters.UsageLogsSortNullableJsonConverter),

            typeof(global::Soniox.JsonConverters.TemporaryApiKeyUsageTypeJsonConverter),

            typeof(global::Soniox.JsonConverters.TemporaryApiKeyUsageTypeNullableJsonConverter),

            typeof(global::Soniox.JsonConverters.GetUsageLogsSort2JsonConverter),

            typeof(global::Soniox.JsonConverters.GetUsageLogsSort2NullableJsonConverter),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetVoicesPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.VoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.VoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.VoiceModelStatus), TypeInfoPropertyName = "VoiceModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.UploadVoicePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetVoicesCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.RecomputeVoicePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Language))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TranscriptionMode), TypeInfoPropertyName = "TranscriptionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.Language>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.TranslationTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TranslationTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetTTSModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.TTSModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TTSModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.TTSVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TTSVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TTSVoiceGender), TypeInfoPropertyName = "TTSVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetUsageLogsPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetUsageLogsPayloadSort), TypeInfoPropertyName = "GetUsageLogsPayloadSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.UsageLogsSort), TypeInfoPropertyName = "UsageLogsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetUsageLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.UsageLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.UsageLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.CreateTemporaryApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.CreateTemporaryApiKeyPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.TemporaryApiKeyUsageType), TypeInfoPropertyName = "TemporaryApiKeyUsageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.CurrentValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetConcurrencyLimitsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.ScopeValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.LimitValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.UploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.CreateVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.GetUsageLogsSort2), TypeInfoPropertyName = "GetUsageLogsSort22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.ApiErrorValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.Transcription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.StructuredContextGeneralItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.StructuredContextTranslationTerm>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.TranscriptionTranscriptToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.VoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.Language>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.TranslationTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.TTSModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.TTSVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.UsageLogEntry>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}