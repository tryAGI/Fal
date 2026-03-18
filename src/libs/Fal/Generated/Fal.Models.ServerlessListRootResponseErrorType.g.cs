
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListRootResponseErrorType
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
    public static class ServerlessListRootResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRootResponseErrorType value)
        {
            return value switch
            {
                ServerlessListRootResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessListRootResponseErrorType.ValidationError => "validation_error",
                ServerlessListRootResponseErrorType.NotFound => "not_found",
                ServerlessListRootResponseErrorType.RateLimited => "rate_limited",
                ServerlessListRootResponseErrorType.ServerError => "server_error",
                ServerlessListRootResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRootResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListRootResponseErrorType.AuthorizationError,
                "validation_error" => ServerlessListRootResponseErrorType.ValidationError,
                "not_found" => ServerlessListRootResponseErrorType.NotFound,
                "rate_limited" => ServerlessListRootResponseErrorType.RateLimited,
                "server_error" => ServerlessListRootResponseErrorType.ServerError,
                "not_implemented" => ServerlessListRootResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}