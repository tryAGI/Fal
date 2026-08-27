
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppRevisionsResponseErrorType
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
    public static class ServerlessListAppRevisionsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppRevisionsResponseErrorType value)
        {
            return value switch
            {
                ServerlessListAppRevisionsResponseErrorType.AuthorizationError => "authorization_error",
                ServerlessListAppRevisionsResponseErrorType.NotFound => "not_found",
                ServerlessListAppRevisionsResponseErrorType.NotImplemented => "not_implemented",
                ServerlessListAppRevisionsResponseErrorType.RateLimited => "rate_limited",
                ServerlessListAppRevisionsResponseErrorType.ServerError => "server_error",
                ServerlessListAppRevisionsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppRevisionsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppRevisionsResponseErrorType.AuthorizationError,
                "not_found" => ServerlessListAppRevisionsResponseErrorType.NotFound,
                "not_implemented" => ServerlessListAppRevisionsResponseErrorType.NotImplemented,
                "rate_limited" => ServerlessListAppRevisionsResponseErrorType.RateLimited,
                "server_error" => ServerlessListAppRevisionsResponseErrorType.ServerError,
                "validation_error" => ServerlessListAppRevisionsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}