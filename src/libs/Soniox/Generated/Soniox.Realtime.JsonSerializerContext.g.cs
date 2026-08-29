
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Soniox.Realtime
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Soniox.Realtime.JsonConverters.TranslationConfigTypeJsonConverter),

            typeof(global::Soniox.Realtime.JsonConverters.TranslationConfigTypeNullableJsonConverter),

            typeof(global::Soniox.Realtime.JsonConverters.ServerEventJsonConverter),

            typeof(global::Soniox.Realtime.JsonConverters.OneOfJsonConverter<string, object>),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.RealtimeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.TranslationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.TranslationConfigType), TypeInfoPropertyName = "TranslationConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.RealtimeToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.RealtimeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Soniox.Realtime.RealtimeToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.RealtimeError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Soniox.Realtime.RealtimeToken>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}