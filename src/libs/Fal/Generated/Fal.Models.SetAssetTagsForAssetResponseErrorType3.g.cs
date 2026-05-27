
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetAssetTagsForAssetResponseErrorType3
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
    public static class SetAssetTagsForAssetResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetAssetTagsForAssetResponseErrorType3 value)
        {
            return value switch
            {
                SetAssetTagsForAssetResponseErrorType3.AuthorizationError => "authorization_error",
                SetAssetTagsForAssetResponseErrorType3.NotFound => "not_found",
                SetAssetTagsForAssetResponseErrorType3.NotImplemented => "not_implemented",
                SetAssetTagsForAssetResponseErrorType3.RateLimited => "rate_limited",
                SetAssetTagsForAssetResponseErrorType3.ServerError => "server_error",
                SetAssetTagsForAssetResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetAssetTagsForAssetResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetAssetTagsForAssetResponseErrorType3.AuthorizationError,
                "not_found" => SetAssetTagsForAssetResponseErrorType3.NotFound,
                "not_implemented" => SetAssetTagsForAssetResponseErrorType3.NotImplemented,
                "rate_limited" => SetAssetTagsForAssetResponseErrorType3.RateLimited,
                "server_error" => SetAssetTagsForAssetResponseErrorType3.ServerError,
                "validation_error" => SetAssetTagsForAssetResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}