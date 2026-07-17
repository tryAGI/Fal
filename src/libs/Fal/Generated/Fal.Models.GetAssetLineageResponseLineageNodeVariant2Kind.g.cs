
#nullable enable

namespace Fal
{
    /// <summary>
    /// Node kind
    /// </summary>
    public enum GetAssetLineageResponseLineageNodeVariant2Kind
    {
        /// <summary>
        /// 
        /// </summary>
        ExternalInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAssetLineageResponseLineageNodeVariant2KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseLineageNodeVariant2Kind value)
        {
            return value switch
            {
                GetAssetLineageResponseLineageNodeVariant2Kind.ExternalInput => "external_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseLineageNodeVariant2Kind? ToEnum(string value)
        {
            return value switch
            {
                "external_input" => GetAssetLineageResponseLineageNodeVariant2Kind.ExternalInput,
                _ => null,
            };
        }
    }
}