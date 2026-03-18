
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetWorkflowResponseErrorType
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
    public static class GetWorkflowResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowResponseErrorType value)
        {
            return value switch
            {
                GetWorkflowResponseErrorType.AuthorizationError => "authorization_error",
                GetWorkflowResponseErrorType.ValidationError => "validation_error",
                GetWorkflowResponseErrorType.NotFound => "not_found",
                GetWorkflowResponseErrorType.RateLimited => "rate_limited",
                GetWorkflowResponseErrorType.ServerError => "server_error",
                GetWorkflowResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetWorkflowResponseErrorType.AuthorizationError,
                "validation_error" => GetWorkflowResponseErrorType.ValidationError,
                "not_found" => GetWorkflowResponseErrorType.NotFound,
                "rate_limited" => GetWorkflowResponseErrorType.RateLimited,
                "server_error" => GetWorkflowResponseErrorType.ServerError,
                "not_implemented" => GetWorkflowResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}