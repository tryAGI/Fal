
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsForAssetResponseErrorType2
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
    public static class ListAssetTagsForAssetResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsForAssetResponseErrorType2 value)
        {
            return value switch
            {
                ListAssetTagsForAssetResponseErrorType2.AuthorizationError => "authorization_error",
                ListAssetTagsForAssetResponseErrorType2.NotFound => "not_found",
                ListAssetTagsForAssetResponseErrorType2.NotImplemented => "not_implemented",
                ListAssetTagsForAssetResponseErrorType2.RateLimited => "rate_limited",
                ListAssetTagsForAssetResponseErrorType2.ServerError => "server_error",
                ListAssetTagsForAssetResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsForAssetResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsForAssetResponseErrorType2.AuthorizationError,
                "not_found" => ListAssetTagsForAssetResponseErrorType2.NotFound,
                "not_implemented" => ListAssetTagsForAssetResponseErrorType2.NotImplemented,
                "rate_limited" => ListAssetTagsForAssetResponseErrorType2.RateLimited,
                "server_error" => ListAssetTagsForAssetResponseErrorType2.ServerError,
                "validation_error" => ListAssetTagsForAssetResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}