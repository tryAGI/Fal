
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsResponseErrorType4
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
    public static class ListAssetTagsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsResponseErrorType4 value)
        {
            return value switch
            {
                ListAssetTagsResponseErrorType4.AuthorizationError => "authorization_error",
                ListAssetTagsResponseErrorType4.NotFound => "not_found",
                ListAssetTagsResponseErrorType4.NotImplemented => "not_implemented",
                ListAssetTagsResponseErrorType4.RateLimited => "rate_limited",
                ListAssetTagsResponseErrorType4.ServerError => "server_error",
                ListAssetTagsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsResponseErrorType4.AuthorizationError,
                "not_found" => ListAssetTagsResponseErrorType4.NotFound,
                "not_implemented" => ListAssetTagsResponseErrorType4.NotImplemented,
                "rate_limited" => ListAssetTagsResponseErrorType4.RateLimited,
                "server_error" => ListAssetTagsResponseErrorType4.ServerError,
                "validation_error" => ListAssetTagsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}