#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListRequestsByEndpointResponseErrorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.ListRequestsByEndpointResponseErrorType>
    {
        /// <inheritdoc />
        public override global::Fal.ListRequestsByEndpointResponseErrorType Read(
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
                        return global::Fal.ListRequestsByEndpointResponseErrorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.ListRequestsByEndpointResponseErrorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.ListRequestsByEndpointResponseErrorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.ListRequestsByEndpointResponseErrorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.ListRequestsByEndpointResponseErrorTypeExtensions.ToValueString(value));
        }
    }
}
