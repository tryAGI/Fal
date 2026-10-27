
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessStopRunnerResponseErrorType6
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
    public static class ServerlessStopRunnerResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessStopRunnerResponseErrorType6 value)
        {
            return value switch
            {
                ServerlessStopRunnerResponseErrorType6.AuthorizationError => "authorization_error",
                ServerlessStopRunnerResponseErrorType6.NotFound => "not_found",
                ServerlessStopRunnerResponseErrorType6.NotImplemented => "not_implemented",
                ServerlessStopRunnerResponseErrorType6.RateLimited => "rate_limited",
                ServerlessStopRunnerResponseErrorType6.ServerError => "server_error",
                ServerlessStopRunnerResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessStopRunnerResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessStopRunnerResponseErrorType6.AuthorizationError,
                "not_found" => ServerlessStopRunnerResponseErrorType6.NotFound,
                "not_implemented" => ServerlessStopRunnerResponseErrorType6.NotImplemented,
                "rate_limited" => ServerlessStopRunnerResponseErrorType6.RateLimited,
                "server_error" => ServerlessStopRunnerResponseErrorType6.ServerError,
                "validation_error" => ServerlessStopRunnerResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}