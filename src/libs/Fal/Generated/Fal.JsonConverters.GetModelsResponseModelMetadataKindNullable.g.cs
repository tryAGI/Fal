#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetModelsResponseModelMetadataKindNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.GetModelsResponseModelMetadataKind?>
    {
        /// <inheritdoc />
        public override global::Fal.GetModelsResponseModelMetadataKind? Read(
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
                        return global::Fal.GetModelsResponseModelMetadataKindExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.GetModelsResponseModelMetadataKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.GetModelsResponseModelMetadataKind?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.GetModelsResponseModelMetadataKind? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.GetModelsResponseModelMetadataKindExtensions.ToValueString(value.Value));
            }
        }
    }
}
