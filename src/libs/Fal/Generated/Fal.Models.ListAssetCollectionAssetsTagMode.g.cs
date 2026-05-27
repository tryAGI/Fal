
#nullable enable

namespace Fal
{
    /// <summary>
    /// Whether tag filters match any tag or all tags<br/>
    /// Default Value: any<br/>
    /// Example: any
    /// </summary>
    public enum ListAssetCollectionAssetsTagMode
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
    public static class ListAssetCollectionAssetsTagModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsTagMode value)
        {
            return value switch
            {
                ListAssetCollectionAssetsTagMode.All => "all",
                ListAssetCollectionAssetsTagMode.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsTagMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => ListAssetCollectionAssetsTagMode.All,
                "any" => ListAssetCollectionAssetsTagMode.Any,
                _ => null,
            };
        }
    }
}