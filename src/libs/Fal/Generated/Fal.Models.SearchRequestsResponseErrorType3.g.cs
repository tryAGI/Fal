
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum SearchRequestsResponseErrorType3
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
    public static class SearchRequestsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestsResponseErrorType3 value)
        {
            return value switch
            {
                SearchRequestsResponseErrorType3.AuthorizationError => "authorization_error",
                SearchRequestsResponseErrorType3.ValidationError => "validation_error",
                SearchRequestsResponseErrorType3.NotFound => "not_found",
                SearchRequestsResponseErrorType3.RateLimited => "rate_limited",
                SearchRequestsResponseErrorType3.ServerError => "server_error",
                SearchRequestsResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => SearchRequestsResponseErrorType3.AuthorizationError,
                "validation_error" => SearchRequestsResponseErrorType3.ValidationError,
                "not_found" => SearchRequestsResponseErrorType3.NotFound,
                "rate_limited" => SearchRequestsResponseErrorType3.RateLimited,
                "server_error" => SearchRequestsResponseErrorType3.ServerError,
                "not_implemented" => SearchRequestsResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}