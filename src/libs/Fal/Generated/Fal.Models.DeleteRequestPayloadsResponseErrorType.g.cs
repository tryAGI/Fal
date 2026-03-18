
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteRequestPayloadsResponseErrorType
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
    public static class DeleteRequestPayloadsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteRequestPayloadsResponseErrorType value)
        {
            return value switch
            {
                DeleteRequestPayloadsResponseErrorType.AuthorizationError => "authorization_error",
                DeleteRequestPayloadsResponseErrorType.ValidationError => "validation_error",
                DeleteRequestPayloadsResponseErrorType.NotFound => "not_found",
                DeleteRequestPayloadsResponseErrorType.RateLimited => "rate_limited",
                DeleteRequestPayloadsResponseErrorType.ServerError => "server_error",
                DeleteRequestPayloadsResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteRequestPayloadsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteRequestPayloadsResponseErrorType.AuthorizationError,
                "validation_error" => DeleteRequestPayloadsResponseErrorType.ValidationError,
                "not_found" => DeleteRequestPayloadsResponseErrorType.NotFound,
                "rate_limited" => DeleteRequestPayloadsResponseErrorType.RateLimited,
                "server_error" => DeleteRequestPayloadsResponseErrorType.ServerError,
                "not_implemented" => DeleteRequestPayloadsResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}