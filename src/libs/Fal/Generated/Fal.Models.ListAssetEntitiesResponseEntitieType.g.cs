
#nullable enable

namespace Fal
{
    /// <summary>
    /// Smart entity type<br/>
    /// Example: character
    /// </summary>
    public enum ListAssetEntitiesResponseEntitieType
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
    public static class ListAssetEntitiesResponseEntitieTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetEntitiesResponseEntitieType value)
        {
            return value switch
            {
                ListAssetEntitiesResponseEntitieType.Character => "character",
                ListAssetEntitiesResponseEntitieType.Environment => "environment",
                ListAssetEntitiesResponseEntitieType.Prop => "prop",
                ListAssetEntitiesResponseEntitieType.Scene => "scene",
                ListAssetEntitiesResponseEntitieType.Style => "style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetEntitiesResponseEntitieType? ToEnum(string value)
        {
            return value switch
            {
                "character" => ListAssetEntitiesResponseEntitieType.Character,
                "environment" => ListAssetEntitiesResponseEntitieType.Environment,
                "prop" => ListAssetEntitiesResponseEntitieType.Prop,
                "scene" => ListAssetEntitiesResponseEntitieType.Scene,
                "style" => ListAssetEntitiesResponseEntitieType.Style,
                _ => null,
            };
        }
    }
}