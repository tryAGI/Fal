
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum UpdateAssetCollectionResponseCollectionType
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
    public static class UpdateAssetCollectionResponseCollectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCollectionResponseCollectionType value)
        {
            return value switch
            {
                UpdateAssetCollectionResponseCollectionType.Character => "character",
                UpdateAssetCollectionResponseCollectionType.Manual => "manual",
                UpdateAssetCollectionResponseCollectionType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCollectionResponseCollectionType? ToEnum(string value)
        {
            return value switch
            {
                "character" => UpdateAssetCollectionResponseCollectionType.Character,
                "manual" => UpdateAssetCollectionResponseCollectionType.Manual,
                "smart" => UpdateAssetCollectionResponseCollectionType.Smart,
                _ => null,
            };
        }
    }
}