
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum GetAssetCollectionResponseCollectionType
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
    public static class GetAssetCollectionResponseCollectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCollectionResponseCollectionType value)
        {
            return value switch
            {
                GetAssetCollectionResponseCollectionType.Character => "character",
                GetAssetCollectionResponseCollectionType.Manual => "manual",
                GetAssetCollectionResponseCollectionType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCollectionResponseCollectionType? ToEnum(string value)
        {
            return value switch
            {
                "character" => GetAssetCollectionResponseCollectionType.Character,
                "manual" => GetAssetCollectionResponseCollectionType.Manual,
                "smart" => GetAssetCollectionResponseCollectionType.Smart,
                _ => null,
            };
        }
    }
}