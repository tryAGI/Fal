
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCharacterResponseErrorType5
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
    public static class GetAssetCharacterResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCharacterResponseErrorType5 value)
        {
            return value switch
            {
                GetAssetCharacterResponseErrorType5.AuthorizationError => "authorization_error",
                GetAssetCharacterResponseErrorType5.NotFound => "not_found",
                GetAssetCharacterResponseErrorType5.NotImplemented => "not_implemented",
                GetAssetCharacterResponseErrorType5.RateLimited => "rate_limited",
                GetAssetCharacterResponseErrorType5.ServerError => "server_error",
                GetAssetCharacterResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCharacterResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCharacterResponseErrorType5.AuthorizationError,
                "not_found" => GetAssetCharacterResponseErrorType5.NotFound,
                "not_implemented" => GetAssetCharacterResponseErrorType5.NotImplemented,
                "rate_limited" => GetAssetCharacterResponseErrorType5.RateLimited,
                "server_error" => GetAssetCharacterResponseErrorType5.ServerError,
                "validation_error" => GetAssetCharacterResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}