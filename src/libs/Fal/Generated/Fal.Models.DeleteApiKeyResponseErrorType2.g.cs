
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteApiKeyResponseErrorType2
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
    public static class DeleteApiKeyResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteApiKeyResponseErrorType2 value)
        {
            return value switch
            {
                DeleteApiKeyResponseErrorType2.AuthorizationError => "authorization_error",
                DeleteApiKeyResponseErrorType2.ValidationError => "validation_error",
                DeleteApiKeyResponseErrorType2.NotFound => "not_found",
                DeleteApiKeyResponseErrorType2.RateLimited => "rate_limited",
                DeleteApiKeyResponseErrorType2.ServerError => "server_error",
                DeleteApiKeyResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteApiKeyResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteApiKeyResponseErrorType2.AuthorizationError,
                "validation_error" => DeleteApiKeyResponseErrorType2.ValidationError,
                "not_found" => DeleteApiKeyResponseErrorType2.NotFound,
                "rate_limited" => DeleteApiKeyResponseErrorType2.RateLimited,
                "server_error" => DeleteApiKeyResponseErrorType2.ServerError,
                "not_implemented" => DeleteApiKeyResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}