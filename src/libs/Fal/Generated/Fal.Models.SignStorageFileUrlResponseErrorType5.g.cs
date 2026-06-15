
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SignStorageFileUrlResponseErrorType5
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
    public static class SignStorageFileUrlResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignStorageFileUrlResponseErrorType5 value)
        {
            return value switch
            {
                SignStorageFileUrlResponseErrorType5.AuthorizationError => "authorization_error",
                SignStorageFileUrlResponseErrorType5.NotFound => "not_found",
                SignStorageFileUrlResponseErrorType5.NotImplemented => "not_implemented",
                SignStorageFileUrlResponseErrorType5.RateLimited => "rate_limited",
                SignStorageFileUrlResponseErrorType5.ServerError => "server_error",
                SignStorageFileUrlResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignStorageFileUrlResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SignStorageFileUrlResponseErrorType5.AuthorizationError,
                "not_found" => SignStorageFileUrlResponseErrorType5.NotFound,
                "not_implemented" => SignStorageFileUrlResponseErrorType5.NotImplemented,
                "rate_limited" => SignStorageFileUrlResponseErrorType5.RateLimited,
                "server_error" => SignStorageFileUrlResponseErrorType5.ServerError,
                "validation_error" => SignStorageFileUrlResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}