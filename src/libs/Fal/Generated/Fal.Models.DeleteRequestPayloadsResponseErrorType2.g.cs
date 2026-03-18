
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteRequestPayloadsResponseErrorType2
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
    public static class DeleteRequestPayloadsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteRequestPayloadsResponseErrorType2 value)
        {
            return value switch
            {
                DeleteRequestPayloadsResponseErrorType2.AuthorizationError => "authorization_error",
                DeleteRequestPayloadsResponseErrorType2.ValidationError => "validation_error",
                DeleteRequestPayloadsResponseErrorType2.NotFound => "not_found",
                DeleteRequestPayloadsResponseErrorType2.RateLimited => "rate_limited",
                DeleteRequestPayloadsResponseErrorType2.ServerError => "server_error",
                DeleteRequestPayloadsResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteRequestPayloadsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteRequestPayloadsResponseErrorType2.AuthorizationError,
                "validation_error" => DeleteRequestPayloadsResponseErrorType2.ValidationError,
                "not_found" => DeleteRequestPayloadsResponseErrorType2.NotFound,
                "rate_limited" => DeleteRequestPayloadsResponseErrorType2.RateLimited,
                "server_error" => DeleteRequestPayloadsResponseErrorType2.ServerError,
                "not_implemented" => DeleteRequestPayloadsResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}