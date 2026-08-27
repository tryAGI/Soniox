#nullable enable

namespace Soniox.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetUsageLogsPayloadSortJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Soniox.GetUsageLogsPayloadSort>
    {
        /// <inheritdoc />
        public override global::Soniox.GetUsageLogsPayloadSort Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Soniox.GetUsageLogsPayloadSortExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Soniox.GetUsageLogsPayloadSort)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Soniox.GetUsageLogsPayloadSort);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Soniox.GetUsageLogsPayloadSort value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Soniox.GetUsageLogsPayloadSortExtensions.ToValueString(value));
        }
    }
}
