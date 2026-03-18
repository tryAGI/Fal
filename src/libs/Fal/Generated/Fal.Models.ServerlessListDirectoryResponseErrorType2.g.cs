
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListDirectoryResponseErrorType2
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
    public static class ServerlessListDirectoryResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListDirectoryResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessListDirectoryResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessListDirectoryResponseErrorType2.ValidationError => "validation_error",
                ServerlessListDirectoryResponseErrorType2.NotFound => "not_found",
                ServerlessListDirectoryResponseErrorType2.RateLimited => "rate_limited",
                ServerlessListDirectoryResponseErrorType2.ServerError => "server_error",
                ServerlessListDirectoryResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListDirectoryResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListDirectoryResponseErrorType2.AuthorizationError,
                "validation_error" => ServerlessListDirectoryResponseErrorType2.ValidationError,
                "not_found" => ServerlessListDirectoryResponseErrorType2.NotFound,
                "rate_limited" => ServerlessListDirectoryResponseErrorType2.RateLimited,
                "server_error" => ServerlessListDirectoryResponseErrorType2.ServerError,
                "not_implemented" => ServerlessListDirectoryResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}