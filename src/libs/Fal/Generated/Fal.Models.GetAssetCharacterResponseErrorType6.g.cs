
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCharacterResponseErrorType6
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
    public static class GetAssetCharacterResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCharacterResponseErrorType6 value)
        {
            return value switch
            {
                GetAssetCharacterResponseErrorType6.AuthorizationError => "authorization_error",
                GetAssetCharacterResponseErrorType6.NotFound => "not_found",
                GetAssetCharacterResponseErrorType6.NotImplemented => "not_implemented",
                GetAssetCharacterResponseErrorType6.RateLimited => "rate_limited",
                GetAssetCharacterResponseErrorType6.ServerError => "server_error",
                GetAssetCharacterResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCharacterResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCharacterResponseErrorType6.AuthorizationError,
                "not_found" => GetAssetCharacterResponseErrorType6.NotFound,
                "not_implemented" => GetAssetCharacterResponseErrorType6.NotImplemented,
                "rate_limited" => GetAssetCharacterResponseErrorType6.RateLimited,
                "server_error" => GetAssetCharacterResponseErrorType6.ServerError,
                "validation_error" => GetAssetCharacterResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}