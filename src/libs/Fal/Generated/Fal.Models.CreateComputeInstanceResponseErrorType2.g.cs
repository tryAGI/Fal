
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateComputeInstanceResponseErrorType2
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
    public static class CreateComputeInstanceResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseErrorType2 value)
        {
            return value switch
            {
                CreateComputeInstanceResponseErrorType2.AuthorizationError => "authorization_error",
                CreateComputeInstanceResponseErrorType2.ValidationError => "validation_error",
                CreateComputeInstanceResponseErrorType2.NotFound => "not_found",
                CreateComputeInstanceResponseErrorType2.RateLimited => "rate_limited",
                CreateComputeInstanceResponseErrorType2.ServerError => "server_error",
                CreateComputeInstanceResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateComputeInstanceResponseErrorType2.AuthorizationError,
                "validation_error" => CreateComputeInstanceResponseErrorType2.ValidationError,
                "not_found" => CreateComputeInstanceResponseErrorType2.NotFound,
                "rate_limited" => CreateComputeInstanceResponseErrorType2.RateLimited,
                "server_error" => CreateComputeInstanceResponseErrorType2.ServerError,
                "not_implemented" => CreateComputeInstanceResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}