
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListRequestsByEndpointResponseErrorType2
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
    public static class ListRequestsByEndpointResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRequestsByEndpointResponseErrorType2 value)
        {
            return value switch
            {
                ListRequestsByEndpointResponseErrorType2.AuthorizationError => "authorization_error",
                ListRequestsByEndpointResponseErrorType2.ValidationError => "validation_error",
                ListRequestsByEndpointResponseErrorType2.NotFound => "not_found",
                ListRequestsByEndpointResponseErrorType2.RateLimited => "rate_limited",
                ListRequestsByEndpointResponseErrorType2.ServerError => "server_error",
                ListRequestsByEndpointResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRequestsByEndpointResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListRequestsByEndpointResponseErrorType2.AuthorizationError,
                "validation_error" => ListRequestsByEndpointResponseErrorType2.ValidationError,
                "not_found" => ListRequestsByEndpointResponseErrorType2.NotFound,
                "rate_limited" => ListRequestsByEndpointResponseErrorType2.RateLimited,
                "server_error" => ListRequestsByEndpointResponseErrorType2.ServerError,
                "not_implemented" => ListRequestsByEndpointResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}