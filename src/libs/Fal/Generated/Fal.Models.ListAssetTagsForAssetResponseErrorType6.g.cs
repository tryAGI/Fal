
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsForAssetResponseErrorType6
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
    public static class ListAssetTagsForAssetResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsForAssetResponseErrorType6 value)
        {
            return value switch
            {
                ListAssetTagsForAssetResponseErrorType6.AuthorizationError => "authorization_error",
                ListAssetTagsForAssetResponseErrorType6.NotFound => "not_found",
                ListAssetTagsForAssetResponseErrorType6.NotImplemented => "not_implemented",
                ListAssetTagsForAssetResponseErrorType6.RateLimited => "rate_limited",
                ListAssetTagsForAssetResponseErrorType6.ServerError => "server_error",
                ListAssetTagsForAssetResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsForAssetResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsForAssetResponseErrorType6.AuthorizationError,
                "not_found" => ListAssetTagsForAssetResponseErrorType6.NotFound,
                "not_implemented" => ListAssetTagsForAssetResponseErrorType6.NotImplemented,
                "rate_limited" => ListAssetTagsForAssetResponseErrorType6.RateLimited,
                "server_error" => ListAssetTagsForAssetResponseErrorType6.ServerError,
                "validation_error" => ListAssetTagsForAssetResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}