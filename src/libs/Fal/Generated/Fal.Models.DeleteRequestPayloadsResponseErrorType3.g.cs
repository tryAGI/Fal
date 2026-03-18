
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteRequestPayloadsResponseErrorType3
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
    public static class DeleteRequestPayloadsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteRequestPayloadsResponseErrorType3 value)
        {
            return value switch
            {
                DeleteRequestPayloadsResponseErrorType3.AuthorizationError => "authorization_error",
                DeleteRequestPayloadsResponseErrorType3.ValidationError => "validation_error",
                DeleteRequestPayloadsResponseErrorType3.NotFound => "not_found",
                DeleteRequestPayloadsResponseErrorType3.RateLimited => "rate_limited",
                DeleteRequestPayloadsResponseErrorType3.ServerError => "server_error",
                DeleteRequestPayloadsResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteRequestPayloadsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteRequestPayloadsResponseErrorType3.AuthorizationError,
                "validation_error" => DeleteRequestPayloadsResponseErrorType3.ValidationError,
                "not_found" => DeleteRequestPayloadsResponseErrorType3.NotFound,
                "rate_limited" => DeleteRequestPayloadsResponseErrorType3.RateLimited,
                "server_error" => DeleteRequestPayloadsResponseErrorType3.ServerError,
                "not_implemented" => DeleteRequestPayloadsResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}