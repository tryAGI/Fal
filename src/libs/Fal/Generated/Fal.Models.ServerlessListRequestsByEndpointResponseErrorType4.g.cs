
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListRequestsByEndpointResponseErrorType4
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
    public static class ServerlessListRequestsByEndpointResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessListRequestsByEndpointResponseErrorType4.ValidationError => "validation_error",
                ServerlessListRequestsByEndpointResponseErrorType4.NotFound => "not_found",
                ServerlessListRequestsByEndpointResponseErrorType4.RateLimited => "rate_limited",
                ServerlessListRequestsByEndpointResponseErrorType4.ServerError => "server_error",
                ServerlessListRequestsByEndpointResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRequestsByEndpointResponseErrorType4.AuthorizationError,
                "validation_error" => ServerlessListRequestsByEndpointResponseErrorType4.ValidationError,
                "not_found" => ServerlessListRequestsByEndpointResponseErrorType4.NotFound,
                "rate_limited" => ServerlessListRequestsByEndpointResponseErrorType4.RateLimited,
                "server_error" => ServerlessListRequestsByEndpointResponseErrorType4.ServerError,
                "not_implemented" => ServerlessListRequestsByEndpointResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}