
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetRunnerHistoryResponseErrorType
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
    public static class ServerlessGetRunnerHistoryResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetRunnerHistoryResponseErrorType value)
        {
            return value switch
            {
                ServerlessGetRunnerHistoryResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessGetRunnerHistoryResponseErrorType.NotFound => "not_found",
                ServerlessGetRunnerHistoryResponseErrorType.NotImplemented => "not_implemented",
                ServerlessGetRunnerHistoryResponseErrorType.RateLimited => "rate_limited",
                ServerlessGetRunnerHistoryResponseErrorType.ServerError => "server_error",
                ServerlessGetRunnerHistoryResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetRunnerHistoryResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetRunnerHistoryResponseErrorType.AuthorizationError,
                "not_found" => ServerlessGetRunnerHistoryResponseErrorType.NotFound,
                "not_implemented" => ServerlessGetRunnerHistoryResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessGetRunnerHistoryResponseErrorType.RateLimited,
                "server_error" => ServerlessGetRunnerHistoryResponseErrorType.ServerError,
                "validation_error" => ServerlessGetRunnerHistoryResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}