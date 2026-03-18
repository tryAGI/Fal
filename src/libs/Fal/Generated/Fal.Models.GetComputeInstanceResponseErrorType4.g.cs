
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeInstanceResponseErrorType4
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
    public static class GetComputeInstanceResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseErrorType4 value)
        {
            return value switch
            {
                GetComputeInstanceResponseErrorType4.AuthorizationError => "authorization_error",
                GetComputeInstanceResponseErrorType4.ValidationError => "validation_error",
                GetComputeInstanceResponseErrorType4.NotFound => "not_found",
                GetComputeInstanceResponseErrorType4.RateLimited => "rate_limited",
                GetComputeInstanceResponseErrorType4.ServerError => "server_error",
                GetComputeInstanceResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeInstanceResponseErrorType4.AuthorizationError,
                "validation_error" => GetComputeInstanceResponseErrorType4.ValidationError,
                "not_found" => GetComputeInstanceResponseErrorType4.NotFound,
                "rate_limited" => GetComputeInstanceResponseErrorType4.RateLimited,
                "server_error" => GetComputeInstanceResponseErrorType4.ServerError,
                "not_implemented" => GetComputeInstanceResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}