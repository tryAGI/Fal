
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCharacterResponseErrorType7
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
    public static class CreateAssetCharacterResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCharacterResponseErrorType7 value)
        {
            return value switch
            {
                CreateAssetCharacterResponseErrorType7.AuthorizationError => "authorization_error",
                CreateAssetCharacterResponseErrorType7.NotFound => "not_found",
                CreateAssetCharacterResponseErrorType7.NotImplemented => "not_implemented",
                CreateAssetCharacterResponseErrorType7.RateLimited => "rate_limited",
                CreateAssetCharacterResponseErrorType7.ServerError => "server_error",
                CreateAssetCharacterResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCharacterResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCharacterResponseErrorType7.AuthorizationError,
                "not_found" => CreateAssetCharacterResponseErrorType7.NotFound,
                "not_implemented" => CreateAssetCharacterResponseErrorType7.NotImplemented,
                "rate_limited" => CreateAssetCharacterResponseErrorType7.RateLimited,
                "server_error" => CreateAssetCharacterResponseErrorType7.ServerError,
                "validation_error" => CreateAssetCharacterResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}