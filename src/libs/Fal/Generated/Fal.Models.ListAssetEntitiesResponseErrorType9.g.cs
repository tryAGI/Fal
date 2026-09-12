
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetEntitiesResponseErrorType9
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
    public static class ListAssetEntitiesResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetEntitiesResponseErrorType9 value)
        {
            return value switch
            {
                ListAssetEntitiesResponseErrorType9.AuthorizationError => "authorization_error",
                ListAssetEntitiesResponseErrorType9.NotFound => "not_found",
                ListAssetEntitiesResponseErrorType9.NotImplemented => "not_implemented",
                ListAssetEntitiesResponseErrorType9.RateLimited => "rate_limited",
                ListAssetEntitiesResponseErrorType9.ServerError => "server_error",
                ListAssetEntitiesResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetEntitiesResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetEntitiesResponseErrorType9.AuthorizationError,
                "not_found" => ListAssetEntitiesResponseErrorType9.NotFound,
                "not_implemented" => ListAssetEntitiesResponseErrorType9.NotImplemented,
                "rate_limited" => ListAssetEntitiesResponseErrorType9.RateLimited,
                "server_error" => ListAssetEntitiesResponseErrorType9.ServerError,
                "validation_error" => ListAssetEntitiesResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}