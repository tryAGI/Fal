
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetAssetTagsForAssetResponseErrorType7
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
    public static class SetAssetTagsForAssetResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetAssetTagsForAssetResponseErrorType7 value)
        {
            return value switch
            {
                SetAssetTagsForAssetResponseErrorType7.AuthorizationError => "authorization_error",
                SetAssetTagsForAssetResponseErrorType7.NotFound => "not_found",
                SetAssetTagsForAssetResponseErrorType7.NotImplemented => "not_implemented",
                SetAssetTagsForAssetResponseErrorType7.RateLimited => "rate_limited",
                SetAssetTagsForAssetResponseErrorType7.ServerError => "server_error",
                SetAssetTagsForAssetResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetAssetTagsForAssetResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetAssetTagsForAssetResponseErrorType7.AuthorizationError,
                "not_found" => SetAssetTagsForAssetResponseErrorType7.NotFound,
                "not_implemented" => SetAssetTagsForAssetResponseErrorType7.NotImplemented,
                "rate_limited" => SetAssetTagsForAssetResponseErrorType7.RateLimited,
                "server_error" => SetAssetTagsForAssetResponseErrorType7.ServerError,
                "validation_error" => SetAssetTagsForAssetResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}