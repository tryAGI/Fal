
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Character,
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        Smart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType.Character => "character",
                GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType.Manual => "manual",
                GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType? ToEnum(string value)
        {
            return value switch
            {
                "character" => GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType.Character,
                "manual" => GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType.Manual,
                "smart" => GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType.Smart,
                _ => null,
            };
        }
    }
}