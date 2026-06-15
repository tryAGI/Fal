
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SignStorageFileUrlResponseErrorType6
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
    public static class SignStorageFileUrlResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignStorageFileUrlResponseErrorType6 value)
        {
            return value switch
            {
                SignStorageFileUrlResponseErrorType6.AuthorizationError => "authorization_error",
                SignStorageFileUrlResponseErrorType6.NotFound => "not_found",
                SignStorageFileUrlResponseErrorType6.NotImplemented => "not_implemented",
                SignStorageFileUrlResponseErrorType6.RateLimited => "rate_limited",
                SignStorageFileUrlResponseErrorType6.ServerError => "server_error",
                SignStorageFileUrlResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignStorageFileUrlResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SignStorageFileUrlResponseErrorType6.AuthorizationError,
                "not_found" => SignStorageFileUrlResponseErrorType6.NotFound,
                "not_implemented" => SignStorageFileUrlResponseErrorType6.NotImplemented,
                "rate_limited" => SignStorageFileUrlResponseErrorType6.RateLimited,
                "server_error" => SignStorageFileUrlResponseErrorType6.ServerError,
                "validation_error" => SignStorageFileUrlResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}