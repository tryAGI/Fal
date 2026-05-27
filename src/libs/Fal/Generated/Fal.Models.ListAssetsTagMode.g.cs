
#nullable enable

namespace Fal
{
    /// <summary>
    /// Whether tag filters match any tag or all tags<br/>
    /// Default Value: any<br/>
    /// Example: any
    /// </summary>
    public enum ListAssetsTagMode
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAssetsTagModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsTagMode value)
        {
            return value switch
            {
                ListAssetsTagMode.All => "all",
                ListAssetsTagMode.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsTagMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => ListAssetsTagMode.All,
                "any" => ListAssetsTagMode.Any,
                _ => null,
            };
        }
    }
}