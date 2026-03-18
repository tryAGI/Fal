
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateComputeInstanceResponseErrorType4
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
    public static class CreateComputeInstanceResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseErrorType4 value)
        {
            return value switch
            {
                CreateComputeInstanceResponseErrorType4.AuthorizationError => "authorization_error",
                CreateComputeInstanceResponseErrorType4.ValidationError => "validation_error",
                CreateComputeInstanceResponseErrorType4.NotFound => "not_found",
                CreateComputeInstanceResponseErrorType4.RateLimited => "rate_limited",
                CreateComputeInstanceResponseErrorType4.ServerError => "server_error",
                CreateComputeInstanceResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateComputeInstanceResponseErrorType4.AuthorizationError,
                "validation_error" => CreateComputeInstanceResponseErrorType4.ValidationError,
                "not_found" => CreateComputeInstanceResponseErrorType4.NotFound,
                "rate_limited" => CreateComputeInstanceResponseErrorType4.RateLimited,
                "server_error" => CreateComputeInstanceResponseErrorType4.ServerError,
                "not_implemented" => CreateComputeInstanceResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}