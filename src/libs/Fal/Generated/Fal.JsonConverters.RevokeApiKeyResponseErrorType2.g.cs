#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class RevokeApiKeyResponseErrorType2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.RevokeApiKeyResponseErrorType2>
    {
        /// <inheritdoc />
        public override global::Fal.RevokeApiKeyResponseErrorType2 Read(
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
                        return global::Fal.RevokeApiKeyResponseErrorType2Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.RevokeApiKeyResponseErrorType2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.RevokeApiKeyResponseErrorType2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.RevokeApiKeyResponseErrorType2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.RevokeApiKeyResponseErrorType2Extensions.ToValueString(value));
        }
    }
}
