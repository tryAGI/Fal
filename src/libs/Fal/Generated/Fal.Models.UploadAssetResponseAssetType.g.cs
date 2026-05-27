
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset media type
    /// </summary>
    public enum UploadAssetResponseAssetType
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
    public static class UploadAssetResponseAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAssetResponseAssetType value)
        {
            return value switch
            {
                UploadAssetResponseAssetType.x3d => "3d",
                UploadAssetResponseAssetType.Audio => "audio",
                UploadAssetResponseAssetType.Image => "image",
                UploadAssetResponseAssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAssetResponseAssetType? ToEnum(string value)
        {
            return value switch
            {
                "3d" => UploadAssetResponseAssetType.x3d,
                "audio" => UploadAssetResponseAssetType.Audio,
                "image" => UploadAssetResponseAssetType.Image,
                "video" => UploadAssetResponseAssetType.Video,
                _ => null,
            };
        }
    }
}