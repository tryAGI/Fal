
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListComputeInstancesResponseErrorType3
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
    public static class ListComputeInstancesResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListComputeInstancesResponseErrorType3 value)
        {
            return value switch
            {
                ListComputeInstancesResponseErrorType3.AuthorizationError => "authorization_error",
                ListComputeInstancesResponseErrorType3.ValidationError => "validation_error",
                ListComputeInstancesResponseErrorType3.NotFound => "not_found",
                ListComputeInstancesResponseErrorType3.RateLimited => "rate_limited",
                ListComputeInstancesResponseErrorType3.ServerError => "server_error",
                ListComputeInstancesResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListComputeInstancesResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListComputeInstancesResponseErrorType3.AuthorizationError,
                "validation_error" => ListComputeInstancesResponseErrorType3.ValidationError,
                "not_found" => ListComputeInstancesResponseErrorType3.NotFound,
                "rate_limited" => ListComputeInstancesResponseErrorType3.RateLimited,
                "server_error" => ListComputeInstancesResponseErrorType3.ServerError,
                "not_implemented" => ListComputeInstancesResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}