
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessGetAppQueueInfoResponseErrorType
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
    public static class ServerlessGetAppQueueInfoResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessGetAppQueueInfoResponseErrorType value)
        {
            return value switch
            {
                ServerlessGetAppQueueInfoResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessGetAppQueueInfoResponseErrorType.ValidationError => "validation_error",
                ServerlessGetAppQueueInfoResponseErrorType.NotFound => "not_found",
                ServerlessGetAppQueueInfoResponseErrorType.RateLimited => "rate_limited",
                ServerlessGetAppQueueInfoResponseErrorType.ServerError => "server_error",
                ServerlessGetAppQueueInfoResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessGetAppQueueInfoResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessGetAppQueueInfoResponseErrorType.AuthorizationError,
                "validation_error" => ServerlessGetAppQueueInfoResponseErrorType.ValidationError,
                "not_found" => ServerlessGetAppQueueInfoResponseErrorType.NotFound,
                "rate_limited" => ServerlessGetAppQueueInfoResponseErrorType.RateLimited,
                "server_error" => ServerlessGetAppQueueInfoResponseErrorType.ServerError,
                "not_implemented" => ServerlessGetAppQueueInfoResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}