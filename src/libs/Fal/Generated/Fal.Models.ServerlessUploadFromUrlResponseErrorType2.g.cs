
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessUploadFromUrlResponseErrorType2
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
    public static class ServerlessUploadFromUrlResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessUploadFromUrlResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessUploadFromUrlResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessUploadFromUrlResponseErrorType2.ValidationError => "validation_error",
                ServerlessUploadFromUrlResponseErrorType2.NotFound => "not_found",
                ServerlessUploadFromUrlResponseErrorType2.RateLimited => "rate_limited",
                ServerlessUploadFromUrlResponseErrorType2.ServerError => "server_error",
                ServerlessUploadFromUrlResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessUploadFromUrlResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessUploadFromUrlResponseErrorType2.AuthorizationError,
                "validation_error" => ServerlessUploadFromUrlResponseErrorType2.ValidationError,
                "not_found" => ServerlessUploadFromUrlResponseErrorType2.NotFound,
                "rate_limited" => ServerlessUploadFromUrlResponseErrorType2.RateLimited,
                "server_error" => ServerlessUploadFromUrlResponseErrorType2.ServerError,
                "not_implemented" => ServerlessUploadFromUrlResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}