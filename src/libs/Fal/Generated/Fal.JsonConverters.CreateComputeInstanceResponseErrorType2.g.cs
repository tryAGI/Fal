#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateComputeInstanceResponseErrorType2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.CreateComputeInstanceResponseErrorType2>
    {
        /// <inheritdoc />
        public override global::Fal.CreateComputeInstanceResponseErrorType2 Read(
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
                        return global::Fal.CreateComputeInstanceResponseErrorType2Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.CreateComputeInstanceResponseErrorType2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.CreateComputeInstanceResponseErrorType2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.CreateComputeInstanceResponseErrorType2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.CreateComputeInstanceResponseErrorType2Extensions.ToValueString(value));
        }
    }
}
