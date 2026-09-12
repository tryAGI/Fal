
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetEntitiesResponseErrorType8
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
    public static class ListAssetEntitiesResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetEntitiesResponseErrorType8 value)
        {
            return value switch
            {
                ListAssetEntitiesResponseErrorType8.AuthorizationError => "authorization_error",
                ListAssetEntitiesResponseErrorType8.NotFound => "not_found",
                ListAssetEntitiesResponseErrorType8.NotImplemented => "not_implemented",
                ListAssetEntitiesResponseErrorType8.RateLimited => "rate_limited",
                ListAssetEntitiesResponseErrorType8.ServerError => "server_error",
                ListAssetEntitiesResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetEntitiesResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetEntitiesResponseErrorType8.AuthorizationError,
                "not_found" => ListAssetEntitiesResponseErrorType8.NotFound,
                "not_implemented" => ListAssetEntitiesResponseErrorType8.NotImplemented,
                "rate_limited" => ListAssetEntitiesResponseErrorType8.RateLimited,
                "server_error" => ListAssetEntitiesResponseErrorType8.ServerError,
                "validation_error" => ListAssetEntitiesResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}