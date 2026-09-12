
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetEntitiesResponseErrorType6
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
    public static class ListAssetEntitiesResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetEntitiesResponseErrorType6 value)
        {
            return value switch
            {
                ListAssetEntitiesResponseErrorType6.AuthorizationError => "authorization_error",
                ListAssetEntitiesResponseErrorType6.NotFound => "not_found",
                ListAssetEntitiesResponseErrorType6.NotImplemented => "not_implemented",
                ListAssetEntitiesResponseErrorType6.RateLimited => "rate_limited",
                ListAssetEntitiesResponseErrorType6.ServerError => "server_error",
                ListAssetEntitiesResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetEntitiesResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetEntitiesResponseErrorType6.AuthorizationError,
                "not_found" => ListAssetEntitiesResponseErrorType6.NotFound,
                "not_implemented" => ListAssetEntitiesResponseErrorType6.NotImplemented,
                "rate_limited" => ListAssetEntitiesResponseErrorType6.RateLimited,
                "server_error" => ListAssetEntitiesResponseErrorType6.ServerError,
                "validation_error" => ListAssetEntitiesResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}