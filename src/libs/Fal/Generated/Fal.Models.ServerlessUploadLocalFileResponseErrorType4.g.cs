
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessUploadLocalFileResponseErrorType4
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
    public static class ServerlessUploadLocalFileResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessUploadLocalFileResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessUploadLocalFileResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessUploadLocalFileResponseErrorType4.ValidationError => "validation_error",
                ServerlessUploadLocalFileResponseErrorType4.NotFound => "not_found",
                ServerlessUploadLocalFileResponseErrorType4.RateLimited => "rate_limited",
                ServerlessUploadLocalFileResponseErrorType4.ServerError => "server_error",
                ServerlessUploadLocalFileResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessUploadLocalFileResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessUploadLocalFileResponseErrorType4.AuthorizationError,
                "validation_error" => ServerlessUploadLocalFileResponseErrorType4.ValidationError,
                "not_found" => ServerlessUploadLocalFileResponseErrorType4.NotFound,
                "rate_limited" => ServerlessUploadLocalFileResponseErrorType4.RateLimited,
                "server_error" => ServerlessUploadLocalFileResponseErrorType4.ServerError,
                "not_implemented" => ServerlessUploadLocalFileResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}