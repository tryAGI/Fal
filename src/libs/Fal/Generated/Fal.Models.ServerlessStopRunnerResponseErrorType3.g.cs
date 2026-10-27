
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessStopRunnerResponseErrorType3
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
    public static class ServerlessStopRunnerResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessStopRunnerResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessStopRunnerResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessStopRunnerResponseErrorType3.NotFound => "not_found",
                ServerlessStopRunnerResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessStopRunnerResponseErrorType3.RateLimited => "rate_limited",
                ServerlessStopRunnerResponseErrorType3.ServerError => "server_error",
                ServerlessStopRunnerResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessStopRunnerResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessStopRunnerResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessStopRunnerResponseErrorType3.NotFound,
                "not_implemented" => ServerlessStopRunnerResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessStopRunnerResponseErrorType3.RateLimited,
                "server_error" => ServerlessStopRunnerResponseErrorType3.ServerError,
                "validation_error" => ServerlessStopRunnerResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}