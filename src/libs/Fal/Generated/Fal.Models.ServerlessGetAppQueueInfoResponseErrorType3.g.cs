
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetAppQueueInfoResponseErrorType3
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        ValidationError,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
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
        NotImplemented,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessGetAppQueueInfoResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAppQueueInfoResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessGetAppQueueInfoResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessGetAppQueueInfoResponseErrorType3.ValidationError => "validation_error",
                ServerlessGetAppQueueInfoResponseErrorType3.NotFound => "not_found",
                ServerlessGetAppQueueInfoResponseErrorType3.RateLimited => "rate_limited",
                ServerlessGetAppQueueInfoResponseErrorType3.ServerError => "server_error",
                ServerlessGetAppQueueInfoResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAppQueueInfoResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetAppQueueInfoResponseErrorType3.AuthorizationError,
                "validation_error" => ServerlessGetAppQueueInfoResponseErrorType3.ValidationError,
                "not_found" => ServerlessGetAppQueueInfoResponseErrorType3.NotFound,
                "rate_limited" => ServerlessGetAppQueueInfoResponseErrorType3.RateLimited,
                "server_error" => ServerlessGetAppQueueInfoResponseErrorType3.ServerError,
                "not_implemented" => ServerlessGetAppQueueInfoResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}