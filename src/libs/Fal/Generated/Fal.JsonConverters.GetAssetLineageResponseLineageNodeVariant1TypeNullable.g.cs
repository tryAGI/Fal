#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAssetLineageResponseLineageNodeVariant1TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.GetAssetLineageResponseLineageNodeVariant1Type?>
    {
        /// <inheritdoc />
        public override global::Fal.GetAssetLineageResponseLineageNodeVariant1Type? Read(
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
                        return global::Fal.GetAssetLineageResponseLineageNodeVariant1TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.GetAssetLineageResponseLineageNodeVariant1Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.GetAssetLineageResponseLineageNodeVariant1Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.GetAssetLineageResponseLineageNodeVariant1Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.GetAssetLineageResponseLineageNodeVariant1TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
