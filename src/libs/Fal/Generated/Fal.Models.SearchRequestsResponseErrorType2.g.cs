
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SearchRequestsResponseErrorType2
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
    public static class SearchRequestsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestsResponseErrorType2 value)
        {
            return value switch
            {
                SearchRequestsResponseErrorType2.AuthorizationError => "authorization_error",
                SearchRequestsResponseErrorType2.ValidationError => "validation_error",
                SearchRequestsResponseErrorType2.NotFound => "not_found",
                SearchRequestsResponseErrorType2.RateLimited => "rate_limited",
                SearchRequestsResponseErrorType2.ServerError => "server_error",
                SearchRequestsResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SearchRequestsResponseErrorType2.AuthorizationError,
                "validation_error" => SearchRequestsResponseErrorType2.ValidationError,
                "not_found" => SearchRequestsResponseErrorType2.NotFound,
                "rate_limited" => SearchRequestsResponseErrorType2.RateLimited,
                "server_error" => SearchRequestsResponseErrorType2.ServerError,
                "not_implemented" => SearchRequestsResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}