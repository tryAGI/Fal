#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType>
    {
        /// <inheritdoc />
        public override global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType Read(
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
                        return global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemTypeExtensions.ToValueString(value));
        }
    }
}
