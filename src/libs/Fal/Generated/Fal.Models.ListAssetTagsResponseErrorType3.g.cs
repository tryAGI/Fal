
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsResponseErrorType3
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
    public static class ListAssetTagsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsResponseErrorType3 value)
        {
            return value switch
            {
                ListAssetTagsResponseErrorType3.AuthorizationError => "authorization_error",
                ListAssetTagsResponseErrorType3.NotFound => "not_found",
                ListAssetTagsResponseErrorType3.NotImplemented => "not_implemented",
                ListAssetTagsResponseErrorType3.RateLimited => "rate_limited",
                ListAssetTagsResponseErrorType3.ServerError => "server_error",
                ListAssetTagsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsResponseErrorType3.AuthorizationError,
                "not_found" => ListAssetTagsResponseErrorType3.NotFound,
                "not_implemented" => ListAssetTagsResponseErrorType3.NotImplemented,
                "rate_limited" => ListAssetTagsResponseErrorType3.RateLimited,
                "server_error" => ListAssetTagsResponseErrorType3.ServerError,
                "validation_error" => ListAssetTagsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}