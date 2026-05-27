
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionsResponseErrorType2
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
    public static class ListAssetCollectionsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionsResponseErrorType2 value)
        {
            return value switch
            {
                ListAssetCollectionsResponseErrorType2.AuthorizationError => "authorization_error",
                ListAssetCollectionsResponseErrorType2.NotFound => "not_found",
                ListAssetCollectionsResponseErrorType2.NotImplemented => "not_implemented",
                ListAssetCollectionsResponseErrorType2.RateLimited => "rate_limited",
                ListAssetCollectionsResponseErrorType2.ServerError => "server_error",
                ListAssetCollectionsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionsResponseErrorType2.AuthorizationError,
                "not_found" => ListAssetCollectionsResponseErrorType2.NotFound,
                "not_implemented" => ListAssetCollectionsResponseErrorType2.NotImplemented,
                "rate_limited" => ListAssetCollectionsResponseErrorType2.RateLimited,
                "server_error" => ListAssetCollectionsResponseErrorType2.ServerError,
                "validation_error" => ListAssetCollectionsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}