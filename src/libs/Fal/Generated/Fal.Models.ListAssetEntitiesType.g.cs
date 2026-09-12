
#nullable enable

namespace Fal
{
    /// <summary>
    /// Smart entity type<br/>
    /// Example: character
    /// </summary>
    public enum ListAssetEntitiesType
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
    public static class ListAssetEntitiesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetEntitiesType value)
        {
            return value switch
            {
                ListAssetEntitiesType.Character => "character",
                ListAssetEntitiesType.Environment => "environment",
                ListAssetEntitiesType.Prop => "prop",
                ListAssetEntitiesType.Scene => "scene",
                ListAssetEntitiesType.Style => "style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetEntitiesType? ToEnum(string value)
        {
            return value switch
            {
                "character" => ListAssetEntitiesType.Character,
                "environment" => ListAssetEntitiesType.Environment,
                "prop" => ListAssetEntitiesType.Prop,
                "scene" => ListAssetEntitiesType.Scene,
                "style" => ListAssetEntitiesType.Style,
                _ => null,
            };
        }
    }
}