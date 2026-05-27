
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionsResponseErrorType3
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
    public static class ListAssetCollectionsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionsResponseErrorType3 value)
        {
            return value switch
            {
                ListAssetCollectionsResponseErrorType3.AuthorizationError => "authorization_error",
                ListAssetCollectionsResponseErrorType3.NotFound => "not_found",
                ListAssetCollectionsResponseErrorType3.NotImplemented => "not_implemented",
                ListAssetCollectionsResponseErrorType3.RateLimited => "rate_limited",
                ListAssetCollectionsResponseErrorType3.ServerError => "server_error",
                ListAssetCollectionsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionsResponseErrorType3.AuthorizationError,
                "not_found" => ListAssetCollectionsResponseErrorType3.NotFound,
                "not_implemented" => ListAssetCollectionsResponseErrorType3.NotImplemented,
                "rate_limited" => ListAssetCollectionsResponseErrorType3.RateLimited,
                "server_error" => ListAssetCollectionsResponseErrorType3.ServerError,
                "validation_error" => ListAssetCollectionsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}