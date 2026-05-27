
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionsResponseErrorType
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
    public static class ListAssetCollectionsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionsResponseErrorType value)
        {
            return value switch
            {
                ListAssetCollectionsResponseErrorType.AuthorizationError => "authorization_error",
                ListAssetCollectionsResponseErrorType.NotFound => "not_found",
                ListAssetCollectionsResponseErrorType.NotImplemented => "not_implemented",
                ListAssetCollectionsResponseErrorType.RateLimited => "rate_limited",
                ListAssetCollectionsResponseErrorType.ServerError => "server_error",
                ListAssetCollectionsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionsResponseErrorType.AuthorizationError,
                "not_found" => ListAssetCollectionsResponseErrorType.NotFound,
                "not_implemented" => ListAssetCollectionsResponseErrorType.NotImplemented,
                "rate_limited" => ListAssetCollectionsResponseErrorType.RateLimited,
                "server_error" => ListAssetCollectionsResponseErrorType.ServerError,
                "validation_error" => ListAssetCollectionsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}