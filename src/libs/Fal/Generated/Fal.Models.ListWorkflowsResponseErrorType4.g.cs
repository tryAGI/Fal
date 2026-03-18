
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListWorkflowsResponseErrorType4
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
    public static class ListWorkflowsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorkflowsResponseErrorType4 value)
        {
            return value switch
            {
                ListWorkflowsResponseErrorType4.AuthorizationError => "authorization_error",
                ListWorkflowsResponseErrorType4.ValidationError => "validation_error",
                ListWorkflowsResponseErrorType4.NotFound => "not_found",
                ListWorkflowsResponseErrorType4.RateLimited => "rate_limited",
                ListWorkflowsResponseErrorType4.ServerError => "server_error",
                ListWorkflowsResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorkflowsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListWorkflowsResponseErrorType4.AuthorizationError,
                "validation_error" => ListWorkflowsResponseErrorType4.ValidationError,
                "not_found" => ListWorkflowsResponseErrorType4.NotFound,
                "rate_limited" => ListWorkflowsResponseErrorType4.RateLimited,
                "server_error" => ListWorkflowsResponseErrorType4.ServerError,
                "not_implemented" => ListWorkflowsResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}