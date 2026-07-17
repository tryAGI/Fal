
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
                _ => null,
            };
        }
    }
}