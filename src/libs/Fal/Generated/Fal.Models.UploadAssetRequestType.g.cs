
#nullable enable

namespace Fal
{
    /// <summary>
    /// Media type for the uploaded asset
    /// </summary>
    public enum UploadAssetRequestType
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
    public static class UploadAssetRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAssetRequestType value)
        {
            return value switch
            {
                UploadAssetRequestType.x3d => "3d",
                UploadAssetRequestType.Audio => "audio",
                UploadAssetRequestType.Image => "image",
                UploadAssetRequestType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAssetRequestType? ToEnum(string value)
        {
            return value switch
            {
                "3d" => UploadAssetRequestType.x3d,
                "audio" => UploadAssetRequestType.Audio,
                "image" => UploadAssetRequestType.Image,
                "video" => UploadAssetRequestType.Video,
                _ => null,
            };
        }
    }
}