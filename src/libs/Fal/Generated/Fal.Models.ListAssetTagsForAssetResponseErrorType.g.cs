
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsForAssetResponseErrorType
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
    public static class ListAssetTagsForAssetResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsForAssetResponseErrorType value)
        {
            return value switch
            {
                ListAssetTagsForAssetResponseErrorType.AuthorizationError => "authorization_error",
                ListAssetTagsForAssetResponseErrorType.NotFound => "not_found",
                ListAssetTagsForAssetResponseErrorType.NotImplemented => "not_implemented",
                ListAssetTagsForAssetResponseErrorType.RateLimited => "rate_limited",
                ListAssetTagsForAssetResponseErrorType.ServerError => "server_error",
                ListAssetTagsForAssetResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsForAssetResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsForAssetResponseErrorType.AuthorizationError,
                "not_found" => ListAssetTagsForAssetResponseErrorType.NotFound,
                "not_implemented" => ListAssetTagsForAssetResponseErrorType.NotImplemented,
                "rate_limited" => ListAssetTagsForAssetResponseErrorType.RateLimited,
                "server_error" => ListAssetTagsForAssetResponseErrorType.ServerError,
                "validation_error" => ListAssetTagsForAssetResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}