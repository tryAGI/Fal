#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateAssetCharacterResponseCharacterTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.CreateAssetCharacterResponseCharacterType?>
    {
        /// <inheritdoc />
        public override global::Fal.CreateAssetCharacterResponseCharacterType? Read(
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
                        return global::Fal.CreateAssetCharacterResponseCharacterTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.CreateAssetCharacterResponseCharacterType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.CreateAssetCharacterResponseCharacterType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.CreateAssetCharacterResponseCharacterType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.CreateAssetCharacterResponseCharacterTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
