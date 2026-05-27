
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionsResponseErrorType4
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
    public static class ListAssetCollectionsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionsResponseErrorType4 value)
        {
            return value switch
            {
                ListAssetCollectionsResponseErrorType4.AuthorizationError => "authorization_error",
                ListAssetCollectionsResponseErrorType4.NotFound => "not_found",
                ListAssetCollectionsResponseErrorType4.NotImplemented => "not_implemented",
                ListAssetCollectionsResponseErrorType4.RateLimited => "rate_limited",
                ListAssetCollectionsResponseErrorType4.ServerError => "server_error",
                ListAssetCollectionsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionsResponseErrorType4.AuthorizationError,
                "not_found" => ListAssetCollectionsResponseErrorType4.NotFound,
                "not_implemented" => ListAssetCollectionsResponseErrorType4.NotImplemented,
                "rate_limited" => ListAssetCollectionsResponseErrorType4.RateLimited,
                "server_error" => ListAssetCollectionsResponseErrorType4.ServerError,
                "validation_error" => ListAssetCollectionsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}