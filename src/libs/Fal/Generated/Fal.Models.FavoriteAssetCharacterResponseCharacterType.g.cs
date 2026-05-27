
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum FavoriteAssetCharacterResponseCharacterType
    {
        /// <summary>
        /// 
        /// </summary>
        Character,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FavoriteAssetCharacterResponseCharacterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FavoriteAssetCharacterResponseCharacterType value)
        {
            return value switch
            {
                FavoriteAssetCharacterResponseCharacterType.Character => "character",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FavoriteAssetCharacterResponseCharacterType? ToEnum(string value)
        {
            return value switch
            {
                "character" => FavoriteAssetCharacterResponseCharacterType.Character,
                _ => null,
            };
        }
    }
}