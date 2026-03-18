
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessDownloadFileResponseErrorType
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
    public static class ServerlessDownloadFileResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessDownloadFileResponseErrorType value)
        {
            return value switch
            {
                ServerlessDownloadFileResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessDownloadFileResponseErrorType.ValidationError => "validation_error",
                ServerlessDownloadFileResponseErrorType.NotFound => "not_found",
                ServerlessDownloadFileResponseErrorType.RateLimited => "rate_limited",
                ServerlessDownloadFileResponseErrorType.ServerError => "server_error",
                ServerlessDownloadFileResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessDownloadFileResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessDownloadFileResponseErrorType.AuthorizationError,
                "validation_error" => ServerlessDownloadFileResponseErrorType.ValidationError,
                "not_found" => ServerlessDownloadFileResponseErrorType.NotFound,
                "rate_limited" => ServerlessDownloadFileResponseErrorType.RateLimited,
                "server_error" => ServerlessDownloadFileResponseErrorType.ServerError,
                "not_implemented" => ServerlessDownloadFileResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}