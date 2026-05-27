
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetAssetTagsForAssetResponseErrorType
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
    public static class SetAssetTagsForAssetResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetAssetTagsForAssetResponseErrorType value)
        {
            return value switch
            {
                SetAssetTagsForAssetResponseErrorType.AuthorizationError => "authorization_error",
                SetAssetTagsForAssetResponseErrorType.NotFound => "not_found",
                SetAssetTagsForAssetResponseErrorType.NotImplemented => "not_implemented",
                SetAssetTagsForAssetResponseErrorType.RateLimited => "rate_limited",
                SetAssetTagsForAssetResponseErrorType.ServerError => "server_error",
                SetAssetTagsForAssetResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetAssetTagsForAssetResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetAssetTagsForAssetResponseErrorType.AuthorizationError,
                "not_found" => SetAssetTagsForAssetResponseErrorType.NotFound,
                "not_implemented" => SetAssetTagsForAssetResponseErrorType.NotImplemented,
                "rate_limited" => SetAssetTagsForAssetResponseErrorType.RateLimited,
                "server_error" => SetAssetTagsForAssetResponseErrorType.ServerError,
                "validation_error" => SetAssetTagsForAssetResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}