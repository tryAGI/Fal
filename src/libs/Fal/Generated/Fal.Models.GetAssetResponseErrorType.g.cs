
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetResponseErrorType
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
    public static class GetAssetResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetResponseErrorType value)
        {
            return value switch
            {
                GetAssetResponseErrorType.AuthorizationError => "authorization_error",
                GetAssetResponseErrorType.NotFound => "not_found",
                GetAssetResponseErrorType.NotImplemented => "not_implemented",
                GetAssetResponseErrorType.RateLimited => "rate_limited",
                GetAssetResponseErrorType.ServerError => "server_error",
                GetAssetResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetResponseErrorType.AuthorizationError,
                "not_found" => GetAssetResponseErrorType.NotFound,
                "not_implemented" => GetAssetResponseErrorType.NotImplemented,
                "rate_limited" => GetAssetResponseErrorType.RateLimited,
                "server_error" => GetAssetResponseErrorType.ServerError,
                "validation_error" => GetAssetResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}