
#nullable enable

namespace Fal
{
    /// <summary>
    /// Smart entity type<br/>
    /// Example: character
    /// </summary>
    public enum GetAssetLineageResponseLineageEdgeEntitieEntityType
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
    public static class GetAssetLineageResponseLineageEdgeEntitieEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseLineageEdgeEntitieEntityType value)
        {
            return value switch
            {
                GetAssetLineageResponseLineageEdgeEntitieEntityType.Character => "character",
                GetAssetLineageResponseLineageEdgeEntitieEntityType.Environment => "environment",
                GetAssetLineageResponseLineageEdgeEntitieEntityType.Prop => "prop",
                GetAssetLineageResponseLineageEdgeEntitieEntityType.Scene => "scene",
                GetAssetLineageResponseLineageEdgeEntitieEntityType.Style => "style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseLineageEdgeEntitieEntityType? ToEnum(string value)
        {
            return value switch
            {
                "character" => GetAssetLineageResponseLineageEdgeEntitieEntityType.Character,
                "environment" => GetAssetLineageResponseLineageEdgeEntitieEntityType.Environment,
                "prop" => GetAssetLineageResponseLineageEdgeEntitieEntityType.Prop,
                "scene" => GetAssetLineageResponseLineageEdgeEntitieEntityType.Scene,
                "style" => GetAssetLineageResponseLineageEdgeEntitieEntityType.Style,
                _ => null,
            };
        }
    }
}