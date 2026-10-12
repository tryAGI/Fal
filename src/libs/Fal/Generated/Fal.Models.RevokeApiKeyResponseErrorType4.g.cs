
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum RevokeApiKeyResponseErrorType4
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
    public static class RevokeApiKeyResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RevokeApiKeyResponseErrorType4 value)
        {
            return value switch
            {
                RevokeApiKeyResponseErrorType4.AuthorizationError => "authorization_error",
                RevokeApiKeyResponseErrorType4.NotFound => "not_found",
                RevokeApiKeyResponseErrorType4.NotImplemented => "not_implemented",
                RevokeApiKeyResponseErrorType4.RateLimited => "rate_limited",
                RevokeApiKeyResponseErrorType4.ServerError => "server_error",
                RevokeApiKeyResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RevokeApiKeyResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => RevokeApiKeyResponseErrorType4.AuthorizationError,
                "not_found" => RevokeApiKeyResponseErrorType4.NotFound,
                "not_implemented" => RevokeApiKeyResponseErrorType4.NotImplemented,
                "rate_limited" => RevokeApiKeyResponseErrorType4.RateLimited,
                "server_error" => RevokeApiKeyResponseErrorType4.ServerError,
                "validation_error" => RevokeApiKeyResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}