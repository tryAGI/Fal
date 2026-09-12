
#nullable enable

namespace Fal
{
    /// <summary>
    /// Smart entity type<br/>
    /// Example: character
    /// </summary>
    public enum UpdateAssetEntityResponseEntityType
    {
        /// <summary>
        ///
        /// </summary>
        Character,
        /// <summary>
        ///
        /// </summary>
        Environment,
        /// <summary>
        ///
        /// </summary>
        Prop,
        /// <summary>
        ///
        /// </summary>
        Scene,
        /// <summary>
        ///
        /// </summary>
        Style,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAssetEntityResponseEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetEntityResponseEntityType value)
        {
            return value switch
            {
                UpdateAssetEntityResponseEntityType.Character => "character",
                UpdateAssetEntityResponseEntityType.Environment => "environment",
                UpdateAssetEntityResponseEntityType.Prop => "prop",
                UpdateAssetEntityResponseEntityType.Scene => "scene",
                UpdateAssetEntityResponseEntityType.Style => "style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetEntityResponseEntityType? ToEnum(string value)
        {
            return value switch
            {
                "character" => UpdateAssetEntityResponseEntityType.Character,
                "environment" => UpdateAssetEntityResponseEntityType.Environment,
                "prop" => UpdateAssetEntityResponseEntityType.Prop,
                "scene" => UpdateAssetEntityResponseEntityType.Scene,
                "style" => UpdateAssetEntityResponseEntityType.Style,
                _ => null,
            };
        }
    }
}