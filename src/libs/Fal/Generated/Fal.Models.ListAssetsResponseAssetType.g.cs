
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset media type
    /// </summary>
    public enum ListAssetsResponseAssetType
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
    public static class ListAssetsResponseAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsResponseAssetType value)
        {
            return value switch
            {
                ListAssetsResponseAssetType.x3d => "3d",
                ListAssetsResponseAssetType.Audio => "audio",
                ListAssetsResponseAssetType.Image => "image",
                ListAssetsResponseAssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsResponseAssetType? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ListAssetsResponseAssetType.x3d,
                "audio" => ListAssetsResponseAssetType.Audio,
                "image" => ListAssetsResponseAssetType.Image,
                "video" => ListAssetsResponseAssetType.Video,
                _ => null,
            };
        }
    }
}