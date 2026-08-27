
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Soniox.Realtime.Tts
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Soniox.Realtime.Tts.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.Tts.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.Tts.TtsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.Tts.TtsText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.Tts.TtsCancel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.Tts.TtsKeepAlive))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.Tts.TtsAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.Tts.TtsTimestamps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.Tts.TtsTerminated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.Tts.TtsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Soniox.Realtime.Tts.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    public sealed partial class TtsRealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}