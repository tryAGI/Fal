
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetComputeInstanceResponseErrorType2
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
    public static class GetComputeInstanceResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseErrorType2 value)
        {
            return value switch
            {
                GetComputeInstanceResponseErrorType2.AuthorizationError => "authorization_error",
                GetComputeInstanceResponseErrorType2.ValidationError => "validation_error",
                GetComputeInstanceResponseErrorType2.NotFound => "not_found",
                GetComputeInstanceResponseErrorType2.RateLimited => "rate_limited",
                GetComputeInstanceResponseErrorType2.ServerError => "server_error",
                GetComputeInstanceResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetComputeInstanceResponseErrorType2.AuthorizationError,
                "validation_error" => GetComputeInstanceResponseErrorType2.ValidationError,
                "not_found" => GetComputeInstanceResponseErrorType2.NotFound,
                "rate_limited" => GetComputeInstanceResponseErrorType2.RateLimited,
                "server_error" => GetComputeInstanceResponseErrorType2.ServerError,
                "not_implemented" => GetComputeInstanceResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}