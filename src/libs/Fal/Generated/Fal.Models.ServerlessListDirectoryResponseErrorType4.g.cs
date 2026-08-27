
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListDirectoryResponseErrorType4
    {
        /// <summary>
        ///
        /// </summary>
        AuthorizationError,
        /// <summary>
        ///
        /// </summary>
        NotFound,
        /// <summary>
        ///
        /// </summary>
        NotImplemented,
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
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessListDirectoryResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListDirectoryResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessListDirectoryResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessListDirectoryResponseErrorType4.NotFound => "not_found",
                ServerlessListDirectoryResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessListDirectoryResponseErrorType4.RateLimited => "rate_limited",
                ServerlessListDirectoryResponseErrorType4.ServerError => "server_error",
                ServerlessListDirectoryResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListDirectoryResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListDirectoryResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessListDirectoryResponseErrorType4.NotFound,
                "not_implemented" => ServerlessListDirectoryResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessListDirectoryResponseErrorType4.RateLimited,
                "server_error" => ServerlessListDirectoryResponseErrorType4.ServerError,
                "validation_error" => ServerlessListDirectoryResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}