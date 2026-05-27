
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetAssetTagsForAssetResponseErrorType6
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
    public static class SetAssetTagsForAssetResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetAssetTagsForAssetResponseErrorType6 value)
        {
            return value switch
            {
                SetAssetTagsForAssetResponseErrorType6.AuthorizationError => "authorization_error",
                SetAssetTagsForAssetResponseErrorType6.NotFound => "not_found",
                SetAssetTagsForAssetResponseErrorType6.NotImplemented => "not_implemented",
                SetAssetTagsForAssetResponseErrorType6.RateLimited => "rate_limited",
                SetAssetTagsForAssetResponseErrorType6.ServerError => "server_error",
                SetAssetTagsForAssetResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetAssetTagsForAssetResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetAssetTagsForAssetResponseErrorType6.AuthorizationError,
                "not_found" => SetAssetTagsForAssetResponseErrorType6.NotFound,
                "not_implemented" => SetAssetTagsForAssetResponseErrorType6.NotImplemented,
                "rate_limited" => SetAssetTagsForAssetResponseErrorType6.RateLimited,
                "server_error" => SetAssetTagsForAssetResponseErrorType6.ServerError,
                "validation_error" => SetAssetTagsForAssetResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}