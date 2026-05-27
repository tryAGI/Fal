
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsForAssetResponseErrorType7
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
    public static class ListAssetTagsForAssetResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsForAssetResponseErrorType7 value)
        {
            return value switch
            {
                ListAssetTagsForAssetResponseErrorType7.AuthorizationError => "authorization_error",
                ListAssetTagsForAssetResponseErrorType7.NotFound => "not_found",
                ListAssetTagsForAssetResponseErrorType7.NotImplemented => "not_implemented",
                ListAssetTagsForAssetResponseErrorType7.RateLimited => "rate_limited",
                ListAssetTagsForAssetResponseErrorType7.ServerError => "server_error",
                ListAssetTagsForAssetResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsForAssetResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsForAssetResponseErrorType7.AuthorizationError,
                "not_found" => ListAssetTagsForAssetResponseErrorType7.NotFound,
                "not_implemented" => ListAssetTagsForAssetResponseErrorType7.NotImplemented,
                "rate_limited" => ListAssetTagsForAssetResponseErrorType7.RateLimited,
                "server_error" => ListAssetTagsForAssetResponseErrorType7.ServerError,
                "validation_error" => ListAssetTagsForAssetResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}