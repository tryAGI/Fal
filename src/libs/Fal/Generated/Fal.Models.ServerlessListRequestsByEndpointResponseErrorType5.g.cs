
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListRequestsByEndpointResponseErrorType5
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
    public static class ServerlessListRequestsByEndpointResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointResponseErrorType5 value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointResponseErrorType5.AuthorizationError => "authorization_error",
                ServerlessListRequestsByEndpointResponseErrorType5.ValidationError => "validation_error",
                ServerlessListRequestsByEndpointResponseErrorType5.NotFound => "not_found",
                ServerlessListRequestsByEndpointResponseErrorType5.RateLimited => "rate_limited",
                ServerlessListRequestsByEndpointResponseErrorType5.ServerError => "server_error",
                ServerlessListRequestsByEndpointResponseErrorType5.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRequestsByEndpointResponseErrorType5.AuthorizationError,
                "validation_error" => ServerlessListRequestsByEndpointResponseErrorType5.ValidationError,
                "not_found" => ServerlessListRequestsByEndpointResponseErrorType5.NotFound,
                "rate_limited" => ServerlessListRequestsByEndpointResponseErrorType5.RateLimited,
                "server_error" => ServerlessListRequestsByEndpointResponseErrorType5.ServerError,
                "not_implemented" => ServerlessListRequestsByEndpointResponseErrorType5.NotImplemented,
                _ => null,
            };
        }
    }
}