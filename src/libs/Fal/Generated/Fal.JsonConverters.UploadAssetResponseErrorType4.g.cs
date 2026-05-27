#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class UploadAssetResponseErrorType4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.UploadAssetResponseErrorType4>
    {
        /// <inheritdoc />
        public override global::Fal.UploadAssetResponseErrorType4 Read(
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
                        return global::Fal.UploadAssetResponseErrorType4Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.UploadAssetResponseErrorType4)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.UploadAssetResponseErrorType4);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.UploadAssetResponseErrorType4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.UploadAssetResponseErrorType4Extensions.ToValueString(value));
        }
    }
}
