
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCharacterResponseErrorType3
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
    public static class GetAssetCharacterResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCharacterResponseErrorType3 value)
        {
            return value switch
            {
                GetAssetCharacterResponseErrorType3.AuthorizationError => "authorization_error",
                GetAssetCharacterResponseErrorType3.NotFound => "not_found",
                GetAssetCharacterResponseErrorType3.NotImplemented => "not_implemented",
                GetAssetCharacterResponseErrorType3.RateLimited => "rate_limited",
                GetAssetCharacterResponseErrorType3.ServerError => "server_error",
                GetAssetCharacterResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCharacterResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCharacterResponseErrorType3.AuthorizationError,
                "not_found" => GetAssetCharacterResponseErrorType3.NotFound,
                "not_implemented" => GetAssetCharacterResponseErrorType3.NotImplemented,
                "rate_limited" => GetAssetCharacterResponseErrorType3.RateLimited,
                "server_error" => GetAssetCharacterResponseErrorType3.ServerError,
                "validation_error" => GetAssetCharacterResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}