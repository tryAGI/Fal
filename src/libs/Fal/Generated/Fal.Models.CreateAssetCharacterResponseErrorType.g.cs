
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCharacterResponseErrorType
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
    public static class CreateAssetCharacterResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCharacterResponseErrorType value)
        {
            return value switch
            {
                CreateAssetCharacterResponseErrorType.AuthorizationError => "authorization_error",
                CreateAssetCharacterResponseErrorType.NotFound => "not_found",
                CreateAssetCharacterResponseErrorType.NotImplemented => "not_implemented",
                CreateAssetCharacterResponseErrorType.RateLimited => "rate_limited",
                CreateAssetCharacterResponseErrorType.ServerError => "server_error",
                CreateAssetCharacterResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCharacterResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCharacterResponseErrorType.AuthorizationError,
                "not_found" => CreateAssetCharacterResponseErrorType.NotFound,
                "not_implemented" => CreateAssetCharacterResponseErrorType.NotImplemented,
                "rate_limited" => CreateAssetCharacterResponseErrorType.RateLimited,
                "server_error" => CreateAssetCharacterResponseErrorType.ServerError,
                "validation_error" => CreateAssetCharacterResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}