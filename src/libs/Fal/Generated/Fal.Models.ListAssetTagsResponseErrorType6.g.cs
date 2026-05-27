
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsResponseErrorType6
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
    public static class ListAssetTagsResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsResponseErrorType6 value)
        {
            return value switch
            {
                ListAssetTagsResponseErrorType6.AuthorizationError => "authorization_error",
                ListAssetTagsResponseErrorType6.NotFound => "not_found",
                ListAssetTagsResponseErrorType6.NotImplemented => "not_implemented",
                ListAssetTagsResponseErrorType6.RateLimited => "rate_limited",
                ListAssetTagsResponseErrorType6.ServerError => "server_error",
                ListAssetTagsResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsResponseErrorType6.AuthorizationError,
                "not_found" => ListAssetTagsResponseErrorType6.NotFound,
                "not_implemented" => ListAssetTagsResponseErrorType6.NotImplemented,
                "rate_limited" => ListAssetTagsResponseErrorType6.RateLimited,
                "server_error" => ListAssetTagsResponseErrorType6.ServerError,
                "validation_error" => ListAssetTagsResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}