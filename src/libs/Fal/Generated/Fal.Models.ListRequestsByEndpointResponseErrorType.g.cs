
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListRequestsByEndpointResponseErrorType
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
    public static class ListRequestsByEndpointResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRequestsByEndpointResponseErrorType value)
        {
            return value switch
            {
                ListRequestsByEndpointResponseErrorType.AuthorizationError => "authorization_error",
                ListRequestsByEndpointResponseErrorType.ValidationError => "validation_error",
                ListRequestsByEndpointResponseErrorType.NotFound => "not_found",
                ListRequestsByEndpointResponseErrorType.RateLimited => "rate_limited",
                ListRequestsByEndpointResponseErrorType.ServerError => "server_error",
                ListRequestsByEndpointResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRequestsByEndpointResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListRequestsByEndpointResponseErrorType.AuthorizationError,
                "validation_error" => ListRequestsByEndpointResponseErrorType.ValidationError,
                "not_found" => ListRequestsByEndpointResponseErrorType.NotFound,
                "rate_limited" => ListRequestsByEndpointResponseErrorType.RateLimited,
                "server_error" => ListRequestsByEndpointResponseErrorType.ServerError,
                "not_implemented" => ListRequestsByEndpointResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}