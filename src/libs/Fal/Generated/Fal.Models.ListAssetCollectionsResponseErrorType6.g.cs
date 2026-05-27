
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionsResponseErrorType6
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
    public static class ListAssetCollectionsResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionsResponseErrorType6 value)
        {
            return value switch
            {
                ListAssetCollectionsResponseErrorType6.AuthorizationError => "authorization_error",
                ListAssetCollectionsResponseErrorType6.NotFound => "not_found",
                ListAssetCollectionsResponseErrorType6.NotImplemented => "not_implemented",
                ListAssetCollectionsResponseErrorType6.RateLimited => "rate_limited",
                ListAssetCollectionsResponseErrorType6.ServerError => "server_error",
                ListAssetCollectionsResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionsResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionsResponseErrorType6.AuthorizationError,
                "not_found" => ListAssetCollectionsResponseErrorType6.NotFound,
                "not_implemented" => ListAssetCollectionsResponseErrorType6.NotImplemented,
                "rate_limited" => ListAssetCollectionsResponseErrorType6.RateLimited,
                "server_error" => ListAssetCollectionsResponseErrorType6.ServerError,
                "validation_error" => ListAssetCollectionsResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}