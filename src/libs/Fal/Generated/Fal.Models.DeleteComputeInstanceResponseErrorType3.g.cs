
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteComputeInstanceResponseErrorType3
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
    public static class DeleteComputeInstanceResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteComputeInstanceResponseErrorType3 value)
        {
            return value switch
            {
                DeleteComputeInstanceResponseErrorType3.AuthorizationError => "authorization_error",
                DeleteComputeInstanceResponseErrorType3.ValidationError => "validation_error",
                DeleteComputeInstanceResponseErrorType3.NotFound => "not_found",
                DeleteComputeInstanceResponseErrorType3.RateLimited => "rate_limited",
                DeleteComputeInstanceResponseErrorType3.ServerError => "server_error",
                DeleteComputeInstanceResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteComputeInstanceResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteComputeInstanceResponseErrorType3.AuthorizationError,
                "validation_error" => DeleteComputeInstanceResponseErrorType3.ValidationError,
                "not_found" => DeleteComputeInstanceResponseErrorType3.NotFound,
                "rate_limited" => DeleteComputeInstanceResponseErrorType3.RateLimited,
                "server_error" => DeleteComputeInstanceResponseErrorType3.ServerError,
                "not_implemented" => DeleteComputeInstanceResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}