
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeInstanceResponseErrorType3
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
    public static class GetComputeInstanceResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseErrorType3 value)
        {
            return value switch
            {
                GetComputeInstanceResponseErrorType3.AuthorizationError => "authorization_error",
                GetComputeInstanceResponseErrorType3.ValidationError => "validation_error",
                GetComputeInstanceResponseErrorType3.NotFound => "not_found",
                GetComputeInstanceResponseErrorType3.RateLimited => "rate_limited",
                GetComputeInstanceResponseErrorType3.ServerError => "server_error",
                GetComputeInstanceResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeInstanceResponseErrorType3.AuthorizationError,
                "validation_error" => GetComputeInstanceResponseErrorType3.ValidationError,
                "not_found" => GetComputeInstanceResponseErrorType3.NotFound,
                "rate_limited" => GetComputeInstanceResponseErrorType3.RateLimited,
                "server_error" => GetComputeInstanceResponseErrorType3.ServerError,
                "not_implemented" => GetComputeInstanceResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}