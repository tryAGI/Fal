
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetAssetTagsForAssetResponseErrorType2
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        NotImplemented,
        /// <summary>
        /// 
        /// </summary>
        RateLimited,
        /// <summary>
        /// 
        /// </summary>
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SetAssetTagsForAssetResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetAssetTagsForAssetResponseErrorType2 value)
        {
            return value switch
            {
                SetAssetTagsForAssetResponseErrorType2.AuthorizationError => "authorization_error",
                SetAssetTagsForAssetResponseErrorType2.NotFound => "not_found",
                SetAssetTagsForAssetResponseErrorType2.NotImplemented => "not_implemented",
                SetAssetTagsForAssetResponseErrorType2.RateLimited => "rate_limited",
                SetAssetTagsForAssetResponseErrorType2.ServerError => "server_error",
                SetAssetTagsForAssetResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetAssetTagsForAssetResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetAssetTagsForAssetResponseErrorType2.AuthorizationError,
                "not_found" => SetAssetTagsForAssetResponseErrorType2.NotFound,
                "not_implemented" => SetAssetTagsForAssetResponseErrorType2.NotImplemented,
                "rate_limited" => SetAssetTagsForAssetResponseErrorType2.RateLimited,
                "server_error" => SetAssetTagsForAssetResponseErrorType2.ServerError,
                "validation_error" => SetAssetTagsForAssetResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}