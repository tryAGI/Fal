
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteApiKeyResponseErrorType
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
    public static class DeleteApiKeyResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteApiKeyResponseErrorType value)
        {
            return value switch
            {
                DeleteApiKeyResponseErrorType.AuthorizationError => "authorization_error",
                DeleteApiKeyResponseErrorType.ValidationError => "validation_error",
                DeleteApiKeyResponseErrorType.NotFound => "not_found",
                DeleteApiKeyResponseErrorType.RateLimited => "rate_limited",
                DeleteApiKeyResponseErrorType.ServerError => "server_error",
                DeleteApiKeyResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteApiKeyResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteApiKeyResponseErrorType.AuthorizationError,
                "validation_error" => DeleteApiKeyResponseErrorType.ValidationError,
                "not_found" => DeleteApiKeyResponseErrorType.NotFound,
                "rate_limited" => DeleteApiKeyResponseErrorType.RateLimited,
                "server_error" => DeleteApiKeyResponseErrorType.ServerError,
                "not_implemented" => DeleteApiKeyResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}