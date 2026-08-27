
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppRevisionsResponseErrorType6
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
    public static class ServerlessListAppRevisionsResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppRevisionsResponseErrorType6 value)
        {
            return value switch
            {
                ServerlessListAppRevisionsResponseErrorType6.AuthorizationError => "authorization_error",
                ServerlessListAppRevisionsResponseErrorType6.NotFound => "not_found",
                ServerlessListAppRevisionsResponseErrorType6.NotImplemented => "not_implemented",
                ServerlessListAppRevisionsResponseErrorType6.RateLimited => "rate_limited",
                ServerlessListAppRevisionsResponseErrorType6.ServerError => "server_error",
                ServerlessListAppRevisionsResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppRevisionsResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppRevisionsResponseErrorType6.AuthorizationError,
                "not_found" => ServerlessListAppRevisionsResponseErrorType6.NotFound,
                "not_implemented" => ServerlessListAppRevisionsResponseErrorType6.NotImplemented,
                "rate_limited" => ServerlessListAppRevisionsResponseErrorType6.RateLimited,
                "server_error" => ServerlessListAppRevisionsResponseErrorType6.ServerError,
                "validation_error" => ServerlessListAppRevisionsResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}