
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeInstanceResponseErrorType
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
    public static class GetComputeInstanceResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseErrorType value)
        {
            return value switch
            {
                GetComputeInstanceResponseErrorType.AuthorizationError => "authorization_error",
                GetComputeInstanceResponseErrorType.ValidationError => "validation_error",
                GetComputeInstanceResponseErrorType.NotFound => "not_found",
                GetComputeInstanceResponseErrorType.RateLimited => "rate_limited",
                GetComputeInstanceResponseErrorType.ServerError => "server_error",
                GetComputeInstanceResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeInstanceResponseErrorType.AuthorizationError,
                "validation_error" => GetComputeInstanceResponseErrorType.ValidationError,
                "not_found" => GetComputeInstanceResponseErrorType.NotFound,
                "rate_limited" => GetComputeInstanceResponseErrorType.RateLimited,
                "server_error" => GetComputeInstanceResponseErrorType.ServerError,
                "not_implemented" => GetComputeInstanceResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}