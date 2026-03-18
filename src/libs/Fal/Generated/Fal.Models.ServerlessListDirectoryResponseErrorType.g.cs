
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListDirectoryResponseErrorType
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
    public static class ServerlessListDirectoryResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListDirectoryResponseErrorType value)
        {
            return value switch
            {
                ServerlessListDirectoryResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessListDirectoryResponseErrorType.ValidationError => "validation_error",
                ServerlessListDirectoryResponseErrorType.NotFound => "not_found",
                ServerlessListDirectoryResponseErrorType.RateLimited => "rate_limited",
                ServerlessListDirectoryResponseErrorType.ServerError => "server_error",
                ServerlessListDirectoryResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListDirectoryResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListDirectoryResponseErrorType.AuthorizationError,
                "validation_error" => ServerlessListDirectoryResponseErrorType.ValidationError,
                "not_found" => ServerlessListDirectoryResponseErrorType.NotFound,
                "rate_limited" => ServerlessListDirectoryResponseErrorType.RateLimited,
                "server_error" => ServerlessListDirectoryResponseErrorType.ServerError,
                "not_implemented" => ServerlessListDirectoryResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}