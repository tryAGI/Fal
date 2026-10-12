
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum RevokeApiKeyResponseErrorType2
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
    public static class RevokeApiKeyResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RevokeApiKeyResponseErrorType2 value)
        {
            return value switch
            {
                RevokeApiKeyResponseErrorType2.AuthorizationError => "authorization_error",
                RevokeApiKeyResponseErrorType2.NotFound => "not_found",
                RevokeApiKeyResponseErrorType2.NotImplemented => "not_implemented",
                RevokeApiKeyResponseErrorType2.RateLimited => "rate_limited",
                RevokeApiKeyResponseErrorType2.ServerError => "server_error",
                RevokeApiKeyResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RevokeApiKeyResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => RevokeApiKeyResponseErrorType2.AuthorizationError,
                "not_found" => RevokeApiKeyResponseErrorType2.NotFound,
                "not_implemented" => RevokeApiKeyResponseErrorType2.NotImplemented,
                "rate_limited" => RevokeApiKeyResponseErrorType2.RateLimited,
                "server_error" => RevokeApiKeyResponseErrorType2.ServerError,
                "validation_error" => RevokeApiKeyResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}