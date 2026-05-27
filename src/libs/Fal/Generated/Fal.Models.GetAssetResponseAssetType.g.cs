
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset media type
    /// </summary>
    public enum GetAssetResponseAssetType
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
    public static class GetAssetResponseAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetResponseAssetType value)
        {
            return value switch
            {
                GetAssetResponseAssetType.x3d => "3d",
                GetAssetResponseAssetType.Audio => "audio",
                GetAssetResponseAssetType.Image => "image",
                GetAssetResponseAssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetResponseAssetType? ToEnum(string value)
        {
            return value switch
            {
                "3d" => GetAssetResponseAssetType.x3d,
                "audio" => GetAssetResponseAssetType.Audio,
                "image" => GetAssetResponseAssetType.Image,
                "video" => GetAssetResponseAssetType.Video,
                _ => null,
            };
        }
    }
}