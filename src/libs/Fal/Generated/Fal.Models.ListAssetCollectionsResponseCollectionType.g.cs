
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum ListAssetCollectionsResponseCollectionType
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
    public static class ListAssetCollectionsResponseCollectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionsResponseCollectionType value)
        {
            return value switch
            {
                ListAssetCollectionsResponseCollectionType.Character => "character",
                ListAssetCollectionsResponseCollectionType.Manual => "manual",
                ListAssetCollectionsResponseCollectionType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionsResponseCollectionType? ToEnum(string value)
        {
            return value switch
            {
                "character" => ListAssetCollectionsResponseCollectionType.Character,
                "manual" => ListAssetCollectionsResponseCollectionType.Manual,
                "smart" => ListAssetCollectionsResponseCollectionType.Smart,
                _ => null,
            };
        }
    }
}