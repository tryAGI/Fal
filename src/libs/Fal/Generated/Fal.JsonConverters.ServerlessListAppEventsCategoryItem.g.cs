#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class ServerlessListAppEventsCategoryItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.ServerlessListAppEventsCategoryItem>
    {
        /// <inheritdoc />
        public override global::Fal.ServerlessListAppEventsCategoryItem Read(
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
                        return global::Fal.ServerlessListAppEventsCategoryItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.ServerlessListAppEventsCategoryItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.ServerlessListAppEventsCategoryItem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.ServerlessListAppEventsCategoryItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.ServerlessListAppEventsCategoryItemExtensions.ToValueString(value));
        }
    }
}
