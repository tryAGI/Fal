
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetModelsResponseErrorType
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
    public static class GetModelsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseErrorType value)
        {
            return value switch
            {
                GetModelsResponseErrorType.AuthorizationError => "authorization_error",
                GetModelsResponseErrorType.ValidationError => "validation_error",
                GetModelsResponseErrorType.NotFound => "not_found",
                GetModelsResponseErrorType.RateLimited => "rate_limited",
                GetModelsResponseErrorType.ServerError => "server_error",
                GetModelsResponseErrorType.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetModelsResponseErrorType.AuthorizationError,
                "validation_error" => GetModelsResponseErrorType.ValidationError,
                "not_found" => GetModelsResponseErrorType.NotFound,
                "rate_limited" => GetModelsResponseErrorType.RateLimited,
                "server_error" => GetModelsResponseErrorType.ServerError,
                "not_implemented" => GetModelsResponseErrorType.NotImplemented,
                _ => null,
            };
        }
    }
}