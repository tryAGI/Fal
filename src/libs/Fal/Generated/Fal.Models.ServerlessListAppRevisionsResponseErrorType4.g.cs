
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppRevisionsResponseErrorType4
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
    public static class ServerlessListAppRevisionsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppRevisionsResponseErrorType4 value)
        {
            return value switch
            {
                ServerlessListAppRevisionsResponseErrorType4.AuthorizationError => "authorization_error",
                ServerlessListAppRevisionsResponseErrorType4.NotFound => "not_found",
                ServerlessListAppRevisionsResponseErrorType4.NotImplemented => "not_implemented",
                ServerlessListAppRevisionsResponseErrorType4.RateLimited => "rate_limited",
                ServerlessListAppRevisionsResponseErrorType4.ServerError => "server_error",
                ServerlessListAppRevisionsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppRevisionsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppRevisionsResponseErrorType4.AuthorizationError,
                "not_found" => ServerlessListAppRevisionsResponseErrorType4.NotFound,
                "not_implemented" => ServerlessListAppRevisionsResponseErrorType4.NotImplemented,
                "rate_limited" => ServerlessListAppRevisionsResponseErrorType4.RateLimited,
                "server_error" => ServerlessListAppRevisionsResponseErrorType4.ServerError,
                "validation_error" => ServerlessListAppRevisionsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}