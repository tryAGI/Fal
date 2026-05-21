
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListRequestsByEndpointResponseErrorType6
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
    public static class ListRequestsByEndpointResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRequestsByEndpointResponseErrorType6 value)
        {
            return value switch
            {
                ListRequestsByEndpointResponseErrorType6.AuthorizationError => "authorization_error",
                ListRequestsByEndpointResponseErrorType6.NotFound => "not_found",
                ListRequestsByEndpointResponseErrorType6.NotImplemented => "not_implemented",
                ListRequestsByEndpointResponseErrorType6.RateLimited => "rate_limited",
                ListRequestsByEndpointResponseErrorType6.ServerError => "server_error",
                ListRequestsByEndpointResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRequestsByEndpointResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListRequestsByEndpointResponseErrorType6.AuthorizationError,
                "not_found" => ListRequestsByEndpointResponseErrorType6.NotFound,
                "not_implemented" => ListRequestsByEndpointResponseErrorType6.NotImplemented,
                "rate_limited" => ListRequestsByEndpointResponseErrorType6.RateLimited,
                "server_error" => ListRequestsByEndpointResponseErrorType6.ServerError,
                "validation_error" => ListRequestsByEndpointResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}