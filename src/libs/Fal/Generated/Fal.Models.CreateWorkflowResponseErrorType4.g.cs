
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateWorkflowResponseErrorType4
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationError,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        NotImplemented,
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
        ValidationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWorkflowResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowResponseErrorType4 value)
        {
            return value switch
            {
                CreateWorkflowResponseErrorType4.AuthorizationError => "authorization_error",
                CreateWorkflowResponseErrorType4.NotFound => "not_found",
                CreateWorkflowResponseErrorType4.NotImplemented => "not_implemented",
                CreateWorkflowResponseErrorType4.RateLimited => "rate_limited",
                CreateWorkflowResponseErrorType4.ServerError => "server_error",
                CreateWorkflowResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateWorkflowResponseErrorType4.AuthorizationError,
                "not_found" => CreateWorkflowResponseErrorType4.NotFound,
                "not_implemented" => CreateWorkflowResponseErrorType4.NotImplemented,
                "rate_limited" => CreateWorkflowResponseErrorType4.RateLimited,
                "server_error" => CreateWorkflowResponseErrorType4.ServerError,
                "validation_error" => CreateWorkflowResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}