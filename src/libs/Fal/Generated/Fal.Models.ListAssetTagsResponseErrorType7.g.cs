
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsResponseErrorType7
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
    public static class ListAssetTagsResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsResponseErrorType7 value)
        {
            return value switch
            {
                ListAssetTagsResponseErrorType7.AuthorizationError => "authorization_error",
                ListAssetTagsResponseErrorType7.NotFound => "not_found",
                ListAssetTagsResponseErrorType7.NotImplemented => "not_implemented",
                ListAssetTagsResponseErrorType7.RateLimited => "rate_limited",
                ListAssetTagsResponseErrorType7.ServerError => "server_error",
                ListAssetTagsResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsResponseErrorType7.AuthorizationError,
                "not_found" => ListAssetTagsResponseErrorType7.NotFound,
                "not_implemented" => ListAssetTagsResponseErrorType7.NotImplemented,
                "rate_limited" => ListAssetTagsResponseErrorType7.RateLimited,
                "server_error" => ListAssetTagsResponseErrorType7.ServerError,
                "validation_error" => ListAssetTagsResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}