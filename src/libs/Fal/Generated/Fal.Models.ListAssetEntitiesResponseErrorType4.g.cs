
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetEntitiesResponseErrorType4
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
    public static class ListAssetEntitiesResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetEntitiesResponseErrorType4 value)
        {
            return value switch
            {
                ListAssetEntitiesResponseErrorType4.AuthorizationError => "authorization_error",
                ListAssetEntitiesResponseErrorType4.NotFound => "not_found",
                ListAssetEntitiesResponseErrorType4.NotImplemented => "not_implemented",
                ListAssetEntitiesResponseErrorType4.RateLimited => "rate_limited",
                ListAssetEntitiesResponseErrorType4.ServerError => "server_error",
                ListAssetEntitiesResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetEntitiesResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetEntitiesResponseErrorType4.AuthorizationError,
                "not_found" => ListAssetEntitiesResponseErrorType4.NotFound,
                "not_implemented" => ListAssetEntitiesResponseErrorType4.NotImplemented,
                "rate_limited" => ListAssetEntitiesResponseErrorType4.RateLimited,
                "server_error" => ListAssetEntitiesResponseErrorType4.ServerError,
                "validation_error" => ListAssetEntitiesResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}