
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessStopRunnerResponseErrorType
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
    public static class ServerlessStopRunnerResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessStopRunnerResponseErrorType value)
        {
            return value switch
            {
                ServerlessStopRunnerResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessStopRunnerResponseErrorType.NotFound => "not_found",
                ServerlessStopRunnerResponseErrorType.NotImplemented => "not_implemented",
                ServerlessStopRunnerResponseErrorType.RateLimited => "rate_limited",
                ServerlessStopRunnerResponseErrorType.ServerError => "server_error",
                ServerlessStopRunnerResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessStopRunnerResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessStopRunnerResponseErrorType.AuthorizationError,
                "not_found" => ServerlessStopRunnerResponseErrorType.NotFound,
                "not_implemented" => ServerlessStopRunnerResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessStopRunnerResponseErrorType.RateLimited,
                "server_error" => ServerlessStopRunnerResponseErrorType.ServerError,
                "validation_error" => ServerlessStopRunnerResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}