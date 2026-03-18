
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteComputeInstanceResponseErrorType4
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
    public static class DeleteComputeInstanceResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteComputeInstanceResponseErrorType4 value)
        {
            return value switch
            {
                DeleteComputeInstanceResponseErrorType4.AuthorizationError => "authorization_error",
                DeleteComputeInstanceResponseErrorType4.ValidationError => "validation_error",
                DeleteComputeInstanceResponseErrorType4.NotFound => "not_found",
                DeleteComputeInstanceResponseErrorType4.RateLimited => "rate_limited",
                DeleteComputeInstanceResponseErrorType4.ServerError => "server_error",
                DeleteComputeInstanceResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteComputeInstanceResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteComputeInstanceResponseErrorType4.AuthorizationError,
                "validation_error" => DeleteComputeInstanceResponseErrorType4.ValidationError,
                "not_found" => DeleteComputeInstanceResponseErrorType4.NotFound,
                "rate_limited" => DeleteComputeInstanceResponseErrorType4.RateLimited,
                "server_error" => DeleteComputeInstanceResponseErrorType4.ServerError,
                "not_implemented" => DeleteComputeInstanceResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}