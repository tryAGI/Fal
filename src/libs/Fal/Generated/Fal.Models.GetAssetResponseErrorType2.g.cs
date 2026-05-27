
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetResponseErrorType2
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
    public static class GetAssetResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetResponseErrorType2 value)
        {
            return value switch
            {
                GetAssetResponseErrorType2.AuthorizationError => "authorization_error",
                GetAssetResponseErrorType2.NotFound => "not_found",
                GetAssetResponseErrorType2.NotImplemented => "not_implemented",
                GetAssetResponseErrorType2.RateLimited => "rate_limited",
                GetAssetResponseErrorType2.ServerError => "server_error",
                GetAssetResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetResponseErrorType2.AuthorizationError,
                "not_found" => GetAssetResponseErrorType2.NotFound,
                "not_implemented" => GetAssetResponseErrorType2.NotImplemented,
                "rate_limited" => GetAssetResponseErrorType2.RateLimited,
                "server_error" => GetAssetResponseErrorType2.ServerError,
                "validation_error" => GetAssetResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}