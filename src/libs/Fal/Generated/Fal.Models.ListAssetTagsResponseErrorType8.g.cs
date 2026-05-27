
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsResponseErrorType8
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
    public static class ListAssetTagsResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsResponseErrorType8 value)
        {
            return value switch
            {
                ListAssetTagsResponseErrorType8.AuthorizationError => "authorization_error",
                ListAssetTagsResponseErrorType8.NotFound => "not_found",
                ListAssetTagsResponseErrorType8.NotImplemented => "not_implemented",
                ListAssetTagsResponseErrorType8.RateLimited => "rate_limited",
                ListAssetTagsResponseErrorType8.ServerError => "server_error",
                ListAssetTagsResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsResponseErrorType8.AuthorizationError,
                "not_found" => ListAssetTagsResponseErrorType8.NotFound,
                "not_implemented" => ListAssetTagsResponseErrorType8.NotImplemented,
                "rate_limited" => ListAssetTagsResponseErrorType8.RateLimited,
                "server_error" => ListAssetTagsResponseErrorType8.ServerError,
                "validation_error" => ListAssetTagsResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}