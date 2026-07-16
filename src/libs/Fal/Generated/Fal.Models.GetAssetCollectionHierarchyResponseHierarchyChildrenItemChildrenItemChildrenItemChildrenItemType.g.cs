
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType
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
    public static class GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType.Character => "character",
                GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType.Manual => "manual",
                GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType? ToEnum(string value)
        {
            return value switch
            {
                "character" => GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType.Character,
                "manual" => GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType.Manual,
                "smart" => GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType.Smart,
                _ => null,
            };
        }
    }
}