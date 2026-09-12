
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetEntityResponseErrorType7
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
    public static class GetAssetEntityResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetEntityResponseErrorType7 value)
        {
            return value switch
            {
                GetAssetEntityResponseErrorType7.AuthorizationError => "authorization_error",
                GetAssetEntityResponseErrorType7.NotFound => "not_found",
                GetAssetEntityResponseErrorType7.NotImplemented => "not_implemented",
                GetAssetEntityResponseErrorType7.RateLimited => "rate_limited",
                GetAssetEntityResponseErrorType7.ServerError => "server_error",
                GetAssetEntityResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetEntityResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetEntityResponseErrorType7.AuthorizationError,
                "not_found" => GetAssetEntityResponseErrorType7.NotFound,
                "not_implemented" => GetAssetEntityResponseErrorType7.NotImplemented,
                "rate_limited" => GetAssetEntityResponseErrorType7.RateLimited,
                "server_error" => GetAssetEntityResponseErrorType7.ServerError,
                "validation_error" => GetAssetEntityResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}