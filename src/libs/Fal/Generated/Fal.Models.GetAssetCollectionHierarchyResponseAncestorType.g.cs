
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum GetAssetCollectionHierarchyResponseAncestorType
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
    public static class GetAssetCollectionHierarchyResponseAncestorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionHierarchyResponseAncestorType value)
        {
            return value switch
            {
                GetAssetCollectionHierarchyResponseAncestorType.Character => "character",
                GetAssetCollectionHierarchyResponseAncestorType.Manual => "manual",
                GetAssetCollectionHierarchyResponseAncestorType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionHierarchyResponseAncestorType? ToEnum(string value)
        {
            return value switch
            {
                "character" => GetAssetCollectionHierarchyResponseAncestorType.Character,
                "manual" => GetAssetCollectionHierarchyResponseAncestorType.Manual,
                "smart" => GetAssetCollectionHierarchyResponseAncestorType.Smart,
                _ => null,
            };
        }
    }
}