
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListRequestsByEndpointResponseErrorType3
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
    public static class ServerlessListRequestsByEndpointResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessListRequestsByEndpointResponseErrorType3.ValidationError => "validation_error",
                ServerlessListRequestsByEndpointResponseErrorType3.NotFound => "not_found",
                ServerlessListRequestsByEndpointResponseErrorType3.RateLimited => "rate_limited",
                ServerlessListRequestsByEndpointResponseErrorType3.ServerError => "server_error",
                ServerlessListRequestsByEndpointResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRequestsByEndpointResponseErrorType3.AuthorizationError,
                "validation_error" => ServerlessListRequestsByEndpointResponseErrorType3.ValidationError,
                "not_found" => ServerlessListRequestsByEndpointResponseErrorType3.NotFound,
                "rate_limited" => ServerlessListRequestsByEndpointResponseErrorType3.RateLimited,
                "server_error" => ServerlessListRequestsByEndpointResponseErrorType3.ServerError,
                "not_implemented" => ServerlessListRequestsByEndpointResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}