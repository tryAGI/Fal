
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListRequestsByEndpointResponseErrorType4
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
    public static class ListRequestsByEndpointResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRequestsByEndpointResponseErrorType4 value)
        {
            return value switch
            {
                ListRequestsByEndpointResponseErrorType4.AuthorizationError => "authorization_error",
                ListRequestsByEndpointResponseErrorType4.ValidationError => "validation_error",
                ListRequestsByEndpointResponseErrorType4.NotFound => "not_found",
                ListRequestsByEndpointResponseErrorType4.RateLimited => "rate_limited",
                ListRequestsByEndpointResponseErrorType4.ServerError => "server_error",
                ListRequestsByEndpointResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRequestsByEndpointResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListRequestsByEndpointResponseErrorType4.AuthorizationError,
                "validation_error" => ListRequestsByEndpointResponseErrorType4.ValidationError,
                "not_found" => ListRequestsByEndpointResponseErrorType4.NotFound,
                "rate_limited" => ListRequestsByEndpointResponseErrorType4.RateLimited,
                "server_error" => ListRequestsByEndpointResponseErrorType4.ServerError,
                "not_implemented" => ListRequestsByEndpointResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}