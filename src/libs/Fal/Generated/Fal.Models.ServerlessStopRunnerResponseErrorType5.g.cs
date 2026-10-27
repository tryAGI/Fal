
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessStopRunnerResponseErrorType5
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
    public static class ServerlessStopRunnerResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessStopRunnerResponseErrorType5 value)
        {
            return value switch
            {
                ServerlessStopRunnerResponseErrorType5.AuthorizationError => "authorization_error",
                ServerlessStopRunnerResponseErrorType5.NotFound => "not_found",
                ServerlessStopRunnerResponseErrorType5.NotImplemented => "not_implemented",
                ServerlessStopRunnerResponseErrorType5.RateLimited => "rate_limited",
                ServerlessStopRunnerResponseErrorType5.ServerError => "server_error",
                ServerlessStopRunnerResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessStopRunnerResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessStopRunnerResponseErrorType5.AuthorizationError,
                "not_found" => ServerlessStopRunnerResponseErrorType5.NotFound,
                "not_implemented" => ServerlessStopRunnerResponseErrorType5.NotImplemented,
                "rate_limited" => ServerlessStopRunnerResponseErrorType5.RateLimited,
                "server_error" => ServerlessStopRunnerResponseErrorType5.ServerError,
                "validation_error" => ServerlessStopRunnerResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}