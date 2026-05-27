
#nullable enable

namespace Fal
{
    /// <summary>
    /// Indexed asset source
    /// </summary>
    public enum ListAssetCollectionAssetsSourceItem
    {
        /// <summary>
        /// 
        /// </summary>
        Request,
        /// <summary>
        /// 
        /// </summary>
        Response,
        /// <summary>
        /// 
        /// </summary>
        Upload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAssetCollectionAssetsSourceItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsSourceItem value)
        {
            return value switch
            {
                ListAssetCollectionAssetsSourceItem.Request => "request",
                ListAssetCollectionAssetsSourceItem.Response => "response",
                ListAssetCollectionAssetsSourceItem.Upload => "upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsSourceItem? ToEnum(string value)
        {
            return value switch
            {
                "request" => ListAssetCollectionAssetsSourceItem.Request,
                "response" => ListAssetCollectionAssetsSourceItem.Response,
                "upload" => ListAssetCollectionAssetsSourceItem.Upload,
                _ => null,
            };
        }
    }
}