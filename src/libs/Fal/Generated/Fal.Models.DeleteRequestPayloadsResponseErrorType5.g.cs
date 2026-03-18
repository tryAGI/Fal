
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteRequestPayloadsResponseErrorType5
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
    public static class DeleteRequestPayloadsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteRequestPayloadsResponseErrorType5 value)
        {
            return value switch
            {
                DeleteRequestPayloadsResponseErrorType5.AuthorizationError => "authorization_error",
                DeleteRequestPayloadsResponseErrorType5.ValidationError => "validation_error",
                DeleteRequestPayloadsResponseErrorType5.NotFound => "not_found",
                DeleteRequestPayloadsResponseErrorType5.RateLimited => "rate_limited",
                DeleteRequestPayloadsResponseErrorType5.ServerError => "server_error",
                DeleteRequestPayloadsResponseErrorType5.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteRequestPayloadsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteRequestPayloadsResponseErrorType5.AuthorizationError,
                "validation_error" => DeleteRequestPayloadsResponseErrorType5.ValidationError,
                "not_found" => DeleteRequestPayloadsResponseErrorType5.NotFound,
                "rate_limited" => DeleteRequestPayloadsResponseErrorType5.RateLimited,
                "server_error" => DeleteRequestPayloadsResponseErrorType5.ServerError,
                "not_implemented" => DeleteRequestPayloadsResponseErrorType5.NotImplemented,
                _ => null,
            };
        }
    }
}