
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetResponseErrorType6
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
    public static class GetAssetResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetResponseErrorType6 value)
        {
            return value switch
            {
                GetAssetResponseErrorType6.AuthorizationError => "authorization_error",
                GetAssetResponseErrorType6.NotFound => "not_found",
                GetAssetResponseErrorType6.NotImplemented => "not_implemented",
                GetAssetResponseErrorType6.RateLimited => "rate_limited",
                GetAssetResponseErrorType6.ServerError => "server_error",
                GetAssetResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetResponseErrorType6.AuthorizationError,
                "not_found" => GetAssetResponseErrorType6.NotFound,
                "not_implemented" => GetAssetResponseErrorType6.NotImplemented,
                "rate_limited" => GetAssetResponseErrorType6.RateLimited,
                "server_error" => GetAssetResponseErrorType6.ServerError,
                "validation_error" => GetAssetResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}