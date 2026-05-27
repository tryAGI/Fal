
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCharacterResponseErrorType2
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
    public static class CreateAssetCharacterResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCharacterResponseErrorType2 value)
        {
            return value switch
            {
                CreateAssetCharacterResponseErrorType2.AuthorizationError => "authorization_error",
                CreateAssetCharacterResponseErrorType2.NotFound => "not_found",
                CreateAssetCharacterResponseErrorType2.NotImplemented => "not_implemented",
                CreateAssetCharacterResponseErrorType2.RateLimited => "rate_limited",
                CreateAssetCharacterResponseErrorType2.ServerError => "server_error",
                CreateAssetCharacterResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCharacterResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCharacterResponseErrorType2.AuthorizationError,
                "not_found" => CreateAssetCharacterResponseErrorType2.NotFound,
                "not_implemented" => CreateAssetCharacterResponseErrorType2.NotImplemented,
                "rate_limited" => CreateAssetCharacterResponseErrorType2.RateLimited,
                "server_error" => CreateAssetCharacterResponseErrorType2.ServerError,
                "validation_error" => CreateAssetCharacterResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}