
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessUploadLocalFileResponseErrorType3
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
    public static class ServerlessUploadLocalFileResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessUploadLocalFileResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessUploadLocalFileResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessUploadLocalFileResponseErrorType3.ValidationError => "validation_error",
                ServerlessUploadLocalFileResponseErrorType3.NotFound => "not_found",
                ServerlessUploadLocalFileResponseErrorType3.RateLimited => "rate_limited",
                ServerlessUploadLocalFileResponseErrorType3.ServerError => "server_error",
                ServerlessUploadLocalFileResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessUploadLocalFileResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessUploadLocalFileResponseErrorType3.AuthorizationError,
                "validation_error" => ServerlessUploadLocalFileResponseErrorType3.ValidationError,
                "not_found" => ServerlessUploadLocalFileResponseErrorType3.NotFound,
                "rate_limited" => ServerlessUploadLocalFileResponseErrorType3.RateLimited,
                "server_error" => ServerlessUploadLocalFileResponseErrorType3.ServerError,
                "not_implemented" => ServerlessUploadLocalFileResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}