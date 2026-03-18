
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateComputeInstanceResponseErrorType5
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
    public static class CreateComputeInstanceResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseErrorType5 value)
        {
            return value switch
            {
                CreateComputeInstanceResponseErrorType5.AuthorizationError => "authorization_error",
                CreateComputeInstanceResponseErrorType5.ValidationError => "validation_error",
                CreateComputeInstanceResponseErrorType5.NotFound => "not_found",
                CreateComputeInstanceResponseErrorType5.RateLimited => "rate_limited",
                CreateComputeInstanceResponseErrorType5.ServerError => "server_error",
                CreateComputeInstanceResponseErrorType5.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateComputeInstanceResponseErrorType5.AuthorizationError,
                "validation_error" => CreateComputeInstanceResponseErrorType5.ValidationError,
                "not_found" => CreateComputeInstanceResponseErrorType5.NotFound,
                "rate_limited" => CreateComputeInstanceResponseErrorType5.RateLimited,
                "server_error" => CreateComputeInstanceResponseErrorType5.ServerError,
                "not_implemented" => CreateComputeInstanceResponseErrorType5.NotImplemented,
                _ => null,
            };
        }
    }
}