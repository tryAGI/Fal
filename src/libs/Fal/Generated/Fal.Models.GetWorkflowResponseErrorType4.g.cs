
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetWorkflowResponseErrorType4
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
    public static class GetWorkflowResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowResponseErrorType4 value)
        {
            return value switch
            {
                GetWorkflowResponseErrorType4.AuthorizationError => "authorization_error",
                GetWorkflowResponseErrorType4.ValidationError => "validation_error",
                GetWorkflowResponseErrorType4.NotFound => "not_found",
                GetWorkflowResponseErrorType4.RateLimited => "rate_limited",
                GetWorkflowResponseErrorType4.ServerError => "server_error",
                GetWorkflowResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetWorkflowResponseErrorType4.AuthorizationError,
                "validation_error" => GetWorkflowResponseErrorType4.ValidationError,
                "not_found" => GetWorkflowResponseErrorType4.NotFound,
                "rate_limited" => GetWorkflowResponseErrorType4.RateLimited,
                "server_error" => GetWorkflowResponseErrorType4.ServerError,
                "not_implemented" => GetWorkflowResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}