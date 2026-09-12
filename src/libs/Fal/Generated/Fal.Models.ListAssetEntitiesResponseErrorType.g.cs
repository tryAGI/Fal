
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetEntitiesResponseErrorType
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
    public static class ListAssetEntitiesResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetEntitiesResponseErrorType value)
        {
            return value switch
            {
                ListAssetEntitiesResponseErrorType.AuthorizationError => "authorization_error",
                ListAssetEntitiesResponseErrorType.NotFound => "not_found",
                ListAssetEntitiesResponseErrorType.NotImplemented => "not_implemented",
                ListAssetEntitiesResponseErrorType.RateLimited => "rate_limited",
                ListAssetEntitiesResponseErrorType.ServerError => "server_error",
                ListAssetEntitiesResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetEntitiesResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetEntitiesResponseErrorType.AuthorizationError,
                "not_found" => ListAssetEntitiesResponseErrorType.NotFound,
                "not_implemented" => ListAssetEntitiesResponseErrorType.NotImplemented,
                "rate_limited" => ListAssetEntitiesResponseErrorType.RateLimited,
                "server_error" => ListAssetEntitiesResponseErrorType.ServerError,
                "validation_error" => ListAssetEntitiesResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}