#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateAssetPromptResponseErrorType8NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.UpdateAssetPromptResponseErrorType8?>
    {
        /// <inheritdoc />
        public override global::Fal.UpdateAssetPromptResponseErrorType8? Read(
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
                        return global::Fal.UpdateAssetPromptResponseErrorType8Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.UpdateAssetPromptResponseErrorType8)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.UpdateAssetPromptResponseErrorType8?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.UpdateAssetPromptResponseErrorType8? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.UpdateAssetPromptResponseErrorType8Extensions.ToValueString(value.Value));
            }
        }
    }
}
