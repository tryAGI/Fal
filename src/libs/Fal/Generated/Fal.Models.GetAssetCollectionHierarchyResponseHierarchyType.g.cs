
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseHierarchyType
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
    public static class GetAssetCollectionHierarchyResponseHierarchyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseHierarchyType value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseHierarchyType.Character => "character",
                GetAssetCollectionHierarchyResponseHierarchyType.Manual => "manual",
                GetAssetCollectionHierarchyResponseHierarchyType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseHierarchyType? ToEnum(string value)
        {
            return value switch
            {
                "character" => GetAssetCollectionHierarchyResponseHierarchyType.Character,
                "manual" => GetAssetCollectionHierarchyResponseHierarchyType.Manual,
                "smart" => GetAssetCollectionHierarchyResponseHierarchyType.Smart,
                _ => null,
            };
        }
    }
}