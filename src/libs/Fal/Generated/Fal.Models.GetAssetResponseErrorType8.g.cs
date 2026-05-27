
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetResponseErrorType8
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
    public static class GetAssetResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetResponseErrorType8 value)
        {
            return value switch
            {
                GetAssetResponseErrorType8.AuthorizationError => "authorization_error",
                GetAssetResponseErrorType8.NotFound => "not_found",
                GetAssetResponseErrorType8.NotImplemented => "not_implemented",
                GetAssetResponseErrorType8.RateLimited => "rate_limited",
                GetAssetResponseErrorType8.ServerError => "server_error",
                GetAssetResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetResponseErrorType8.AuthorizationError,
                "not_found" => GetAssetResponseErrorType8.NotFound,
                "not_implemented" => GetAssetResponseErrorType8.NotImplemented,
                "rate_limited" => GetAssetResponseErrorType8.RateLimited,
                "server_error" => GetAssetResponseErrorType8.ServerError,
                "validation_error" => GetAssetResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}