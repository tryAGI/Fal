
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetRunnerHistoryResponseErrorType2
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
    public static class ServerlessGetRunnerHistoryResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetRunnerHistoryResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessGetRunnerHistoryResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessGetRunnerHistoryResponseErrorType2.NotFound => "not_found",
                ServerlessGetRunnerHistoryResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessGetRunnerHistoryResponseErrorType2.RateLimited => "rate_limited",
                ServerlessGetRunnerHistoryResponseErrorType2.ServerError => "server_error",
                ServerlessGetRunnerHistoryResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetRunnerHistoryResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetRunnerHistoryResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessGetRunnerHistoryResponseErrorType2.NotFound,
                "not_implemented" => ServerlessGetRunnerHistoryResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessGetRunnerHistoryResponseErrorType2.RateLimited,
                "server_error" => ServerlessGetRunnerHistoryResponseErrorType2.ServerError,
                "validation_error" => ServerlessGetRunnerHistoryResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}