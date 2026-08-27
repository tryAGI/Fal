
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppRevisionsResponseErrorType5
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
    public static class ServerlessListAppRevisionsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppRevisionsResponseErrorType5 value)
        {
            return value switch
            {
                ServerlessListAppRevisionsResponseErrorType5.AuthorizationError => "authorization_error",
                ServerlessListAppRevisionsResponseErrorType5.NotFound => "not_found",
                ServerlessListAppRevisionsResponseErrorType5.NotImplemented => "not_implemented",
                ServerlessListAppRevisionsResponseErrorType5.RateLimited => "rate_limited",
                ServerlessListAppRevisionsResponseErrorType5.ServerError => "server_error",
                ServerlessListAppRevisionsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppRevisionsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppRevisionsResponseErrorType5.AuthorizationError,
                "not_found" => ServerlessListAppRevisionsResponseErrorType5.NotFound,
                "not_implemented" => ServerlessListAppRevisionsResponseErrorType5.NotImplemented,
                "rate_limited" => ServerlessListAppRevisionsResponseErrorType5.RateLimited,
                "server_error" => ServerlessListAppRevisionsResponseErrorType5.ServerError,
                "validation_error" => ServerlessListAppRevisionsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}