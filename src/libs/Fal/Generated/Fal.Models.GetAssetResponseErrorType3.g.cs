
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetResponseErrorType3
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
    public static class GetAssetResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetResponseErrorType3 value)
        {
            return value switch
            {
                GetAssetResponseErrorType3.AuthorizationError => "authorization_error",
                GetAssetResponseErrorType3.NotFound => "not_found",
                GetAssetResponseErrorType3.NotImplemented => "not_implemented",
                GetAssetResponseErrorType3.RateLimited => "rate_limited",
                GetAssetResponseErrorType3.ServerError => "server_error",
                GetAssetResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetResponseErrorType3.AuthorizationError,
                "not_found" => GetAssetResponseErrorType3.NotFound,
                "not_implemented" => GetAssetResponseErrorType3.NotImplemented,
                "rate_limited" => GetAssetResponseErrorType3.RateLimited,
                "server_error" => GetAssetResponseErrorType3.ServerError,
                "validation_error" => GetAssetResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}