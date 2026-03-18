
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteRequestPayloadsResponseErrorType4
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
    public static class DeleteRequestPayloadsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteRequestPayloadsResponseErrorType4 value)
        {
            return value switch
            {
                DeleteRequestPayloadsResponseErrorType4.AuthorizationError => "authorization_error",
                DeleteRequestPayloadsResponseErrorType4.ValidationError => "validation_error",
                DeleteRequestPayloadsResponseErrorType4.NotFound => "not_found",
                DeleteRequestPayloadsResponseErrorType4.RateLimited => "rate_limited",
                DeleteRequestPayloadsResponseErrorType4.ServerError => "server_error",
                DeleteRequestPayloadsResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteRequestPayloadsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteRequestPayloadsResponseErrorType4.AuthorizationError,
                "validation_error" => DeleteRequestPayloadsResponseErrorType4.ValidationError,
                "not_found" => DeleteRequestPayloadsResponseErrorType4.NotFound,
                "rate_limited" => DeleteRequestPayloadsResponseErrorType4.RateLimited,
                "server_error" => DeleteRequestPayloadsResponseErrorType4.ServerError,
                "not_implemented" => DeleteRequestPayloadsResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}