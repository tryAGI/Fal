
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateComputeInstanceResponseErrorType
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
    public static class CreateComputeInstanceResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseErrorType value)
        {
            return value switch
            {
                CreateComputeInstanceResponseErrorType.AuthorizationError => "authorization_error",
                CreateComputeInstanceResponseErrorType.ValidationError => "validation_error",
                CreateComputeInstanceResponseErrorType.NotFound => "not_found",
                CreateComputeInstanceResponseErrorType.RateLimited => "rate_limited",
                CreateComputeInstanceResponseErrorType.ServerError => "server_error",
                CreateComputeInstanceResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateComputeInstanceResponseErrorType.AuthorizationError,
                "validation_error" => CreateComputeInstanceResponseErrorType.ValidationError,
                "not_found" => CreateComputeInstanceResponseErrorType.NotFound,
                "rate_limited" => CreateComputeInstanceResponseErrorType.RateLimited,
                "server_error" => CreateComputeInstanceResponseErrorType.ServerError,
                "not_implemented" => CreateComputeInstanceResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}