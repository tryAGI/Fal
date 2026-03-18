
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetMetaResponseErrorType2
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
    public static class GetMetaResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMetaResponseErrorType2 value)
        {
            return value switch
            {
                GetMetaResponseErrorType2.AuthorizationError => "authorization_error",
                GetMetaResponseErrorType2.ValidationError => "validation_error",
                GetMetaResponseErrorType2.NotFound => "not_found",
                GetMetaResponseErrorType2.RateLimited => "rate_limited",
                GetMetaResponseErrorType2.ServerError => "server_error",
                GetMetaResponseErrorType2.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMetaResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetMetaResponseErrorType2.AuthorizationError,
                "validation_error" => GetMetaResponseErrorType2.ValidationError,
                "not_found" => GetMetaResponseErrorType2.NotFound,
                "rate_limited" => GetMetaResponseErrorType2.RateLimited,
                "server_error" => GetMetaResponseErrorType2.ServerError,
                "not_implemented" => GetMetaResponseErrorType2.NotImplemented,
                _ => null,
            };
        }
    }
}