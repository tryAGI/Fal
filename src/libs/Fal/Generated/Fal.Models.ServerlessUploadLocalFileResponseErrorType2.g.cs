
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessUploadLocalFileResponseErrorType2
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
    public static class ServerlessUploadLocalFileResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessUploadLocalFileResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessUploadLocalFileResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessUploadLocalFileResponseErrorType2.ValidationError => "validation_error",
                ServerlessUploadLocalFileResponseErrorType2.NotFound => "not_found",
                ServerlessUploadLocalFileResponseErrorType2.RateLimited => "rate_limited",
                ServerlessUploadLocalFileResponseErrorType2.ServerError => "server_error",
                ServerlessUploadLocalFileResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessUploadLocalFileResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessUploadLocalFileResponseErrorType2.AuthorizationError,
                "validation_error" => ServerlessUploadLocalFileResponseErrorType2.ValidationError,
                "not_found" => ServerlessUploadLocalFileResponseErrorType2.NotFound,
                "rate_limited" => ServerlessUploadLocalFileResponseErrorType2.RateLimited,
                "server_error" => ServerlessUploadLocalFileResponseErrorType2.ServerError,
                "not_implemented" => ServerlessUploadLocalFileResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}