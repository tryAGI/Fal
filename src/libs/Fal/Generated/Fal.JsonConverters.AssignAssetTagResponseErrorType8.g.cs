#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class AssignAssetTagResponseErrorType8JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.AssignAssetTagResponseErrorType8>
    {
        /// <inheritdoc />
        public override global::Fal.AssignAssetTagResponseErrorType8 Read(
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
                        return global::Fal.AssignAssetTagResponseErrorType8Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.AssignAssetTagResponseErrorType8)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.AssignAssetTagResponseErrorType8);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.AssignAssetTagResponseErrorType8 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.AssignAssetTagResponseErrorType8Extensions.ToValueString(value));
        }
    }
}
