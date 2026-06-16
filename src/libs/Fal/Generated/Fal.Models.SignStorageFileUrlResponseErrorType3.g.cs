
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SignStorageFileUrlResponseErrorType3
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
    public static class SignStorageFileUrlResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignStorageFileUrlResponseErrorType3 value)
        {
            return value switch
            {
                SignStorageFileUrlResponseErrorType3.AuthorizationError => "authorization_error",
                SignStorageFileUrlResponseErrorType3.NotFound => "not_found",
                SignStorageFileUrlResponseErrorType3.NotImplemented => "not_implemented",
                SignStorageFileUrlResponseErrorType3.RateLimited => "rate_limited",
                SignStorageFileUrlResponseErrorType3.ServerError => "server_error",
                SignStorageFileUrlResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignStorageFileUrlResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SignStorageFileUrlResponseErrorType3.AuthorizationError,
                "not_found" => SignStorageFileUrlResponseErrorType3.NotFound,
                "not_implemented" => SignStorageFileUrlResponseErrorType3.NotImplemented,
                "rate_limited" => SignStorageFileUrlResponseErrorType3.RateLimited,
                "server_error" => SignStorageFileUrlResponseErrorType3.ServerError,
                "validation_error" => SignStorageFileUrlResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}