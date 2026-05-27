
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCharacterResponseErrorType4
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
    public static class GetAssetCharacterResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCharacterResponseErrorType4 value)
        {
            return value switch
            {
                GetAssetCharacterResponseErrorType4.AuthorizationError => "authorization_error",
                GetAssetCharacterResponseErrorType4.NotFound => "not_found",
                GetAssetCharacterResponseErrorType4.NotImplemented => "not_implemented",
                GetAssetCharacterResponseErrorType4.RateLimited => "rate_limited",
                GetAssetCharacterResponseErrorType4.ServerError => "server_error",
                GetAssetCharacterResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCharacterResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCharacterResponseErrorType4.AuthorizationError,
                "not_found" => GetAssetCharacterResponseErrorType4.NotFound,
                "not_implemented" => GetAssetCharacterResponseErrorType4.NotImplemented,
                "rate_limited" => GetAssetCharacterResponseErrorType4.RateLimited,
                "server_error" => GetAssetCharacterResponseErrorType4.ServerError,
                "validation_error" => GetAssetCharacterResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}