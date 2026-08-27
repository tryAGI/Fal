
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessUploadFromUrlResponseErrorType4
    {
        /// <summary>
        ///
        /// </summary>
        AuthorizationError,
        /// <summary>
        ///
        /// </summary>
        NotFound,
        /// <summary>
        ///
        /// </summary>
        NotImplemented,
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
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessUploadFromUrlResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessUploadFromUrlResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessUploadFromUrlResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessUploadFromUrlResponseErrorType4.NotFound => "not_found",
                ServerlessUploadFromUrlResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessUploadFromUrlResponseErrorType4.RateLimited => "rate_limited",
                ServerlessUploadFromUrlResponseErrorType4.ServerError => "server_error",
                ServerlessUploadFromUrlResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessUploadFromUrlResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessUploadFromUrlResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessUploadFromUrlResponseErrorType4.NotFound,
                "not_implemented" => ServerlessUploadFromUrlResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessUploadFromUrlResponseErrorType4.RateLimited,
                "server_error" => ServerlessUploadFromUrlResponseErrorType4.ServerError,
                "validation_error" => ServerlessUploadFromUrlResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}