
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetResponseErrorType4
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
    public static class GetAssetResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetResponseErrorType4 value)
        {
            return value switch
            {
                GetAssetResponseErrorType4.AuthorizationError => "authorization_error",
                GetAssetResponseErrorType4.NotFound => "not_found",
                GetAssetResponseErrorType4.NotImplemented => "not_implemented",
                GetAssetResponseErrorType4.RateLimited => "rate_limited",
                GetAssetResponseErrorType4.ServerError => "server_error",
                GetAssetResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetResponseErrorType4.AuthorizationError,
                "not_found" => GetAssetResponseErrorType4.NotFound,
                "not_implemented" => GetAssetResponseErrorType4.NotImplemented,
                "rate_limited" => GetAssetResponseErrorType4.RateLimited,
                "server_error" => GetAssetResponseErrorType4.ServerError,
                "validation_error" => GetAssetResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}