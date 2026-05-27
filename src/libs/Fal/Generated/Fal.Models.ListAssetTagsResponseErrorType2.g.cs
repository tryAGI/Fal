
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsResponseErrorType2
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
    public static class ListAssetTagsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsResponseErrorType2 value)
        {
            return value switch
            {
                ListAssetTagsResponseErrorType2.AuthorizationError => "authorization_error",
                ListAssetTagsResponseErrorType2.NotFound => "not_found",
                ListAssetTagsResponseErrorType2.NotImplemented => "not_implemented",
                ListAssetTagsResponseErrorType2.RateLimited => "rate_limited",
                ListAssetTagsResponseErrorType2.ServerError => "server_error",
                ListAssetTagsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsResponseErrorType2.AuthorizationError,
                "not_found" => ListAssetTagsResponseErrorType2.NotFound,
                "not_implemented" => ListAssetTagsResponseErrorType2.NotImplemented,
                "rate_limited" => ListAssetTagsResponseErrorType2.RateLimited,
                "server_error" => ListAssetTagsResponseErrorType2.ServerError,
                "validation_error" => ListAssetTagsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}