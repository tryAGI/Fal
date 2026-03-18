
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteComputeInstanceResponseErrorType2
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
    public static class DeleteComputeInstanceResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteComputeInstanceResponseErrorType2 value)
        {
            return value switch
            {
                DeleteComputeInstanceResponseErrorType2.AuthorizationError => "authorization_error",
                DeleteComputeInstanceResponseErrorType2.ValidationError => "validation_error",
                DeleteComputeInstanceResponseErrorType2.NotFound => "not_found",
                DeleteComputeInstanceResponseErrorType2.RateLimited => "rate_limited",
                DeleteComputeInstanceResponseErrorType2.ServerError => "server_error",
                DeleteComputeInstanceResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteComputeInstanceResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteComputeInstanceResponseErrorType2.AuthorizationError,
                "validation_error" => DeleteComputeInstanceResponseErrorType2.ValidationError,
                "not_found" => DeleteComputeInstanceResponseErrorType2.NotFound,
                "rate_limited" => DeleteComputeInstanceResponseErrorType2.RateLimited,
                "server_error" => DeleteComputeInstanceResponseErrorType2.ServerError,
                "not_implemented" => DeleteComputeInstanceResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}