
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateApiKeyResponseErrorType2
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
    public static class CreateApiKeyResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyResponseErrorType2 value)
        {
            return value switch
            {
                CreateApiKeyResponseErrorType2.AuthorizationError => "authorization_error",
                CreateApiKeyResponseErrorType2.ValidationError => "validation_error",
                CreateApiKeyResponseErrorType2.NotFound => "not_found",
                CreateApiKeyResponseErrorType2.RateLimited => "rate_limited",
                CreateApiKeyResponseErrorType2.ServerError => "server_error",
                CreateApiKeyResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateApiKeyResponseErrorType2.AuthorizationError,
                "validation_error" => CreateApiKeyResponseErrorType2.ValidationError,
                "not_found" => CreateApiKeyResponseErrorType2.NotFound,
                "rate_limited" => CreateApiKeyResponseErrorType2.RateLimited,
                "server_error" => CreateApiKeyResponseErrorType2.ServerError,
                "not_implemented" => CreateApiKeyResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}