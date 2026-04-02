
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetModelAccessControlsResponseErrorType4
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
    public static class GetModelAccessControlsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelAccessControlsResponseErrorType4 value)
        {
            return value switch
            {
                GetModelAccessControlsResponseErrorType4.AuthorizationError => "authorization_error",
                GetModelAccessControlsResponseErrorType4.NotFound => "not_found",
                GetModelAccessControlsResponseErrorType4.NotImplemented => "not_implemented",
                GetModelAccessControlsResponseErrorType4.RateLimited => "rate_limited",
                GetModelAccessControlsResponseErrorType4.ServerError => "server_error",
                GetModelAccessControlsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelAccessControlsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetModelAccessControlsResponseErrorType4.AuthorizationError,
                "not_found" => GetModelAccessControlsResponseErrorType4.NotFound,
                "not_implemented" => GetModelAccessControlsResponseErrorType4.NotImplemented,
                "rate_limited" => GetModelAccessControlsResponseErrorType4.RateLimited,
                "server_error" => GetModelAccessControlsResponseErrorType4.ServerError,
                "validation_error" => GetModelAccessControlsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}