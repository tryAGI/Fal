
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetWorkflowResponseErrorType2
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
    public static class GetWorkflowResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowResponseErrorType2 value)
        {
            return value switch
            {
                GetWorkflowResponseErrorType2.AuthorizationError => "authorization_error",
                GetWorkflowResponseErrorType2.ValidationError => "validation_error",
                GetWorkflowResponseErrorType2.NotFound => "not_found",
                GetWorkflowResponseErrorType2.RateLimited => "rate_limited",
                GetWorkflowResponseErrorType2.ServerError => "server_error",
                GetWorkflowResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetWorkflowResponseErrorType2.AuthorizationError,
                "validation_error" => GetWorkflowResponseErrorType2.ValidationError,
                "not_found" => GetWorkflowResponseErrorType2.NotFound,
                "rate_limited" => GetWorkflowResponseErrorType2.RateLimited,
                "server_error" => GetWorkflowResponseErrorType2.ServerError,
                "not_implemented" => GetWorkflowResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}