
#nullable enable

namespace Fal
{
    /// <summary>
    /// Collection type
    /// </summary>
    public enum MoveAssetCollectionResponseCollectionType
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
    public static class MoveAssetCollectionResponseCollectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveAssetCollectionResponseCollectionType value)
        {
            return value switch
            {
                MoveAssetCollectionResponseCollectionType.Character => "character",
                MoveAssetCollectionResponseCollectionType.Manual => "manual",
                MoveAssetCollectionResponseCollectionType.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveAssetCollectionResponseCollectionType? ToEnum(string value)
        {
            return value switch
            {
                "character" => MoveAssetCollectionResponseCollectionType.Character,
                "manual" => MoveAssetCollectionResponseCollectionType.Manual,
                "smart" => MoveAssetCollectionResponseCollectionType.Smart,
                _ => null,
            };
        }
    }
}