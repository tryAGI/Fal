
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetAppQueueInfoResponseErrorType5
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
    public static class ServerlessGetAppQueueInfoResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAppQueueInfoResponseErrorType5 value)
        {
            return value switch
            {
                ServerlessGetAppQueueInfoResponseErrorType5.AuthorizationError => "authorization_error",
                ServerlessGetAppQueueInfoResponseErrorType5.ValidationError => "validation_error",
                ServerlessGetAppQueueInfoResponseErrorType5.NotFound => "not_found",
                ServerlessGetAppQueueInfoResponseErrorType5.RateLimited => "rate_limited",
                ServerlessGetAppQueueInfoResponseErrorType5.ServerError => "server_error",
                ServerlessGetAppQueueInfoResponseErrorType5.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAppQueueInfoResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetAppQueueInfoResponseErrorType5.AuthorizationError,
                "validation_error" => ServerlessGetAppQueueInfoResponseErrorType5.ValidationError,
                "not_found" => ServerlessGetAppQueueInfoResponseErrorType5.NotFound,
                "rate_limited" => ServerlessGetAppQueueInfoResponseErrorType5.RateLimited,
                "server_error" => ServerlessGetAppQueueInfoResponseErrorType5.ServerError,
                "not_implemented" => ServerlessGetAppQueueInfoResponseErrorType5.NotImplemented,
                _ => null,
            };
        }
    }
}