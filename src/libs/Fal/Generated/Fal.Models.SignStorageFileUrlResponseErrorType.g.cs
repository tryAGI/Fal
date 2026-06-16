
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SignStorageFileUrlResponseErrorType
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
    public static class SignStorageFileUrlResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignStorageFileUrlResponseErrorType value)
        {
            return value switch
            {
                SignStorageFileUrlResponseErrorType.AuthorizationError => "authorization_error",
                SignStorageFileUrlResponseErrorType.NotFound => "not_found",
                SignStorageFileUrlResponseErrorType.NotImplemented => "not_implemented",
                SignStorageFileUrlResponseErrorType.RateLimited => "rate_limited",
                SignStorageFileUrlResponseErrorType.ServerError => "server_error",
                SignStorageFileUrlResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignStorageFileUrlResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SignStorageFileUrlResponseErrorType.AuthorizationError,
                "not_found" => SignStorageFileUrlResponseErrorType.NotFound,
                "not_implemented" => SignStorageFileUrlResponseErrorType.NotImplemented,
                "rate_limited" => SignStorageFileUrlResponseErrorType.RateLimited,
                "server_error" => SignStorageFileUrlResponseErrorType.ServerError,
                "validation_error" => SignStorageFileUrlResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}