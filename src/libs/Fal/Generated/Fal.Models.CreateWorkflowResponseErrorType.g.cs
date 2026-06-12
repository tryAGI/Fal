
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateWorkflowResponseErrorType
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
    public static class CreateWorkflowResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowResponseErrorType value)
        {
            return value switch
            {
                CreateWorkflowResponseErrorType.AuthorizationError => "authorization_error",
                CreateWorkflowResponseErrorType.NotFound => "not_found",
                CreateWorkflowResponseErrorType.NotImplemented => "not_implemented",
                CreateWorkflowResponseErrorType.RateLimited => "rate_limited",
                CreateWorkflowResponseErrorType.ServerError => "server_error",
                CreateWorkflowResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateWorkflowResponseErrorType.AuthorizationError,
                "not_found" => CreateWorkflowResponseErrorType.NotFound,
                "not_implemented" => CreateWorkflowResponseErrorType.NotImplemented,
                "rate_limited" => CreateWorkflowResponseErrorType.RateLimited,
                "server_error" => CreateWorkflowResponseErrorType.ServerError,
                "validation_error" => CreateWorkflowResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}