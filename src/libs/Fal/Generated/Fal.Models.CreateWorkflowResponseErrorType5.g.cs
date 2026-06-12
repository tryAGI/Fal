
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateWorkflowResponseErrorType5
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
    public static class CreateWorkflowResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowResponseErrorType5 value)
        {
            return value switch
            {
                CreateWorkflowResponseErrorType5.AuthorizationError => "authorization_error",
                CreateWorkflowResponseErrorType5.NotFound => "not_found",
                CreateWorkflowResponseErrorType5.NotImplemented => "not_implemented",
                CreateWorkflowResponseErrorType5.RateLimited => "rate_limited",
                CreateWorkflowResponseErrorType5.ServerError => "server_error",
                CreateWorkflowResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateWorkflowResponseErrorType5.AuthorizationError,
                "not_found" => CreateWorkflowResponseErrorType5.NotFound,
                "not_implemented" => CreateWorkflowResponseErrorType5.NotImplemented,
                "rate_limited" => CreateWorkflowResponseErrorType5.RateLimited,
                "server_error" => CreateWorkflowResponseErrorType5.ServerError,
                "validation_error" => CreateWorkflowResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}