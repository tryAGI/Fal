#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class ServerlessLogsHistoryResponseErrorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.ServerlessLogsHistoryResponseErrorType?>
    {
        /// <inheritdoc />
        public override global::Fal.ServerlessLogsHistoryResponseErrorType? Read(
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
                        return global::Fal.ServerlessLogsHistoryResponseErrorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.ServerlessLogsHistoryResponseErrorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.ServerlessLogsHistoryResponseErrorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.ServerlessLogsHistoryResponseErrorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.ServerlessLogsHistoryResponseErrorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
