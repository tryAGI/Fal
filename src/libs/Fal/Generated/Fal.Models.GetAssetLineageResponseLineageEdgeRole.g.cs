
#nullable enable

namespace Fal
{
    /// <summary>
    /// How an input was used by the consuming generation
    /// </summary>
    public enum GetAssetLineageResponseLineageEdgeRole
    {
        /// <summary>
        /// 
        /// </summary>
        ContentRef,
        /// <summary>
        /// 
        /// </summary>
        Control,
        /// <summary>
        /// 
        /// </summary>
        Mask,
        /// <summary>
        /// 
        /// </summary>
        Source,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAssetLineageResponseLineageEdgeRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseLineageEdgeRole value)
        {
            return value switch
            {
                GetAssetLineageResponseLineageEdgeRole.ContentRef => "content_ref",
                GetAssetLineageResponseLineageEdgeRole.Control => "control",
                GetAssetLineageResponseLineageEdgeRole.Mask => "mask",
                GetAssetLineageResponseLineageEdgeRole.Source => "source",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseLineageEdgeRole? ToEnum(string value)
        {
            return value switch
            {
                "content_ref" => GetAssetLineageResponseLineageEdgeRole.ContentRef,
                "control" => GetAssetLineageResponseLineageEdgeRole.Control,
                "mask" => GetAssetLineageResponseLineageEdgeRole.Mask,
                "source" => GetAssetLineageResponseLineageEdgeRole.Source,
                _ => null,
            };
        }
    }
}