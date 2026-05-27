
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsResponseErrorType9
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
    public static class ListAssetTagsResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsResponseErrorType9 value)
        {
            return value switch
            {
                ListAssetTagsResponseErrorType9.AuthorizationError => "authorization_error",
                ListAssetTagsResponseErrorType9.NotFound => "not_found",
                ListAssetTagsResponseErrorType9.NotImplemented => "not_implemented",
                ListAssetTagsResponseErrorType9.RateLimited => "rate_limited",
                ListAssetTagsResponseErrorType9.ServerError => "server_error",
                ListAssetTagsResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsResponseErrorType9.AuthorizationError,
                "not_found" => ListAssetTagsResponseErrorType9.NotFound,
                "not_implemented" => ListAssetTagsResponseErrorType9.NotImplemented,
                "rate_limited" => ListAssetTagsResponseErrorType9.RateLimited,
                "server_error" => ListAssetTagsResponseErrorType9.ServerError,
                "validation_error" => ListAssetTagsResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}