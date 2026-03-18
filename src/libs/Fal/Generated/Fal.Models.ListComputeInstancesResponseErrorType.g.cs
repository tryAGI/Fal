
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListComputeInstancesResponseErrorType
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
    public static class ListComputeInstancesResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListComputeInstancesResponseErrorType value)
        {
            return value switch
            {
                ListComputeInstancesResponseErrorType.AuthorizationError => "authorization_error",
                ListComputeInstancesResponseErrorType.ValidationError => "validation_error",
                ListComputeInstancesResponseErrorType.NotFound => "not_found",
                ListComputeInstancesResponseErrorType.RateLimited => "rate_limited",
                ListComputeInstancesResponseErrorType.ServerError => "server_error",
                ListComputeInstancesResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListComputeInstancesResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListComputeInstancesResponseErrorType.AuthorizationError,
                "validation_error" => ListComputeInstancesResponseErrorType.ValidationError,
                "not_found" => ListComputeInstancesResponseErrorType.NotFound,
                "rate_limited" => ListComputeInstancesResponseErrorType.RateLimited,
                "server_error" => ListComputeInstancesResponseErrorType.ServerError,
                "not_implemented" => ListComputeInstancesResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}