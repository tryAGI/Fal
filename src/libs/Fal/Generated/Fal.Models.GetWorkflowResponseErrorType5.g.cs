
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetWorkflowResponseErrorType5
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
    public static class GetWorkflowResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowResponseErrorType5 value)
        {
            return value switch
            {
                GetWorkflowResponseErrorType5.AuthorizationError => "authorization_error",
                GetWorkflowResponseErrorType5.ValidationError => "validation_error",
                GetWorkflowResponseErrorType5.NotFound => "not_found",
                GetWorkflowResponseErrorType5.RateLimited => "rate_limited",
                GetWorkflowResponseErrorType5.ServerError => "server_error",
                GetWorkflowResponseErrorType5.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetWorkflowResponseErrorType5.AuthorizationError,
                "validation_error" => GetWorkflowResponseErrorType5.ValidationError,
                "not_found" => GetWorkflowResponseErrorType5.NotFound,
                "rate_limited" => GetWorkflowResponseErrorType5.RateLimited,
                "server_error" => GetWorkflowResponseErrorType5.ServerError,
                "not_implemented" => GetWorkflowResponseErrorType5.NotImplemented,
                _ => null,
            };
        }
    }
}