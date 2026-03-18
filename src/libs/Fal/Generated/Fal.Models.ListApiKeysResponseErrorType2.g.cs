
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListApiKeysResponseErrorType2
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
    public static class ListApiKeysResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListApiKeysResponseErrorType2 value)
        {
            return value switch
            {
                ListApiKeysResponseErrorType2.AuthorizationError => "authorization_error",
                ListApiKeysResponseErrorType2.ValidationError => "validation_error",
                ListApiKeysResponseErrorType2.NotFound => "not_found",
                ListApiKeysResponseErrorType2.RateLimited => "rate_limited",
                ListApiKeysResponseErrorType2.ServerError => "server_error",
                ListApiKeysResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListApiKeysResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListApiKeysResponseErrorType2.AuthorizationError,
                "validation_error" => ListApiKeysResponseErrorType2.ValidationError,
                "not_found" => ListApiKeysResponseErrorType2.NotFound,
                "rate_limited" => ListApiKeysResponseErrorType2.RateLimited,
                "server_error" => ListApiKeysResponseErrorType2.ServerError,
                "not_implemented" => ListApiKeysResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}