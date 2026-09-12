
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetEntitiesResponseErrorType3
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
    public static class ListAssetEntitiesResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetEntitiesResponseErrorType3 value)
        {
            return value switch
            {
                ListAssetEntitiesResponseErrorType3.AuthorizationError => "authorization_error",
                ListAssetEntitiesResponseErrorType3.NotFound => "not_found",
                ListAssetEntitiesResponseErrorType3.NotImplemented => "not_implemented",
                ListAssetEntitiesResponseErrorType3.RateLimited => "rate_limited",
                ListAssetEntitiesResponseErrorType3.ServerError => "server_error",
                ListAssetEntitiesResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetEntitiesResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetEntitiesResponseErrorType3.AuthorizationError,
                "not_found" => ListAssetEntitiesResponseErrorType3.NotFound,
                "not_implemented" => ListAssetEntitiesResponseErrorType3.NotImplemented,
                "rate_limited" => ListAssetEntitiesResponseErrorType3.RateLimited,
                "server_error" => ListAssetEntitiesResponseErrorType3.ServerError,
                "validation_error" => ListAssetEntitiesResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}