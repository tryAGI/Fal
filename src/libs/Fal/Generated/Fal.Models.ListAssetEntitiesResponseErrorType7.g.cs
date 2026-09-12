
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetEntitiesResponseErrorType7
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
    public static class ListAssetEntitiesResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetEntitiesResponseErrorType7 value)
        {
            return value switch
            {
                ListAssetEntitiesResponseErrorType7.AuthorizationError => "authorization_error",
                ListAssetEntitiesResponseErrorType7.NotFound => "not_found",
                ListAssetEntitiesResponseErrorType7.NotImplemented => "not_implemented",
                ListAssetEntitiesResponseErrorType7.RateLimited => "rate_limited",
                ListAssetEntitiesResponseErrorType7.ServerError => "server_error",
                ListAssetEntitiesResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetEntitiesResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetEntitiesResponseErrorType7.AuthorizationError,
                "not_found" => ListAssetEntitiesResponseErrorType7.NotFound,
                "not_implemented" => ListAssetEntitiesResponseErrorType7.NotImplemented,
                "rate_limited" => ListAssetEntitiesResponseErrorType7.RateLimited,
                "server_error" => ListAssetEntitiesResponseErrorType7.ServerError,
                "validation_error" => ListAssetEntitiesResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}