
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SetAssetTagsForAssetResponseErrorType4
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
    public static class SetAssetTagsForAssetResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetAssetTagsForAssetResponseErrorType4 value)
        {
            return value switch
            {
                SetAssetTagsForAssetResponseErrorType4.AuthorizationError => "authorization_error",
                SetAssetTagsForAssetResponseErrorType4.NotFound => "not_found",
                SetAssetTagsForAssetResponseErrorType4.NotImplemented => "not_implemented",
                SetAssetTagsForAssetResponseErrorType4.RateLimited => "rate_limited",
                SetAssetTagsForAssetResponseErrorType4.ServerError => "server_error",
                SetAssetTagsForAssetResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetAssetTagsForAssetResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SetAssetTagsForAssetResponseErrorType4.AuthorizationError,
                "not_found" => SetAssetTagsForAssetResponseErrorType4.NotFound,
                "not_implemented" => SetAssetTagsForAssetResponseErrorType4.NotImplemented,
                "rate_limited" => SetAssetTagsForAssetResponseErrorType4.RateLimited,
                "server_error" => SetAssetTagsForAssetResponseErrorType4.ServerError,
                "validation_error" => SetAssetTagsForAssetResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}