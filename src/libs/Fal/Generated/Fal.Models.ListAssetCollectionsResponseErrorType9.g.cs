
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionsResponseErrorType9
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
    public static class ListAssetCollectionsResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionsResponseErrorType9 value)
        {
            return value switch
            {
                ListAssetCollectionsResponseErrorType9.AuthorizationError => "authorization_error",
                ListAssetCollectionsResponseErrorType9.NotFound => "not_found",
                ListAssetCollectionsResponseErrorType9.NotImplemented => "not_implemented",
                ListAssetCollectionsResponseErrorType9.RateLimited => "rate_limited",
                ListAssetCollectionsResponseErrorType9.ServerError => "server_error",
                ListAssetCollectionsResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionsResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionsResponseErrorType9.AuthorizationError,
                "not_found" => ListAssetCollectionsResponseErrorType9.NotFound,
                "not_implemented" => ListAssetCollectionsResponseErrorType9.NotImplemented,
                "rate_limited" => ListAssetCollectionsResponseErrorType9.RateLimited,
                "server_error" => ListAssetCollectionsResponseErrorType9.ServerError,
                "validation_error" => ListAssetCollectionsResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}