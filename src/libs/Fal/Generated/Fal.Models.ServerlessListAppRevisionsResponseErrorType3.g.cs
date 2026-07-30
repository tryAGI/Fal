
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ServerlessListAppRevisionsResponseErrorType3
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
    public static class ServerlessListAppRevisionsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppRevisionsResponseErrorType3 value)
        {
            return value switch
            {
                ServerlessListAppRevisionsResponseErrorType3.AuthorizationError => "authorization_error",
                ServerlessListAppRevisionsResponseErrorType3.NotFound => "not_found",
                ServerlessListAppRevisionsResponseErrorType3.NotImplemented => "not_implemented",
                ServerlessListAppRevisionsResponseErrorType3.RateLimited => "rate_limited",
                ServerlessListAppRevisionsResponseErrorType3.ServerError => "server_error",
                ServerlessListAppRevisionsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppRevisionsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ServerlessListAppRevisionsResponseErrorType3.AuthorizationError,
                "not_found" => ServerlessListAppRevisionsResponseErrorType3.NotFound,
                "not_implemented" => ServerlessListAppRevisionsResponseErrorType3.NotImplemented,
                "rate_limited" => ServerlessListAppRevisionsResponseErrorType3.RateLimited,
                "server_error" => ServerlessListAppRevisionsResponseErrorType3.ServerError,
                "validation_error" => ServerlessListAppRevisionsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}