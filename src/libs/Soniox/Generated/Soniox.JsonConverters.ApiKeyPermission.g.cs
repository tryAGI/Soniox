#nullable enable

namespace Soniox.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiKeyPermissionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Soniox.ApiKeyPermission>
    {
        /// <inheritdoc />
        public override global::Soniox.ApiKeyPermission Read(
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
                        return global::Soniox.ApiKeyPermissionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Soniox.ApiKeyPermission)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Soniox.ApiKeyPermission);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Soniox.ApiKeyPermission value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Soniox.ApiKeyPermissionExtensions.ToValueString(value));
        }
    }
}
