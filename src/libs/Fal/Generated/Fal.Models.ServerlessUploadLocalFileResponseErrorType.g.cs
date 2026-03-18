
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessUploadLocalFileResponseErrorType
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
    public static class ServerlessUploadLocalFileResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessUploadLocalFileResponseErrorType value)
        {
            return value switch
            {
                ServerlessUploadLocalFileResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessUploadLocalFileResponseErrorType.ValidationError => "validation_error",
                ServerlessUploadLocalFileResponseErrorType.NotFound => "not_found",
                ServerlessUploadLocalFileResponseErrorType.RateLimited => "rate_limited",
                ServerlessUploadLocalFileResponseErrorType.ServerError => "server_error",
                ServerlessUploadLocalFileResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessUploadLocalFileResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessUploadLocalFileResponseErrorType.AuthorizationError,
                "validation_error" => ServerlessUploadLocalFileResponseErrorType.ValidationError,
                "not_found" => ServerlessUploadLocalFileResponseErrorType.NotFound,
                "rate_limited" => ServerlessUploadLocalFileResponseErrorType.RateLimited,
                "server_error" => ServerlessUploadLocalFileResponseErrorType.ServerError,
                "not_implemented" => ServerlessUploadLocalFileResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}