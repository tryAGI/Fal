
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum UnfavoriteAssetCharacterResponseCharacterType
    {
        /// <summary>
        /// 
        /// </summary>
        Character,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnfavoriteAssetCharacterResponseCharacterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnfavoriteAssetCharacterResponseCharacterType value)
        {
            return value switch
            {
                UnfavoriteAssetCharacterResponseCharacterType.Character => "character",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnfavoriteAssetCharacterResponseCharacterType? ToEnum(string value)
        {
            return value switch
            {
                "character" => UnfavoriteAssetCharacterResponseCharacterType.Character,
                _ => null,
            };
        }
    }
}