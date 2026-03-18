
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessDownloadFileResponseErrorType4
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
    public static class ServerlessDownloadFileResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessDownloadFileResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessDownloadFileResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessDownloadFileResponseErrorType4.ValidationError => "validation_error",
                ServerlessDownloadFileResponseErrorType4.NotFound => "not_found",
                ServerlessDownloadFileResponseErrorType4.RateLimited => "rate_limited",
                ServerlessDownloadFileResponseErrorType4.ServerError => "server_error",
                ServerlessDownloadFileResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessDownloadFileResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessDownloadFileResponseErrorType4.AuthorizationError,
                "validation_error" => ServerlessDownloadFileResponseErrorType4.ValidationError,
                "not_found" => ServerlessDownloadFileResponseErrorType4.NotFound,
                "rate_limited" => ServerlessDownloadFileResponseErrorType4.RateLimited,
                "server_error" => ServerlessDownloadFileResponseErrorType4.ServerError,
                "not_implemented" => ServerlessDownloadFileResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}