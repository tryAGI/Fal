
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListComputeInstancesResponseErrorType4
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
    public static class ListComputeInstancesResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListComputeInstancesResponseErrorType4 value)
        {
            return value switch
            {
                ListComputeInstancesResponseErrorType4.AuthorizationError => "authorization_error",
                ListComputeInstancesResponseErrorType4.ValidationError => "validation_error",
                ListComputeInstancesResponseErrorType4.NotFound => "not_found",
                ListComputeInstancesResponseErrorType4.RateLimited => "rate_limited",
                ListComputeInstancesResponseErrorType4.ServerError => "server_error",
                ListComputeInstancesResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListComputeInstancesResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListComputeInstancesResponseErrorType4.AuthorizationError,
                "validation_error" => ListComputeInstancesResponseErrorType4.ValidationError,
                "not_found" => ListComputeInstancesResponseErrorType4.NotFound,
                "rate_limited" => ListComputeInstancesResponseErrorType4.RateLimited,
                "server_error" => ListComputeInstancesResponseErrorType4.ServerError,
                "not_implemented" => ListComputeInstancesResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}