
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCharacterResponseErrorType9
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
    public static class CreateAssetCharacterResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCharacterResponseErrorType9 value)
        {
            return value switch
            {
                CreateAssetCharacterResponseErrorType9.AuthorizationError => "authorization_error",
                CreateAssetCharacterResponseErrorType9.NotFound => "not_found",
                CreateAssetCharacterResponseErrorType9.NotImplemented => "not_implemented",
                CreateAssetCharacterResponseErrorType9.RateLimited => "rate_limited",
                CreateAssetCharacterResponseErrorType9.ServerError => "server_error",
                CreateAssetCharacterResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCharacterResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCharacterResponseErrorType9.AuthorizationError,
                "not_found" => CreateAssetCharacterResponseErrorType9.NotFound,
                "not_implemented" => CreateAssetCharacterResponseErrorType9.NotImplemented,
                "rate_limited" => CreateAssetCharacterResponseErrorType9.RateLimited,
                "server_error" => CreateAssetCharacterResponseErrorType9.ServerError,
                "validation_error" => CreateAssetCharacterResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}