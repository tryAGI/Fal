
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset media type
    /// </summary>
    public enum ListAssetCollectionAssetsMediaTypeItem
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
    public static class ListAssetCollectionAssetsMediaTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsMediaTypeItem value)
        {
            return value switch
            {
                ListAssetCollectionAssetsMediaTypeItem.x3d => "3d",
                ListAssetCollectionAssetsMediaTypeItem.Audio => "audio",
                ListAssetCollectionAssetsMediaTypeItem.Image => "image",
                ListAssetCollectionAssetsMediaTypeItem.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsMediaTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ListAssetCollectionAssetsMediaTypeItem.x3d,
                "audio" => ListAssetCollectionAssetsMediaTypeItem.Audio,
                "image" => ListAssetCollectionAssetsMediaTypeItem.Image,
                "video" => ListAssetCollectionAssetsMediaTypeItem.Video,
                _ => null,
            };
        }
    }
}