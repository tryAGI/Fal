#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAssetCollectionResponseCollectionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.GetAssetCollectionResponseCollectionType>
    {
        /// <inheritdoc />
        public override global::Fal.GetAssetCollectionResponseCollectionType Read(
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
                        return global::Fal.GetAssetCollectionResponseCollectionTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.GetAssetCollectionResponseCollectionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.GetAssetCollectionResponseCollectionType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.GetAssetCollectionResponseCollectionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.GetAssetCollectionResponseCollectionTypeExtensions.ToValueString(value));
        }
    }
}
