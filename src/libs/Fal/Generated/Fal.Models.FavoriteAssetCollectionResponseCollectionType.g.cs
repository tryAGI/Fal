
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum FavoriteAssetCollectionResponseCollectionType
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
    public static class FavoriteAssetCollectionResponseCollectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCollectionResponseCollectionType value)
        {
            return value switch
            {
                FavoriteAssetCollectionResponseCollectionType.Character => "character",
                FavoriteAssetCollectionResponseCollectionType.Manual => "manual",
                FavoriteAssetCollectionResponseCollectionType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCollectionResponseCollectionType? ToEnum(string value)
        {
            return value switch
            {
                "character" => FavoriteAssetCollectionResponseCollectionType.Character,
                "manual" => FavoriteAssetCollectionResponseCollectionType.Manual,
                "smart" => FavoriteAssetCollectionResponseCollectionType.Smart,
                _ => null,
            };
        }
    }
}