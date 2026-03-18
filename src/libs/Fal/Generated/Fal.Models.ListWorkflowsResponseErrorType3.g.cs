
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListWorkflowsResponseErrorType3
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
    public static class ListWorkflowsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorkflowsResponseErrorType3 value)
        {
            return value switch
            {
                ListWorkflowsResponseErrorType3.AuthorizationError => "authorization_error",
                ListWorkflowsResponseErrorType3.ValidationError => "validation_error",
                ListWorkflowsResponseErrorType3.NotFound => "not_found",
                ListWorkflowsResponseErrorType3.RateLimited => "rate_limited",
                ListWorkflowsResponseErrorType3.ServerError => "server_error",
                ListWorkflowsResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorkflowsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListWorkflowsResponseErrorType3.AuthorizationError,
                "validation_error" => ListWorkflowsResponseErrorType3.ValidationError,
                "not_found" => ListWorkflowsResponseErrorType3.NotFound,
                "rate_limited" => ListWorkflowsResponseErrorType3.RateLimited,
                "server_error" => ListWorkflowsResponseErrorType3.ServerError,
                "not_implemented" => ListWorkflowsResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}