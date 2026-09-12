
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListAssetEntitiesResponseErrorType2
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
    public static class ListAssetEntitiesResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetEntitiesResponseErrorType2 value)
        {
            return value switch
            {
                ListAssetEntitiesResponseErrorType2.AuthorizationError => "authorization_error",
                ListAssetEntitiesResponseErrorType2.NotFound => "not_found",
                ListAssetEntitiesResponseErrorType2.NotImplemented => "not_implemented",
                ListAssetEntitiesResponseErrorType2.RateLimited => "rate_limited",
                ListAssetEntitiesResponseErrorType2.ServerError => "server_error",
                ListAssetEntitiesResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetEntitiesResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListAssetEntitiesResponseErrorType2.AuthorizationError,
                "not_found" => ListAssetEntitiesResponseErrorType2.NotFound,
                "not_implemented" => ListAssetEntitiesResponseErrorType2.NotImplemented,
                "rate_limited" => ListAssetEntitiesResponseErrorType2.RateLimited,
                "server_error" => ListAssetEntitiesResponseErrorType2.ServerError,
                "validation_error" => ListAssetEntitiesResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}