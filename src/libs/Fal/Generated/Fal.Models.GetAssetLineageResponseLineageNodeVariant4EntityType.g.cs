
#nullable enable

namespace Fal
{
    /// <summary>
    /// Smart entity type<br/>
    /// Example: character
    /// </summary>
    public enum GetAssetLineageResponseLineageNodeVariant4EntityType
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
    public static class GetAssetLineageResponseLineageNodeVariant4EntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseLineageNodeVariant4EntityType value)
        {
            return value switch
            {
                GetAssetLineageResponseLineageNodeVariant4EntityType.Character => "character",
                GetAssetLineageResponseLineageNodeVariant4EntityType.Environment => "environment",
                GetAssetLineageResponseLineageNodeVariant4EntityType.Prop => "prop",
                GetAssetLineageResponseLineageNodeVariant4EntityType.Scene => "scene",
                GetAssetLineageResponseLineageNodeVariant4EntityType.Style => "style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseLineageNodeVariant4EntityType? ToEnum(string value)
        {
            return value switch
            {
                "character" => GetAssetLineageResponseLineageNodeVariant4EntityType.Character,
                "environment" => GetAssetLineageResponseLineageNodeVariant4EntityType.Environment,
                "prop" => GetAssetLineageResponseLineageNodeVariant4EntityType.Prop,
                "scene" => GetAssetLineageResponseLineageNodeVariant4EntityType.Scene,
                "style" => GetAssetLineageResponseLineageNodeVariant4EntityType.Style,
                _ => null,
            };
        }
    }
}