
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum ListAssetCharactersResponseCharacterType
    {
        /// <summary>
        /// 
        /// </summary>
        Character,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAssetCharactersResponseCharacterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCharactersResponseCharacterType value)
        {
            return value switch
            {
                ListAssetCharactersResponseCharacterType.Character => "character",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCharactersResponseCharacterType? ToEnum(string value)
        {
            return value switch
            {
                "character" => ListAssetCharactersResponseCharacterType.Character,
                _ => null,
            };
        }
    }
}