
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeInstanceResponseErrorType5
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
    public static class GetComputeInstanceResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseErrorType5 value)
        {
            return value switch
            {
                GetComputeInstanceResponseErrorType5.AuthorizationError => "authorization_error",
                GetComputeInstanceResponseErrorType5.ValidationError => "validation_error",
                GetComputeInstanceResponseErrorType5.NotFound => "not_found",
                GetComputeInstanceResponseErrorType5.RateLimited => "rate_limited",
                GetComputeInstanceResponseErrorType5.ServerError => "server_error",
                GetComputeInstanceResponseErrorType5.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeInstanceResponseErrorType5.AuthorizationError,
                "validation_error" => GetComputeInstanceResponseErrorType5.ValidationError,
                "not_found" => GetComputeInstanceResponseErrorType5.NotFound,
                "rate_limited" => GetComputeInstanceResponseErrorType5.RateLimited,
                "server_error" => GetComputeInstanceResponseErrorType5.ServerError,
                "not_implemented" => GetComputeInstanceResponseErrorType5.NotImplemented,
                _ => null,
            };
        }
    }
}