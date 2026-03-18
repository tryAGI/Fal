
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateApiKeyResponseErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        ValidationError,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
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
        NotImplemented,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateApiKeyResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyResponseErrorType value)
        {
            return value switch
            {
                CreateApiKeyResponseErrorType.AuthorizationError => "authorization_error",
                CreateApiKeyResponseErrorType.ValidationError => "validation_error",
                CreateApiKeyResponseErrorType.NotFound => "not_found",
                CreateApiKeyResponseErrorType.RateLimited => "rate_limited",
                CreateApiKeyResponseErrorType.ServerError => "server_error",
                CreateApiKeyResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateApiKeyResponseErrorType.AuthorizationError,
                "validation_error" => CreateApiKeyResponseErrorType.ValidationError,
                "not_found" => CreateApiKeyResponseErrorType.NotFound,
                "rate_limited" => CreateApiKeyResponseErrorType.RateLimited,
                "server_error" => CreateApiKeyResponseErrorType.ServerError,
                "not_implemented" => CreateApiKeyResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}