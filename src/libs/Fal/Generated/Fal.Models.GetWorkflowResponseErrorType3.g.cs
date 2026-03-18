
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetWorkflowResponseErrorType3
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
    public static class GetWorkflowResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowResponseErrorType3 value)
        {
            return value switch
            {
                GetWorkflowResponseErrorType3.AuthorizationError => "authorization_error",
                GetWorkflowResponseErrorType3.ValidationError => "validation_error",
                GetWorkflowResponseErrorType3.NotFound => "not_found",
                GetWorkflowResponseErrorType3.RateLimited => "rate_limited",
                GetWorkflowResponseErrorType3.ServerError => "server_error",
                GetWorkflowResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetWorkflowResponseErrorType3.AuthorizationError,
                "validation_error" => GetWorkflowResponseErrorType3.ValidationError,
                "not_found" => GetWorkflowResponseErrorType3.NotFound,
                "rate_limited" => GetWorkflowResponseErrorType3.RateLimited,
                "server_error" => GetWorkflowResponseErrorType3.ServerError,
                "not_implemented" => GetWorkflowResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}