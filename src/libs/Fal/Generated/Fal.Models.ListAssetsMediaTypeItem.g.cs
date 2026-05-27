
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset media type
    /// </summary>
    public enum ListAssetsMediaTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        x3d,
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAssetsMediaTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsMediaTypeItem value)
        {
            return value switch
            {
                ListAssetsMediaTypeItem.x3d => "3d",
                ListAssetsMediaTypeItem.Audio => "audio",
                ListAssetsMediaTypeItem.Image => "image",
                ListAssetsMediaTypeItem.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsMediaTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ListAssetsMediaTypeItem.x3d,
                "audio" => ListAssetsMediaTypeItem.Audio,
                "image" => ListAssetsMediaTypeItem.Image,
                "video" => ListAssetsMediaTypeItem.Video,
                _ => null,
            };
        }
    }
}