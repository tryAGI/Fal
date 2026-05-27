
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCharacterResponseErrorType
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
    public static class GetAssetCharacterResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCharacterResponseErrorType value)
        {
            return value switch
            {
                GetAssetCharacterResponseErrorType.AuthorizationError => "authorization_error",
                GetAssetCharacterResponseErrorType.NotFound => "not_found",
                GetAssetCharacterResponseErrorType.NotImplemented => "not_implemented",
                GetAssetCharacterResponseErrorType.RateLimited => "rate_limited",
                GetAssetCharacterResponseErrorType.ServerError => "server_error",
                GetAssetCharacterResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCharacterResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCharacterResponseErrorType.AuthorizationError,
                "not_found" => GetAssetCharacterResponseErrorType.NotFound,
                "not_implemented" => GetAssetCharacterResponseErrorType.NotImplemented,
                "rate_limited" => GetAssetCharacterResponseErrorType.RateLimited,
                "server_error" => GetAssetCharacterResponseErrorType.ServerError,
                "validation_error" => GetAssetCharacterResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}