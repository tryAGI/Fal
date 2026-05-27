
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetCollectionsResponseErrorType8
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
    public static class ListAssetCollectionsResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionsResponseErrorType8 value)
        {
            return value switch
            {
                ListAssetCollectionsResponseErrorType8.AuthorizationError => "authorization_error",
                ListAssetCollectionsResponseErrorType8.NotFound => "not_found",
                ListAssetCollectionsResponseErrorType8.NotImplemented => "not_implemented",
                ListAssetCollectionsResponseErrorType8.RateLimited => "rate_limited",
                ListAssetCollectionsResponseErrorType8.ServerError => "server_error",
                ListAssetCollectionsResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionsResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetCollectionsResponseErrorType8.AuthorizationError,
                "not_found" => ListAssetCollectionsResponseErrorType8.NotFound,
                "not_implemented" => ListAssetCollectionsResponseErrorType8.NotImplemented,
                "rate_limited" => ListAssetCollectionsResponseErrorType8.RateLimited,
                "server_error" => ListAssetCollectionsResponseErrorType8.ServerError,
                "validation_error" => ListAssetCollectionsResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}