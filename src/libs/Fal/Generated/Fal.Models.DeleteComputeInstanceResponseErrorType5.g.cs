
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteComputeInstanceResponseErrorType5
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
    public static class DeleteComputeInstanceResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteComputeInstanceResponseErrorType5 value)
        {
            return value switch
            {
                DeleteComputeInstanceResponseErrorType5.AuthorizationError => "authorization_error",
                DeleteComputeInstanceResponseErrorType5.ValidationError => "validation_error",
                DeleteComputeInstanceResponseErrorType5.NotFound => "not_found",
                DeleteComputeInstanceResponseErrorType5.RateLimited => "rate_limited",
                DeleteComputeInstanceResponseErrorType5.ServerError => "server_error",
                DeleteComputeInstanceResponseErrorType5.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteComputeInstanceResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteComputeInstanceResponseErrorType5.AuthorizationError,
                "validation_error" => DeleteComputeInstanceResponseErrorType5.ValidationError,
                "not_found" => DeleteComputeInstanceResponseErrorType5.NotFound,
                "rate_limited" => DeleteComputeInstanceResponseErrorType5.RateLimited,
                "server_error" => DeleteComputeInstanceResponseErrorType5.ServerError,
                "not_implemented" => DeleteComputeInstanceResponseErrorType5.NotImplemented,
                _ => null,
            };
        }
    }
}