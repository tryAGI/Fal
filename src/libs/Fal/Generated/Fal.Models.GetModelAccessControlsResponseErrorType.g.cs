
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetModelAccessControlsResponseErrorType
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
    public static class GetModelAccessControlsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelAccessControlsResponseErrorType value)
        {
            return value switch
            {
                GetModelAccessControlsResponseErrorType.AuthorizationError => "authorization_error",
                GetModelAccessControlsResponseErrorType.NotFound => "not_found",
                GetModelAccessControlsResponseErrorType.NotImplemented => "not_implemented",
                GetModelAccessControlsResponseErrorType.RateLimited => "rate_limited",
                GetModelAccessControlsResponseErrorType.ServerError => "server_error",
                GetModelAccessControlsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelAccessControlsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetModelAccessControlsResponseErrorType.AuthorizationError,
                "not_found" => GetModelAccessControlsResponseErrorType.NotFound,
                "not_implemented" => GetModelAccessControlsResponseErrorType.NotImplemented,
                "rate_limited" => GetModelAccessControlsResponseErrorType.RateLimited,
                "server_error" => GetModelAccessControlsResponseErrorType.ServerError,
                "validation_error" => GetModelAccessControlsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}