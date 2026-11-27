#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class EstimatePricingResponseVariant1ItemPerRequestConfidenceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence?>
    {
        /// <inheritdoc />
        public override global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence? Read(
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
                        return global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidenceExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidenceExtensions.ToValueString(value.Value));
            }
        }
    }
}
