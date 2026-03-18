
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListDirectoryResponseErrorType3
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
    public static class ServerlessListDirectoryResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListDirectoryResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessListDirectoryResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessListDirectoryResponseErrorType3.ValidationError => "validation_error",
                ServerlessListDirectoryResponseErrorType3.NotFound => "not_found",
                ServerlessListDirectoryResponseErrorType3.RateLimited => "rate_limited",
                ServerlessListDirectoryResponseErrorType3.ServerError => "server_error",
                ServerlessListDirectoryResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListDirectoryResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListDirectoryResponseErrorType3.AuthorizationError,
                "validation_error" => ServerlessListDirectoryResponseErrorType3.ValidationError,
                "not_found" => ServerlessListDirectoryResponseErrorType3.NotFound,
                "rate_limited" => ServerlessListDirectoryResponseErrorType3.RateLimited,
                "server_error" => ServerlessListDirectoryResponseErrorType3.ServerError,
                "not_implemented" => ServerlessListDirectoryResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}