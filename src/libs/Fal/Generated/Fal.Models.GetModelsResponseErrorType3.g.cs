
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetModelsResponseErrorType3
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
    public static class GetModelsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseErrorType3 value)
        {
            return value switch
            {
                GetModelsResponseErrorType3.AuthorizationError => "authorization_error",
                GetModelsResponseErrorType3.ValidationError => "validation_error",
                GetModelsResponseErrorType3.NotFound => "not_found",
                GetModelsResponseErrorType3.RateLimited => "rate_limited",
                GetModelsResponseErrorType3.ServerError => "server_error",
                GetModelsResponseErrorType3.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetModelsResponseErrorType3.AuthorizationError,
                "validation_error" => GetModelsResponseErrorType3.ValidationError,
                "not_found" => GetModelsResponseErrorType3.NotFound,
                "rate_limited" => GetModelsResponseErrorType3.RateLimited,
                "server_error" => GetModelsResponseErrorType3.ServerError,
                "not_implemented" => GetModelsResponseErrorType3.NotImplemented,
                _ => null,
            };
        }
    }
}