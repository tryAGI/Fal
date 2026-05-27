
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsResponseErrorType
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
    public static class ListAssetTagsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsResponseErrorType value)
        {
            return value switch
            {
                ListAssetTagsResponseErrorType.AuthorizationError => "authorization_error",
                ListAssetTagsResponseErrorType.NotFound => "not_found",
                ListAssetTagsResponseErrorType.NotImplemented => "not_implemented",
                ListAssetTagsResponseErrorType.RateLimited => "rate_limited",
                ListAssetTagsResponseErrorType.ServerError => "server_error",
                ListAssetTagsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsResponseErrorType.AuthorizationError,
                "not_found" => ListAssetTagsResponseErrorType.NotFound,
                "not_implemented" => ListAssetTagsResponseErrorType.NotImplemented,
                "rate_limited" => ListAssetTagsResponseErrorType.RateLimited,
                "server_error" => ListAssetTagsResponseErrorType.ServerError,
                "validation_error" => ListAssetTagsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}