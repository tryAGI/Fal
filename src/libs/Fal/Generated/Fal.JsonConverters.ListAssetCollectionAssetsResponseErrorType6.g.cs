#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListAssetCollectionAssetsResponseErrorType6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.ListAssetCollectionAssetsResponseErrorType6>
    {
        /// <inheritdoc />
        public override global::Fal.ListAssetCollectionAssetsResponseErrorType6 Read(
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
                        return global::Fal.ListAssetCollectionAssetsResponseErrorType6Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.ListAssetCollectionAssetsResponseErrorType6)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.ListAssetCollectionAssetsResponseErrorType6);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.ListAssetCollectionAssetsResponseErrorType6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.ListAssetCollectionAssetsResponseErrorType6Extensions.ToValueString(value));
        }
    }
}
