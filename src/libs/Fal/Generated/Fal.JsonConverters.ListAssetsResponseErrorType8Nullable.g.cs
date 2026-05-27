#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListAssetsResponseErrorType8NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.ListAssetsResponseErrorType8?>
    {
        /// <inheritdoc />
        public override global::Fal.ListAssetsResponseErrorType8? Read(
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
                        return global::Fal.ListAssetsResponseErrorType8Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.ListAssetsResponseErrorType8)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.ListAssetsResponseErrorType8?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.ListAssetsResponseErrorType8? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.ListAssetsResponseErrorType8Extensions.ToValueString(value.Value));
            }
        }
    }
}
