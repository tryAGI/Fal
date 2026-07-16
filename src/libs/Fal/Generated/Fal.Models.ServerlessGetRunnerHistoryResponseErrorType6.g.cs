
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetRunnerHistoryResponseErrorType6
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
    public static class ServerlessGetRunnerHistoryResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetRunnerHistoryResponseErrorType6 value)
        {
            return value switch
            {
                ServerlessGetRunnerHistoryResponseErrorType6.AuthorizationError => "authorization_error",
                ServerlessGetRunnerHistoryResponseErrorType6.NotFound => "not_found",
                ServerlessGetRunnerHistoryResponseErrorType6.NotImplemented => "not_implemented",
                ServerlessGetRunnerHistoryResponseErrorType6.RateLimited => "rate_limited",
                ServerlessGetRunnerHistoryResponseErrorType6.ServerError => "server_error",
                ServerlessGetRunnerHistoryResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetRunnerHistoryResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetRunnerHistoryResponseErrorType6.AuthorizationError,
                "not_found" => ServerlessGetRunnerHistoryResponseErrorType6.NotFound,
                "not_implemented" => ServerlessGetRunnerHistoryResponseErrorType6.NotImplemented,
                "rate_limited" => ServerlessGetRunnerHistoryResponseErrorType6.RateLimited,
                "server_error" => ServerlessGetRunnerHistoryResponseErrorType6.ServerError,
                "validation_error" => ServerlessGetRunnerHistoryResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}