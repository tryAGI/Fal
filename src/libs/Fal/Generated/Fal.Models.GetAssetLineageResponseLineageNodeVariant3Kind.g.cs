
#nullable enable

namespace Fal
{
    /// <summary>
    /// Node kind
    /// </summary>
    public enum GetAssetLineageResponseLineageNodeVariant3Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Request,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAssetLineageResponseLineageNodeVariant3KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseLineageNodeVariant3Kind value)
        {
            return value switch
            {
                GetAssetLineageResponseLineageNodeVariant3Kind.Request => "request",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseLineageNodeVariant3Kind? ToEnum(string value)
        {
            return value switch
            {
                "request" => GetAssetLineageResponseLineageNodeVariant3Kind.Request,
                _ => null,
            };
        }
    }
}