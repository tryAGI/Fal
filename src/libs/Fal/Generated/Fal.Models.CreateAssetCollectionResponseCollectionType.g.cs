
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum CreateAssetCollectionResponseCollectionType
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
    public static class CreateAssetCollectionResponseCollectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCollectionResponseCollectionType value)
        {
            return value switch
            {
                CreateAssetCollectionResponseCollectionType.Character => "character",
                CreateAssetCollectionResponseCollectionType.Manual => "manual",
                CreateAssetCollectionResponseCollectionType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCollectionResponseCollectionType? ToEnum(string value)
        {
            return value switch
            {
                "character" => CreateAssetCollectionResponseCollectionType.Character,
                "manual" => CreateAssetCollectionResponseCollectionType.Manual,
                "smart" => CreateAssetCollectionResponseCollectionType.Smart,
                _ => null,
            };
        }
    }
}