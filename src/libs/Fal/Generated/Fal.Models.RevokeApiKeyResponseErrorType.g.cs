
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum RevokeApiKeyResponseErrorType
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
    public static class RevokeApiKeyResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RevokeApiKeyResponseErrorType value)
        {
            return value switch
            {
                RevokeApiKeyResponseErrorType.AuthorizationError => "authorization_error",
                RevokeApiKeyResponseErrorType.NotFound => "not_found",
                RevokeApiKeyResponseErrorType.NotImplemented => "not_implemented",
                RevokeApiKeyResponseErrorType.RateLimited => "rate_limited",
                RevokeApiKeyResponseErrorType.ServerError => "server_error",
                RevokeApiKeyResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RevokeApiKeyResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => RevokeApiKeyResponseErrorType.AuthorizationError,
                "not_found" => RevokeApiKeyResponseErrorType.NotFound,
                "not_implemented" => RevokeApiKeyResponseErrorType.NotImplemented,
                "rate_limited" => RevokeApiKeyResponseErrorType.RateLimited,
                "server_error" => RevokeApiKeyResponseErrorType.ServerError,
                "validation_error" => RevokeApiKeyResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}