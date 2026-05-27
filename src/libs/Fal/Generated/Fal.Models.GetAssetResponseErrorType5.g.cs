
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetResponseErrorType5
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
    public static class GetAssetResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetResponseErrorType5 value)
        {
            return value switch
            {
                GetAssetResponseErrorType5.AuthorizationError => "authorization_error",
                GetAssetResponseErrorType5.NotFound => "not_found",
                GetAssetResponseErrorType5.NotImplemented => "not_implemented",
                GetAssetResponseErrorType5.RateLimited => "rate_limited",
                GetAssetResponseErrorType5.ServerError => "server_error",
                GetAssetResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetResponseErrorType5.AuthorizationError,
                "not_found" => GetAssetResponseErrorType5.NotFound,
                "not_implemented" => GetAssetResponseErrorType5.NotImplemented,
                "rate_limited" => GetAssetResponseErrorType5.RateLimited,
                "server_error" => GetAssetResponseErrorType5.ServerError,
                "validation_error" => GetAssetResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}