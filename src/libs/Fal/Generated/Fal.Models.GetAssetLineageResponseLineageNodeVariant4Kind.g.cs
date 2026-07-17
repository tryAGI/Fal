
#nullable enable

namespace Fal
{
    /// <summary>
    /// Node kind
    /// </summary>
    public enum GetAssetLineageResponseLineageNodeVariant4Kind
    {
        /// <summary>
        /// 
        /// </summary>
        Entity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAssetLineageResponseLineageNodeVariant4KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseLineageNodeVariant4Kind value)
        {
            return value switch
            {
                GetAssetLineageResponseLineageNodeVariant4Kind.Entity => "entity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseLineageNodeVariant4Kind? ToEnum(string value)
        {
            return value switch
            {
                "entity" => GetAssetLineageResponseLineageNodeVariant4Kind.Entity,
                _ => null,
            };
        }
    }
}