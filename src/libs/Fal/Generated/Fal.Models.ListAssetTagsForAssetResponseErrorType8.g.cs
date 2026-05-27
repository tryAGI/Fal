
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetTagsForAssetResponseErrorType8
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
    public static class ListAssetTagsForAssetResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetTagsForAssetResponseErrorType8 value)
        {
            return value switch
            {
                ListAssetTagsForAssetResponseErrorType8.AuthorizationError => "authorization_error",
                ListAssetTagsForAssetResponseErrorType8.NotFound => "not_found",
                ListAssetTagsForAssetResponseErrorType8.NotImplemented => "not_implemented",
                ListAssetTagsForAssetResponseErrorType8.RateLimited => "rate_limited",
                ListAssetTagsForAssetResponseErrorType8.ServerError => "server_error",
                ListAssetTagsForAssetResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetTagsForAssetResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetTagsForAssetResponseErrorType8.AuthorizationError,
                "not_found" => ListAssetTagsForAssetResponseErrorType8.NotFound,
                "not_implemented" => ListAssetTagsForAssetResponseErrorType8.NotImplemented,
                "rate_limited" => ListAssetTagsForAssetResponseErrorType8.RateLimited,
                "server_error" => ListAssetTagsForAssetResponseErrorType8.ServerError,
                "validation_error" => ListAssetTagsForAssetResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}