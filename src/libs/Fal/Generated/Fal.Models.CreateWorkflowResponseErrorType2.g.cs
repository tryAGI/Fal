
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateWorkflowResponseErrorType2
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
    public static class CreateWorkflowResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWorkflowResponseErrorType2 value)
        {
            return value switch
            {
                CreateWorkflowResponseErrorType2.AuthorizationError => "authorization_error",
                CreateWorkflowResponseErrorType2.NotFound => "not_found",
                CreateWorkflowResponseErrorType2.NotImplemented => "not_implemented",
                CreateWorkflowResponseErrorType2.RateLimited => "rate_limited",
                CreateWorkflowResponseErrorType2.ServerError => "server_error",
                CreateWorkflowResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWorkflowResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateWorkflowResponseErrorType2.AuthorizationError,
                "not_found" => CreateWorkflowResponseErrorType2.NotFound,
                "not_implemented" => CreateWorkflowResponseErrorType2.NotImplemented,
                "rate_limited" => CreateWorkflowResponseErrorType2.RateLimited,
                "server_error" => CreateWorkflowResponseErrorType2.ServerError,
                "validation_error" => CreateWorkflowResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}