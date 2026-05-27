
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset media type
    /// </summary>
    public enum UpdateAssetPromptResponseAssetType
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
    public static class UpdateAssetPromptResponseAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetPromptResponseAssetType value)
        {
            return value switch
            {
                UpdateAssetPromptResponseAssetType.x3d => "3d",
                UpdateAssetPromptResponseAssetType.Audio => "audio",
                UpdateAssetPromptResponseAssetType.Image => "image",
                UpdateAssetPromptResponseAssetType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetPromptResponseAssetType? ToEnum(string value)
        {
            return value switch
            {
                "3d" => UpdateAssetPromptResponseAssetType.x3d,
                "audio" => UpdateAssetPromptResponseAssetType.Audio,
                "image" => UpdateAssetPromptResponseAssetType.Image,
                "video" => UpdateAssetPromptResponseAssetType.Video,
                _ => null,
            };
        }
    }
}