
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetModelAccessControlsResponseErrorType3
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
    public static class GetModelAccessControlsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelAccessControlsResponseErrorType3 value)
        {
            return value switch
            {
                GetModelAccessControlsResponseErrorType3.AuthorizationError => "authorization_error",
                GetModelAccessControlsResponseErrorType3.NotFound => "not_found",
                GetModelAccessControlsResponseErrorType3.NotImplemented => "not_implemented",
                GetModelAccessControlsResponseErrorType3.RateLimited => "rate_limited",
                GetModelAccessControlsResponseErrorType3.ServerError => "server_error",
                GetModelAccessControlsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelAccessControlsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetModelAccessControlsResponseErrorType3.AuthorizationError,
                "not_found" => GetModelAccessControlsResponseErrorType3.NotFound,
                "not_implemented" => GetModelAccessControlsResponseErrorType3.NotImplemented,
                "rate_limited" => GetModelAccessControlsResponseErrorType3.RateLimited,
                "server_error" => GetModelAccessControlsResponseErrorType3.ServerError,
                "validation_error" => GetModelAccessControlsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}