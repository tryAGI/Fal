
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetResponseErrorType9
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
    public static class GetAssetResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetResponseErrorType9 value)
        {
            return value switch
            {
                GetAssetResponseErrorType9.AuthorizationError => "authorization_error",
                GetAssetResponseErrorType9.NotFound => "not_found",
                GetAssetResponseErrorType9.NotImplemented => "not_implemented",
                GetAssetResponseErrorType9.RateLimited => "rate_limited",
                GetAssetResponseErrorType9.ServerError => "server_error",
                GetAssetResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetResponseErrorType9.AuthorizationError,
                "not_found" => GetAssetResponseErrorType9.NotFound,
                "not_implemented" => GetAssetResponseErrorType9.NotImplemented,
                "rate_limited" => GetAssetResponseErrorType9.RateLimited,
                "server_error" => GetAssetResponseErrorType9.ServerError,
                "validation_error" => GetAssetResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}