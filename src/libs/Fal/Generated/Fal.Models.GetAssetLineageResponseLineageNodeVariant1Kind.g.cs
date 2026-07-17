
#nullable enable

namespace Fal
{
    /// <summary>
    /// Node kind
    /// </summary>
    public enum GetAssetLineageResponseLineageNodeVariant1Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Asset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAssetLineageResponseLineageNodeVariant1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseLineageNodeVariant1Kind value)
        {
            return value switch
            {
                GetAssetLineageResponseLineageNodeVariant1Kind.Asset => "asset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseLineageNodeVariant1Kind? ToEnum(string value)
        {
            return value switch
            {
                "asset" => GetAssetLineageResponseLineageNodeVariant1Kind.Asset,
                _ => null,
            };
        }
    }
}