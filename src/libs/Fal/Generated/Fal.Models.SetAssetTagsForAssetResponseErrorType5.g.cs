
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetAssetTagsForAssetResponseErrorType5
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
    public static class SetAssetTagsForAssetResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetAssetTagsForAssetResponseErrorType5 value)
        {
            return value switch
            {
                SetAssetTagsForAssetResponseErrorType5.AuthorizationError => "authorization_error",
                SetAssetTagsForAssetResponseErrorType5.NotFound => "not_found",
                SetAssetTagsForAssetResponseErrorType5.NotImplemented => "not_implemented",
                SetAssetTagsForAssetResponseErrorType5.RateLimited => "rate_limited",
                SetAssetTagsForAssetResponseErrorType5.ServerError => "server_error",
                SetAssetTagsForAssetResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetAssetTagsForAssetResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetAssetTagsForAssetResponseErrorType5.AuthorizationError,
                "not_found" => SetAssetTagsForAssetResponseErrorType5.NotFound,
                "not_implemented" => SetAssetTagsForAssetResponseErrorType5.NotImplemented,
                "rate_limited" => SetAssetTagsForAssetResponseErrorType5.RateLimited,
                "server_error" => SetAssetTagsForAssetResponseErrorType5.ServerError,
                "validation_error" => SetAssetTagsForAssetResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}