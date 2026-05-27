
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsResponseErrorType5
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
    public static class ListAssetTagsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsResponseErrorType5 value)
        {
            return value switch
            {
                ListAssetTagsResponseErrorType5.AuthorizationError => "authorization_error",
                ListAssetTagsResponseErrorType5.NotFound => "not_found",
                ListAssetTagsResponseErrorType5.NotImplemented => "not_implemented",
                ListAssetTagsResponseErrorType5.RateLimited => "rate_limited",
                ListAssetTagsResponseErrorType5.ServerError => "server_error",
                ListAssetTagsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsResponseErrorType5.AuthorizationError,
                "not_found" => ListAssetTagsResponseErrorType5.NotFound,
                "not_implemented" => ListAssetTagsResponseErrorType5.NotImplemented,
                "rate_limited" => ListAssetTagsResponseErrorType5.RateLimited,
                "server_error" => ListAssetTagsResponseErrorType5.ServerError,
                "validation_error" => ListAssetTagsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}