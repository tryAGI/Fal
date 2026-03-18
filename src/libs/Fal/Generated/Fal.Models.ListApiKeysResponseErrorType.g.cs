
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListApiKeysResponseErrorType
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
    public static class ListApiKeysResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListApiKeysResponseErrorType value)
        {
            return value switch
            {
                ListApiKeysResponseErrorType.AuthorizationError => "authorization_error",
                ListApiKeysResponseErrorType.ValidationError => "validation_error",
                ListApiKeysResponseErrorType.NotFound => "not_found",
                ListApiKeysResponseErrorType.RateLimited => "rate_limited",
                ListApiKeysResponseErrorType.ServerError => "server_error",
                ListApiKeysResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListApiKeysResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListApiKeysResponseErrorType.AuthorizationError,
                "validation_error" => ListApiKeysResponseErrorType.ValidationError,
                "not_found" => ListApiKeysResponseErrorType.NotFound,
                "rate_limited" => ListApiKeysResponseErrorType.RateLimited,
                "server_error" => ListApiKeysResponseErrorType.ServerError,
                "not_implemented" => ListApiKeysResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}