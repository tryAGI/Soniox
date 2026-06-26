#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Soniox.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Soniox.Realtime.ServerEvent>
    {
        /// <inheritdoc />
        public override global::Soniox.Realtime.ServerEvent Read(
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

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("final_audio_proc_ms")) __score0++;
            if (__jsonProps.Contains("finished")) __score0++;
            if (__jsonProps.Contains("tokens")) __score0++;
            if (__jsonProps.Contains("total_audio_proc_ms")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("error_code")) __score1++;
            if (__jsonProps.Contains("error_message")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Soniox.Realtime.RealtimeResult? realtimeResult = default;
            global::Soniox.Realtime.RealtimeError? realtimeError = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.RealtimeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.RealtimeResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.RealtimeResult).Name}");
                        realtimeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.RealtimeError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.RealtimeError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.RealtimeError).Name}");
                        realtimeError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (realtimeResult == null && realtimeError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.RealtimeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.RealtimeResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.RealtimeResult).Name}");
                    realtimeResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (realtimeResult == null && realtimeError == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.RealtimeError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.RealtimeError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.RealtimeError).Name}");
                    realtimeError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Soniox.Realtime.ServerEvent(
                realtimeResult,

                realtimeError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Soniox.Realtime.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRealtimeResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.RealtimeResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.RealtimeResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.RealtimeResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimeResult!, typeInfo);
            }
            else if (value.IsRealtimeError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Soniox.Realtime.RealtimeError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Soniox.Realtime.RealtimeError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Soniox.Realtime.RealtimeError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RealtimeError!, typeInfo);
            }
        }
    }
}