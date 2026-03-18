
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteApiKeyResponseErrorType4
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
    public static class DeleteApiKeyResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteApiKeyResponseErrorType4 value)
        {
            return value switch
            {
                DeleteApiKeyResponseErrorType4.AuthorizationError => "authorization_error",
                DeleteApiKeyResponseErrorType4.ValidationError => "validation_error",
                DeleteApiKeyResponseErrorType4.NotFound => "not_found",
                DeleteApiKeyResponseErrorType4.RateLimited => "rate_limited",
                DeleteApiKeyResponseErrorType4.ServerError => "server_error",
                DeleteApiKeyResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteApiKeyResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteApiKeyResponseErrorType4.AuthorizationError,
                "validation_error" => DeleteApiKeyResponseErrorType4.ValidationError,
                "not_found" => DeleteApiKeyResponseErrorType4.NotFound,
                "rate_limited" => DeleteApiKeyResponseErrorType4.RateLimited,
                "server_error" => DeleteApiKeyResponseErrorType4.ServerError,
                "not_implemented" => DeleteApiKeyResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}