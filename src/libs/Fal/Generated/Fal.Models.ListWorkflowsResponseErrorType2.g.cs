
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum ListWorkflowsResponseErrorType2
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
    public static class ListWorkflowsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorkflowsResponseErrorType2 value)
        {
            return value switch
            {
                ListWorkflowsResponseErrorType2.AuthorizationError => "authorization_error",
                ListWorkflowsResponseErrorType2.ValidationError => "validation_error",
                ListWorkflowsResponseErrorType2.NotFound => "not_found",
                ListWorkflowsResponseErrorType2.RateLimited => "rate_limited",
                ListWorkflowsResponseErrorType2.ServerError => "server_error",
                ListWorkflowsResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorkflowsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => ListWorkflowsResponseErrorType2.AuthorizationError,
                "validation_error" => ListWorkflowsResponseErrorType2.ValidationError,
                "not_found" => ListWorkflowsResponseErrorType2.NotFound,
                "rate_limited" => ListWorkflowsResponseErrorType2.RateLimited,
                "server_error" => ListWorkflowsResponseErrorType2.ServerError,
                "not_implemented" => ListWorkflowsResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}