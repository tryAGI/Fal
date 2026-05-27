
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetCharacterResponseErrorType8
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
    public static class GetAssetCharacterResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetCharacterResponseErrorType8 value)
        {
            return value switch
            {
                GetAssetCharacterResponseErrorType8.AuthorizationError => "authorization_error",
                GetAssetCharacterResponseErrorType8.NotFound => "not_found",
                GetAssetCharacterResponseErrorType8.NotImplemented => "not_implemented",
                GetAssetCharacterResponseErrorType8.RateLimited => "rate_limited",
                GetAssetCharacterResponseErrorType8.ServerError => "server_error",
                GetAssetCharacterResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetCharacterResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetCharacterResponseErrorType8.AuthorizationError,
                "not_found" => GetAssetCharacterResponseErrorType8.NotFound,
                "not_implemented" => GetAssetCharacterResponseErrorType8.NotImplemented,
                "rate_limited" => GetAssetCharacterResponseErrorType8.RateLimited,
                "server_error" => GetAssetCharacterResponseErrorType8.ServerError,
                "validation_error" => GetAssetCharacterResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}