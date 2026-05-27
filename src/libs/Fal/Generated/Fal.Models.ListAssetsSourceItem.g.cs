
#nullable enable

namespace Fal
{
    /// <summary>
    /// Indexed asset source
    /// </summary>
    public enum ListAssetsSourceItem
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
    public static class ListAssetsSourceItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsSourceItem value)
        {
            return value switch
            {
                ListAssetsSourceItem.Request => "request",
                ListAssetsSourceItem.Response => "response",
                ListAssetsSourceItem.Upload => "upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsSourceItem? ToEnum(string value)
        {
            return value switch
            {
                "request" => ListAssetsSourceItem.Request,
                "response" => ListAssetsSourceItem.Response,
                "upload" => ListAssetsSourceItem.Upload,
                _ => null,
            };
        }
    }
}