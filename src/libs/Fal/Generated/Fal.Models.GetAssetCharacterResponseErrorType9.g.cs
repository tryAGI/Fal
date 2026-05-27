
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCharacterResponseErrorType9
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
    public static class GetAssetCharacterResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCharacterResponseErrorType9 value)
        {
            return value switch
            {
                GetAssetCharacterResponseErrorType9.AuthorizationError => "authorization_error",
                GetAssetCharacterResponseErrorType9.NotFound => "not_found",
                GetAssetCharacterResponseErrorType9.NotImplemented => "not_implemented",
                GetAssetCharacterResponseErrorType9.RateLimited => "rate_limited",
                GetAssetCharacterResponseErrorType9.ServerError => "server_error",
                GetAssetCharacterResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCharacterResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCharacterResponseErrorType9.AuthorizationError,
                "not_found" => GetAssetCharacterResponseErrorType9.NotFound,
                "not_implemented" => GetAssetCharacterResponseErrorType9.NotImplemented,
                "rate_limited" => GetAssetCharacterResponseErrorType9.RateLimited,
                "server_error" => GetAssetCharacterResponseErrorType9.ServerError,
                "validation_error" => GetAssetCharacterResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}