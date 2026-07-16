
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetRunnerHistoryResponseErrorType4
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
    public static class ServerlessGetRunnerHistoryResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetRunnerHistoryResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessGetRunnerHistoryResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessGetRunnerHistoryResponseErrorType4.NotFound => "not_found",
                ServerlessGetRunnerHistoryResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessGetRunnerHistoryResponseErrorType4.RateLimited => "rate_limited",
                ServerlessGetRunnerHistoryResponseErrorType4.ServerError => "server_error",
                ServerlessGetRunnerHistoryResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetRunnerHistoryResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetRunnerHistoryResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessGetRunnerHistoryResponseErrorType4.NotFound,
                "not_implemented" => ServerlessGetRunnerHistoryResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessGetRunnerHistoryResponseErrorType4.RateLimited,
                "server_error" => ServerlessGetRunnerHistoryResponseErrorType4.ServerError,
                "validation_error" => ServerlessGetRunnerHistoryResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}