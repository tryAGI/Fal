
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetAssetTagsForAssetResponseErrorType9
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
    public static class SetAssetTagsForAssetResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetAssetTagsForAssetResponseErrorType9 value)
        {
            return value switch
            {
                SetAssetTagsForAssetResponseErrorType9.AuthorizationError => "authorization_error",
                SetAssetTagsForAssetResponseErrorType9.NotFound => "not_found",
                SetAssetTagsForAssetResponseErrorType9.NotImplemented => "not_implemented",
                SetAssetTagsForAssetResponseErrorType9.RateLimited => "rate_limited",
                SetAssetTagsForAssetResponseErrorType9.ServerError => "server_error",
                SetAssetTagsForAssetResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetAssetTagsForAssetResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetAssetTagsForAssetResponseErrorType9.AuthorizationError,
                "not_found" => SetAssetTagsForAssetResponseErrorType9.NotFound,
                "not_implemented" => SetAssetTagsForAssetResponseErrorType9.NotImplemented,
                "rate_limited" => SetAssetTagsForAssetResponseErrorType9.RateLimited,
                "server_error" => SetAssetTagsForAssetResponseErrorType9.ServerError,
                "validation_error" => SetAssetTagsForAssetResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}