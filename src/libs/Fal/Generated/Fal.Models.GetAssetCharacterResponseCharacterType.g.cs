
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum GetAssetCharacterResponseCharacterType
    {
        /// <summary>
        /// 
        /// </summary>
        Character,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAssetCharacterResponseCharacterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCharacterResponseCharacterType value)
        {
            return value switch
            {
                GetAssetCharacterResponseCharacterType.Character => "character",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCharacterResponseCharacterType? ToEnum(string value)
        {
            return value switch
            {
                "character" => GetAssetCharacterResponseCharacterType.Character,
                _ => null,
            };
        }
    }
}