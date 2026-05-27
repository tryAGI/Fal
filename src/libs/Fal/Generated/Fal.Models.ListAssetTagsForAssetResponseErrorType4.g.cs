
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsForAssetResponseErrorType4
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
    public static class ListAssetTagsForAssetResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsForAssetResponseErrorType4 value)
        {
            return value switch
            {
                ListAssetTagsForAssetResponseErrorType4.AuthorizationError => "authorization_error",
                ListAssetTagsForAssetResponseErrorType4.NotFound => "not_found",
                ListAssetTagsForAssetResponseErrorType4.NotImplemented => "not_implemented",
                ListAssetTagsForAssetResponseErrorType4.RateLimited => "rate_limited",
                ListAssetTagsForAssetResponseErrorType4.ServerError => "server_error",
                ListAssetTagsForAssetResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsForAssetResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsForAssetResponseErrorType4.AuthorizationError,
                "not_found" => ListAssetTagsForAssetResponseErrorType4.NotFound,
                "not_implemented" => ListAssetTagsForAssetResponseErrorType4.NotImplemented,
                "rate_limited" => ListAssetTagsForAssetResponseErrorType4.RateLimited,
                "server_error" => ListAssetTagsForAssetResponseErrorType4.ServerError,
                "validation_error" => ListAssetTagsForAssetResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}