
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetModelsResponseErrorType4
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
    public static class GetModelsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseErrorType4 value)
        {
            return value switch
            {
                GetModelsResponseErrorType4.AuthorizationError => "authorization_error",
                GetModelsResponseErrorType4.ValidationError => "validation_error",
                GetModelsResponseErrorType4.NotFound => "not_found",
                GetModelsResponseErrorType4.RateLimited => "rate_limited",
                GetModelsResponseErrorType4.ServerError => "server_error",
                GetModelsResponseErrorType4.NotImplemented => "not_implemented",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetModelsResponseErrorType4.AuthorizationError,
                "validation_error" => GetModelsResponseErrorType4.ValidationError,
                "not_found" => GetModelsResponseErrorType4.NotFound,
                "rate_limited" => GetModelsResponseErrorType4.RateLimited,
                "server_error" => GetModelsResponseErrorType4.ServerError,
                "not_implemented" => GetModelsResponseErrorType4.NotImplemented,
                _ => null,
            };
        }
    }
}