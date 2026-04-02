
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetModelAccessControlsResponseErrorType2
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
    public static class GetModelAccessControlsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelAccessControlsResponseErrorType2 value)
        {
            return value switch
            {
                GetModelAccessControlsResponseErrorType2.AuthorizationError => "authorization_error",
                GetModelAccessControlsResponseErrorType2.NotFound => "not_found",
                GetModelAccessControlsResponseErrorType2.NotImplemented => "not_implemented",
                GetModelAccessControlsResponseErrorType2.RateLimited => "rate_limited",
                GetModelAccessControlsResponseErrorType2.ServerError => "server_error",
                GetModelAccessControlsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelAccessControlsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetModelAccessControlsResponseErrorType2.AuthorizationError,
                "not_found" => GetModelAccessControlsResponseErrorType2.NotFound,
                "not_implemented" => GetModelAccessControlsResponseErrorType2.NotImplemented,
                "rate_limited" => GetModelAccessControlsResponseErrorType2.RateLimited,
                "server_error" => GetModelAccessControlsResponseErrorType2.ServerError,
                "validation_error" => GetModelAccessControlsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}