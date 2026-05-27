#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class RemoveAssetFromCollectionResponseErrorType5NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.RemoveAssetFromCollectionResponseErrorType5?>
    {
        /// <inheritdoc />
        public override global::Fal.RemoveAssetFromCollectionResponseErrorType5? Read(
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
                        return global::Fal.RemoveAssetFromCollectionResponseErrorType5Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.RemoveAssetFromCollectionResponseErrorType5)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.RemoveAssetFromCollectionResponseErrorType5?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.RemoveAssetFromCollectionResponseErrorType5? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.RemoveAssetFromCollectionResponseErrorType5Extensions.ToValueString(value.Value));
            }
        }
    }
}
