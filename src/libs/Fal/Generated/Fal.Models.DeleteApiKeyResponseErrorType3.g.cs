
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteApiKeyResponseErrorType3
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
    public static class DeleteApiKeyResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteApiKeyResponseErrorType3 value)
        {
            return value switch
            {
                DeleteApiKeyResponseErrorType3.AuthorizationError => "authorization_error",
                DeleteApiKeyResponseErrorType3.ValidationError => "validation_error",
                DeleteApiKeyResponseErrorType3.NotFound => "not_found",
                DeleteApiKeyResponseErrorType3.RateLimited => "rate_limited",
                DeleteApiKeyResponseErrorType3.ServerError => "server_error",
                DeleteApiKeyResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteApiKeyResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteApiKeyResponseErrorType3.AuthorizationError,
                "validation_error" => DeleteApiKeyResponseErrorType3.ValidationError,
                "not_found" => DeleteApiKeyResponseErrorType3.NotFound,
                "rate_limited" => DeleteApiKeyResponseErrorType3.RateLimited,
                "server_error" => DeleteApiKeyResponseErrorType3.ServerError,
                "not_implemented" => DeleteApiKeyResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}