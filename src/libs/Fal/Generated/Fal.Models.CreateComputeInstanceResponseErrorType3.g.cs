
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateComputeInstanceResponseErrorType3
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
    public static class CreateComputeInstanceResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseErrorType3 value)
        {
            return value switch
            {
                CreateComputeInstanceResponseErrorType3.AuthorizationError => "authorization_error",
                CreateComputeInstanceResponseErrorType3.ValidationError => "validation_error",
                CreateComputeInstanceResponseErrorType3.NotFound => "not_found",
                CreateComputeInstanceResponseErrorType3.RateLimited => "rate_limited",
                CreateComputeInstanceResponseErrorType3.ServerError => "server_error",
                CreateComputeInstanceResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateComputeInstanceResponseErrorType3.AuthorizationError,
                "validation_error" => CreateComputeInstanceResponseErrorType3.ValidationError,
                "not_found" => CreateComputeInstanceResponseErrorType3.NotFound,
                "rate_limited" => CreateComputeInstanceResponseErrorType3.RateLimited,
                "server_error" => CreateComputeInstanceResponseErrorType3.ServerError,
                "not_implemented" => CreateComputeInstanceResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}