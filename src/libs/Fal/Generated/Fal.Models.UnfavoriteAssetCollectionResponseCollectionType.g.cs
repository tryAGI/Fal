
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum UnfavoriteAssetCollectionResponseCollectionType
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
    public static class UnfavoriteAssetCollectionResponseCollectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCollectionResponseCollectionType value)
        {
            return value switch
            {
                UnfavoriteAssetCollectionResponseCollectionType.Character => "character",
                UnfavoriteAssetCollectionResponseCollectionType.Manual => "manual",
                UnfavoriteAssetCollectionResponseCollectionType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCollectionResponseCollectionType? ToEnum(string value)
        {
            return value switch
            {
                "character" => UnfavoriteAssetCollectionResponseCollectionType.Character,
                "manual" => UnfavoriteAssetCollectionResponseCollectionType.Manual,
                "smart" => UnfavoriteAssetCollectionResponseCollectionType.Smart,
                _ => null,
            };
        }
    }
}