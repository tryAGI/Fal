
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType
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
    public static class GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType.Character => "character",
                GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType.Manual => "manual",
                GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType? ToEnum(string value)
        {
            return value switch
            {
                "character" => GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType.Character,
                "manual" => GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType.Manual,
                "smart" => GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType.Smart,
                _ => null,
            };
        }
    }
}