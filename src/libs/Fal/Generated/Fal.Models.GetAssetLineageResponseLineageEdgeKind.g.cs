
#nullable enable

namespace Fal
{
    /// <summary>
    /// How one lineage node relates to another
    /// </summary>
    public enum GetAssetLineageResponseLineageEdgeKind
    {
        /// <summary>
        /// 
        /// </summary>
        GeneratedBy,
        /// <summary>
        /// 
        /// </summary>
        InputTo,
        /// <summary>
        /// 
        /// </summary>
        ReferencedEntity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAssetLineageResponseLineageEdgeKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseLineageEdgeKind value)
        {
            return value switch
            {
                GetAssetLineageResponseLineageEdgeKind.GeneratedBy => "generated_by",
                GetAssetLineageResponseLineageEdgeKind.InputTo => "input_to",
                GetAssetLineageResponseLineageEdgeKind.ReferencedEntity => "referenced_entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseLineageEdgeKind? ToEnum(string value)
        {
            return value switch
            {
                "generated_by" => GetAssetLineageResponseLineageEdgeKind.GeneratedBy,
                "input_to" => GetAssetLineageResponseLineageEdgeKind.InputTo,
                "referenced_entity" => GetAssetLineageResponseLineageEdgeKind.ReferencedEntity,
                _ => null,
            };
        }
    }
}