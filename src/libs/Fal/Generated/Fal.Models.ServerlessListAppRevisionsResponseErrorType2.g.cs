
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppRevisionsResponseErrorType2
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
    public static class ServerlessListAppRevisionsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppRevisionsResponseErrorType2 value)
        {
            return value switch
            {
                ServerlessListAppRevisionsResponseErrorType2.AuthorizationError => "authorization_error",
                ServerlessListAppRevisionsResponseErrorType2.NotFound => "not_found",
                ServerlessListAppRevisionsResponseErrorType2.NotImplemented => "not_implemented",
                ServerlessListAppRevisionsResponseErrorType2.RateLimited => "rate_limited",
                ServerlessListAppRevisionsResponseErrorType2.ServerError => "server_error",
                ServerlessListAppRevisionsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppRevisionsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppRevisionsResponseErrorType2.AuthorizationError,
                "not_found" => ServerlessListAppRevisionsResponseErrorType2.NotFound,
                "not_implemented" => ServerlessListAppRevisionsResponseErrorType2.NotImplemented,
                "rate_limited" => ServerlessListAppRevisionsResponseErrorType2.RateLimited,
                "server_error" => ServerlessListAppRevisionsResponseErrorType2.ServerError,
                "validation_error" => ServerlessListAppRevisionsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}