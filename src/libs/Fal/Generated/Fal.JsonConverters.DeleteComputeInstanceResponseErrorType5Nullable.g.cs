#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteComputeInstanceResponseErrorType5NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.DeleteComputeInstanceResponseErrorType5?>
    {
        /// <inheritdoc />
        public override global::Fal.DeleteComputeInstanceResponseErrorType5? Read(
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
                        return global::Fal.DeleteComputeInstanceResponseErrorType5Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.DeleteComputeInstanceResponseErrorType5)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.DeleteComputeInstanceResponseErrorType5?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.DeleteComputeInstanceResponseErrorType5? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.DeleteComputeInstanceResponseErrorType5Extensions.ToValueString(value.Value));
            }
        }
    }
}
