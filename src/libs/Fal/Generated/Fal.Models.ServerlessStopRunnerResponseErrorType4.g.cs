
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessStopRunnerResponseErrorType4
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
    public static class ServerlessStopRunnerResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessStopRunnerResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessStopRunnerResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessStopRunnerResponseErrorType4.NotFound => "not_found",
                ServerlessStopRunnerResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessStopRunnerResponseErrorType4.RateLimited => "rate_limited",
                ServerlessStopRunnerResponseErrorType4.ServerError => "server_error",
                ServerlessStopRunnerResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessStopRunnerResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessStopRunnerResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessStopRunnerResponseErrorType4.NotFound,
                "not_implemented" => ServerlessStopRunnerResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessStopRunnerResponseErrorType4.RateLimited,
                "server_error" => ServerlessStopRunnerResponseErrorType4.ServerError,
                "validation_error" => ServerlessStopRunnerResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}