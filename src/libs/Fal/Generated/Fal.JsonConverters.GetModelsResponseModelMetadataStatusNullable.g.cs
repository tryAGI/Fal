#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetModelsResponseModelMetadataStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.GetModelsResponseModelMetadataStatus?>
    {
        /// <inheritdoc />
        public override global::Fal.GetModelsResponseModelMetadataStatus? Read(
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
                        return global::Fal.GetModelsResponseModelMetadataStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.GetModelsResponseModelMetadataStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.GetModelsResponseModelMetadataStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.GetModelsResponseModelMetadataStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.GetModelsResponseModelMetadataStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
