
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum RevokeApiKeyResponseErrorType3
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
    public static class RevokeApiKeyResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RevokeApiKeyResponseErrorType3 value)
        {
            return value switch
            {
                RevokeApiKeyResponseErrorType3.AuthorizationError => "authorization_error",
                RevokeApiKeyResponseErrorType3.NotFound => "not_found",
                RevokeApiKeyResponseErrorType3.NotImplemented => "not_implemented",
                RevokeApiKeyResponseErrorType3.RateLimited => "rate_limited",
                RevokeApiKeyResponseErrorType3.ServerError => "server_error",
                RevokeApiKeyResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RevokeApiKeyResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => RevokeApiKeyResponseErrorType3.AuthorizationError,
                "not_found" => RevokeApiKeyResponseErrorType3.NotFound,
                "not_implemented" => RevokeApiKeyResponseErrorType3.NotImplemented,
                "rate_limited" => RevokeApiKeyResponseErrorType3.RateLimited,
                "server_error" => RevokeApiKeyResponseErrorType3.ServerError,
                "validation_error" => RevokeApiKeyResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}