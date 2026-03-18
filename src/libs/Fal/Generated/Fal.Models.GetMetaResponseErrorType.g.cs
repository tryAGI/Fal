
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetMetaResponseErrorType
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
    public static class GetMetaResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMetaResponseErrorType value)
        {
            return value switch
            {
                GetMetaResponseErrorType.AuthorizationError => "authorization_error",
                GetMetaResponseErrorType.ValidationError => "validation_error",
                GetMetaResponseErrorType.NotFound => "not_found",
                GetMetaResponseErrorType.RateLimited => "rate_limited",
                GetMetaResponseErrorType.ServerError => "server_error",
                GetMetaResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMetaResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetMetaResponseErrorType.AuthorizationError,
                "validation_error" => GetMetaResponseErrorType.ValidationError,
                "not_found" => GetMetaResponseErrorType.NotFound,
                "rate_limited" => GetMetaResponseErrorType.RateLimited,
                "server_error" => GetMetaResponseErrorType.ServerError,
                "not_implemented" => GetMetaResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}