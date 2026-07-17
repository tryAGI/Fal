
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset media type
    /// </summary>
    public enum GetAssetLineageResponseLineageNodeVariant1Type
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
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAssetLineageResponseLineageNodeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseLineageNodeVariant1Type value)
        {
            return value switch
            {
                GetAssetLineageResponseLineageNodeVariant1Type.x3d => "3d",
                GetAssetLineageResponseLineageNodeVariant1Type.Audio => "audio",
                GetAssetLineageResponseLineageNodeVariant1Type.Image => "image",
                GetAssetLineageResponseLineageNodeVariant1Type.Text => "text",
                GetAssetLineageResponseLineageNodeVariant1Type.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseLineageNodeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "3d" => GetAssetLineageResponseLineageNodeVariant1Type.x3d,
                "audio" => GetAssetLineageResponseLineageNodeVariant1Type.Audio,
                "image" => GetAssetLineageResponseLineageNodeVariant1Type.Image,
                "text" => GetAssetLineageResponseLineageNodeVariant1Type.Text,
                "video" => GetAssetLineageResponseLineageNodeVariant1Type.Video,
                _ => null,
            };
        }
    }
}