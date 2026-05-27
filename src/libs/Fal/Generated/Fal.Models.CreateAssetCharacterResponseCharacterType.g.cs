
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum CreateAssetCharacterResponseCharacterType
    {
        /// <summary>
        /// 
        /// </summary>
        Character,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssetCharacterResponseCharacterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCharacterResponseCharacterType value)
        {
            return value switch
            {
                CreateAssetCharacterResponseCharacterType.Character => "character",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCharacterResponseCharacterType? ToEnum(string value)
        {
            return value switch
            {
                "character" => CreateAssetCharacterResponseCharacterType.Character,
                _ => null,
            };
        }
    }
}