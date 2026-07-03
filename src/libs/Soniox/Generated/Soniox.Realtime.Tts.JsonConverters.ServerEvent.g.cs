#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Soniox.Realtime.Tts.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Soniox.Realtime.Tts.ServerEvent>
    {
        /// <inheritdoc />
        public override global::Soniox.Realtime.Tts.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("audio")) __score0++;
            if (__jsonProps.Contains("audio_end")) __score0++;
            if (__jsonProps.Contains("stream_id")) __score0++;
            if (__jsonProps.Contains("timestamps")) __score0++;
            if (__jsonProps.Contains("timestamps.character_end_times_seconds")) __score0++;
            if (__jsonProps.Contains("timestamps.character_start_times_seconds")) __score0++;
            if (__jsonProps.Contains("timestamps.characters")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("stream_id")) __score1++;
            if (__jsonProps.Contains("terminated")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("error_code")) __score2++;
            if (__jsonProps.Contains("error_message")) __score2++;
            if (__jsonProps.Contains("error_type")) __score2++;
            if (__jsonProps.Contains("more_info")) __score2++;
            if (__jsonProps.Contains("request_id")) __score2++;
            if (__jsonProps.Contains("stream_id")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Soniox.Realtime.Tts.TtsAudio? ttsAudio = default;
            global::Soniox.Realtime.Tts.TtsTerminated? ttsTerminated = default;
            global::Soniox.Realtime.Tts.TtsError? ttsError = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.Tts.TtsAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.Tts.TtsAudio> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.Tts.TtsAudio).Name}");
                        ttsAudio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.Tts.TtsTerminated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.Tts.TtsTerminated> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.Tts.TtsTerminated).Name}");
                        ttsTerminated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.Tts.TtsError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.Tts.TtsError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.Tts.TtsError).Name}");
                        ttsError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (ttsAudio == null && ttsTerminated == null && ttsError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.Tts.TtsAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.Tts.TtsAudio> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.Tts.TtsAudio).Name}");
                    ttsAudio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (ttsAudio == null && ttsTerminated == null && ttsError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.Tts.TtsTerminated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.Tts.TtsTerminated> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.Tts.TtsTerminated).Name}");
                    ttsTerminated = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (ttsAudio == null && ttsTerminated == null && ttsError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.Tts.TtsError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.Tts.TtsError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.Tts.TtsError).Name}");
                    ttsError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Soniox.Realtime.Tts.ServerEvent(
                ttsAudio,

                ttsTerminated,

                ttsError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Soniox.Realtime.Tts.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTtsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.Tts.TtsAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.Tts.TtsAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.Tts.TtsAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TtsAudio!, typeInfo);
            }
            else if (value.IsTtsTerminated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.Tts.TtsTerminated), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.Tts.TtsTerminated?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.Tts.TtsTerminated).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TtsTerminated!, typeInfo);
            }
            else if (value.IsTtsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.Tts.TtsError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.Tts.TtsError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.Tts.TtsError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TtsError!, typeInfo);
            }
        }
    }
}