
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCharacterResponseErrorType7
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
    public static class GetAssetCharacterResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCharacterResponseErrorType7 value)
        {
            return value switch
            {
                GetAssetCharacterResponseErrorType7.AuthorizationError => "authorization_error",
                GetAssetCharacterResponseErrorType7.NotFound => "not_found",
                GetAssetCharacterResponseErrorType7.NotImplemented => "not_implemented",
                GetAssetCharacterResponseErrorType7.RateLimited => "rate_limited",
                GetAssetCharacterResponseErrorType7.ServerError => "server_error",
                GetAssetCharacterResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCharacterResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCharacterResponseErrorType7.AuthorizationError,
                "not_found" => GetAssetCharacterResponseErrorType7.NotFound,
                "not_implemented" => GetAssetCharacterResponseErrorType7.NotImplemented,
                "rate_limited" => GetAssetCharacterResponseErrorType7.RateLimited,
                "server_error" => GetAssetCharacterResponseErrorType7.ServerError,
                "validation_error" => GetAssetCharacterResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}