
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset media type
    /// </summary>
    public enum ListAssetCollectionAssetsResponseAssetType
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
    public static class ListAssetCollectionAssetsResponseAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsResponseAssetType value)
        {
            return value switch
            {
                ListAssetCollectionAssetsResponseAssetType.x3d => "3d",
                ListAssetCollectionAssetsResponseAssetType.Audio => "audio",
                ListAssetCollectionAssetsResponseAssetType.Image => "image",
                ListAssetCollectionAssetsResponseAssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsResponseAssetType? ToEnum(string value)
        {
            return value switch
            {
                "3d" => ListAssetCollectionAssetsResponseAssetType.x3d,
                "audio" => ListAssetCollectionAssetsResponseAssetType.Audio,
                "image" => ListAssetCollectionAssetsResponseAssetType.Image,
                "video" => ListAssetCollectionAssetsResponseAssetType.Video,
                _ => null,
            };
        }
    }
}