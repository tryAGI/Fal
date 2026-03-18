
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetWorkflowResponseErrorType6
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
    public static class GetWorkflowResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowResponseErrorType6 value)
        {
            return value switch
            {
                GetWorkflowResponseErrorType6.AuthorizationError => "authorization_error",
                GetWorkflowResponseErrorType6.ValidationError => "validation_error",
                GetWorkflowResponseErrorType6.NotFound => "not_found",
                GetWorkflowResponseErrorType6.RateLimited => "rate_limited",
                GetWorkflowResponseErrorType6.ServerError => "server_error",
                GetWorkflowResponseErrorType6.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetWorkflowResponseErrorType6.AuthorizationError,
                "validation_error" => GetWorkflowResponseErrorType6.ValidationError,
                "not_found" => GetWorkflowResponseErrorType6.NotFound,
                "rate_limited" => GetWorkflowResponseErrorType6.RateLimited,
                "server_error" => GetWorkflowResponseErrorType6.ServerError,
                "not_implemented" => GetWorkflowResponseErrorType6.NotImplemented,
                _ => null,
            };
        }
    }
}