
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCharacterResponseErrorType
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
    public static class DeleteAssetCharacterResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCharacterResponseErrorType value)
        {
            return value switch
            {
                DeleteAssetCharacterResponseErrorType.AuthorizationError => "authorization_error",
                DeleteAssetCharacterResponseErrorType.NotFound => "not_found",
                DeleteAssetCharacterResponseErrorType.NotImplemented => "not_implemented",
                DeleteAssetCharacterResponseErrorType.RateLimited => "rate_limited",
                DeleteAssetCharacterResponseErrorType.ServerError => "server_error",
                DeleteAssetCharacterResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCharacterResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCharacterResponseErrorType.AuthorizationError,
                "not_found" => DeleteAssetCharacterResponseErrorType.NotFound,
                "not_implemented" => DeleteAssetCharacterResponseErrorType.NotImplemented,
                "rate_limited" => DeleteAssetCharacterResponseErrorType.RateLimited,
                "server_error" => DeleteAssetCharacterResponseErrorType.ServerError,
                "validation_error" => DeleteAssetCharacterResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}