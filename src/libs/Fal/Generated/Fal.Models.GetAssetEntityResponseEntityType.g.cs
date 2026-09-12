
#nullable enable

namespace Fal
{
    /// <summary>
    /// Smart entity type<br/>
    /// Example: character
    /// </summary>
    public enum GetAssetEntityResponseEntityType
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
    public static class GetAssetEntityResponseEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetEntityResponseEntityType value)
        {
            return value switch
            {
                GetAssetEntityResponseEntityType.Character => "character",
                GetAssetEntityResponseEntityType.Environment => "environment",
                GetAssetEntityResponseEntityType.Prop => "prop",
                GetAssetEntityResponseEntityType.Scene => "scene",
                GetAssetEntityResponseEntityType.Style => "style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetEntityResponseEntityType? ToEnum(string value)
        {
            return value switch
            {
                "character" => GetAssetEntityResponseEntityType.Character,
                "environment" => GetAssetEntityResponseEntityType.Environment,
                "prop" => GetAssetEntityResponseEntityType.Prop,
                "scene" => GetAssetEntityResponseEntityType.Scene,
                "style" => GetAssetEntityResponseEntityType.Style,
                _ => null,
            };
        }
    }
}