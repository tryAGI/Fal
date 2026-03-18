
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListApiKeysResponseErrorType4
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
    public static class ListApiKeysResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListApiKeysResponseErrorType4 value)
        {
            return value switch
            {
                ListApiKeysResponseErrorType4.AuthorizationError => "authorization_error",
                ListApiKeysResponseErrorType4.ValidationError => "validation_error",
                ListApiKeysResponseErrorType4.NotFound => "not_found",
                ListApiKeysResponseErrorType4.RateLimited => "rate_limited",
                ListApiKeysResponseErrorType4.ServerError => "server_error",
                ListApiKeysResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListApiKeysResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListApiKeysResponseErrorType4.AuthorizationError,
                "validation_error" => ListApiKeysResponseErrorType4.ValidationError,
                "not_found" => ListApiKeysResponseErrorType4.NotFound,
                "rate_limited" => ListApiKeysResponseErrorType4.RateLimited,
                "server_error" => ListApiKeysResponseErrorType4.ServerError,
                "not_implemented" => ListApiKeysResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}