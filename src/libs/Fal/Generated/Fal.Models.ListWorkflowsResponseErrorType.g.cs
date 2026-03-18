
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListWorkflowsResponseErrorType
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
    public static class ListWorkflowsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorkflowsResponseErrorType value)
        {
            return value switch
            {
                ListWorkflowsResponseErrorType.AuthorizationError => "authorization_error",
                ListWorkflowsResponseErrorType.ValidationError => "validation_error",
                ListWorkflowsResponseErrorType.NotFound => "not_found",
                ListWorkflowsResponseErrorType.RateLimited => "rate_limited",
                ListWorkflowsResponseErrorType.ServerError => "server_error",
                ListWorkflowsResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorkflowsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListWorkflowsResponseErrorType.AuthorizationError,
                "validation_error" => ListWorkflowsResponseErrorType.ValidationError,
                "not_found" => ListWorkflowsResponseErrorType.NotFound,
                "rate_limited" => ListWorkflowsResponseErrorType.RateLimited,
                "server_error" => ListWorkflowsResponseErrorType.ServerError,
                "not_implemented" => ListWorkflowsResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}