
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateApiKeyResponseErrorType3
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
    public static class CreateApiKeyResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateApiKeyResponseErrorType3 value)
        {
            return value switch
            {
                CreateApiKeyResponseErrorType3.AuthorizationError => "authorization_error",
                CreateApiKeyResponseErrorType3.ValidationError => "validation_error",
                CreateApiKeyResponseErrorType3.NotFound => "not_found",
                CreateApiKeyResponseErrorType3.RateLimited => "rate_limited",
                CreateApiKeyResponseErrorType3.ServerError => "server_error",
                CreateApiKeyResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateApiKeyResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateApiKeyResponseErrorType3.AuthorizationError,
                "validation_error" => CreateApiKeyResponseErrorType3.ValidationError,
                "not_found" => CreateApiKeyResponseErrorType3.NotFound,
                "rate_limited" => CreateApiKeyResponseErrorType3.RateLimited,
                "server_error" => CreateApiKeyResponseErrorType3.ServerError,
                "not_implemented" => CreateApiKeyResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}