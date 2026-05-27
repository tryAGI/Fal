
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCharacterResponseErrorType6
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
    public static class CreateAssetCharacterResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCharacterResponseErrorType6 value)
        {
            return value switch
            {
                CreateAssetCharacterResponseErrorType6.AuthorizationError => "authorization_error",
                CreateAssetCharacterResponseErrorType6.NotFound => "not_found",
                CreateAssetCharacterResponseErrorType6.NotImplemented => "not_implemented",
                CreateAssetCharacterResponseErrorType6.RateLimited => "rate_limited",
                CreateAssetCharacterResponseErrorType6.ServerError => "server_error",
                CreateAssetCharacterResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCharacterResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCharacterResponseErrorType6.AuthorizationError,
                "not_found" => CreateAssetCharacterResponseErrorType6.NotFound,
                "not_implemented" => CreateAssetCharacterResponseErrorType6.NotImplemented,
                "rate_limited" => CreateAssetCharacterResponseErrorType6.RateLimited,
                "server_error" => CreateAssetCharacterResponseErrorType6.ServerError,
                "validation_error" => CreateAssetCharacterResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}