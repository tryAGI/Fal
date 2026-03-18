
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListRootResponseErrorType3
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
    public static class ServerlessListRootResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRootResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessListRootResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessListRootResponseErrorType3.ValidationError => "validation_error",
                ServerlessListRootResponseErrorType3.NotFound => "not_found",
                ServerlessListRootResponseErrorType3.RateLimited => "rate_limited",
                ServerlessListRootResponseErrorType3.ServerError => "server_error",
                ServerlessListRootResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRootResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRootResponseErrorType3.AuthorizationError,
                "validation_error" => ServerlessListRootResponseErrorType3.ValidationError,
                "not_found" => ServerlessListRootResponseErrorType3.NotFound,
                "rate_limited" => ServerlessListRootResponseErrorType3.RateLimited,
                "server_error" => ServerlessListRootResponseErrorType3.ServerError,
                "not_implemented" => ServerlessListRootResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}