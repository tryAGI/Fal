
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetResponseErrorType7
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
    public static class GetAssetResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetResponseErrorType7 value)
        {
            return value switch
            {
                GetAssetResponseErrorType7.AuthorizationError => "authorization_error",
                GetAssetResponseErrorType7.NotFound => "not_found",
                GetAssetResponseErrorType7.NotImplemented => "not_implemented",
                GetAssetResponseErrorType7.RateLimited => "rate_limited",
                GetAssetResponseErrorType7.ServerError => "server_error",
                GetAssetResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetResponseErrorType7.AuthorizationError,
                "not_found" => GetAssetResponseErrorType7.NotFound,
                "not_implemented" => GetAssetResponseErrorType7.NotImplemented,
                "rate_limited" => GetAssetResponseErrorType7.RateLimited,
                "server_error" => GetAssetResponseErrorType7.ServerError,
                "validation_error" => GetAssetResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}