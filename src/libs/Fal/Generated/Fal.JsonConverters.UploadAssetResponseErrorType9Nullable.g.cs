#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class UploadAssetResponseErrorType9NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.UploadAssetResponseErrorType9?>
    {
        /// <inheritdoc />
        public override global::Fal.UploadAssetResponseErrorType9? Read(
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
                        return global::Fal.UploadAssetResponseErrorType9Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.UploadAssetResponseErrorType9)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.UploadAssetResponseErrorType9?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.UploadAssetResponseErrorType9? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.UploadAssetResponseErrorType9Extensions.ToValueString(value.Value));
            }
        }
    }
}
