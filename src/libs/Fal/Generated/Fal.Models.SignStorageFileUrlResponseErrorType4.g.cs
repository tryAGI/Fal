
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SignStorageFileUrlResponseErrorType4
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
    public static class SignStorageFileUrlResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignStorageFileUrlResponseErrorType4 value)
        {
            return value switch
            {
                SignStorageFileUrlResponseErrorType4.AuthorizationError => "authorization_error",
                SignStorageFileUrlResponseErrorType4.NotFound => "not_found",
                SignStorageFileUrlResponseErrorType4.NotImplemented => "not_implemented",
                SignStorageFileUrlResponseErrorType4.RateLimited => "rate_limited",
                SignStorageFileUrlResponseErrorType4.ServerError => "server_error",
                SignStorageFileUrlResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignStorageFileUrlResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SignStorageFileUrlResponseErrorType4.AuthorizationError,
                "not_found" => SignStorageFileUrlResponseErrorType4.NotFound,
                "not_implemented" => SignStorageFileUrlResponseErrorType4.NotImplemented,
                "rate_limited" => SignStorageFileUrlResponseErrorType4.RateLimited,
                "server_error" => SignStorageFileUrlResponseErrorType4.ServerError,
                "validation_error" => SignStorageFileUrlResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}