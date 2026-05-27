
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCharacterResponseErrorType5
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
    public static class CreateAssetCharacterResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCharacterResponseErrorType5 value)
        {
            return value switch
            {
                CreateAssetCharacterResponseErrorType5.AuthorizationError => "authorization_error",
                CreateAssetCharacterResponseErrorType5.NotFound => "not_found",
                CreateAssetCharacterResponseErrorType5.NotImplemented => "not_implemented",
                CreateAssetCharacterResponseErrorType5.RateLimited => "rate_limited",
                CreateAssetCharacterResponseErrorType5.ServerError => "server_error",
                CreateAssetCharacterResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCharacterResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCharacterResponseErrorType5.AuthorizationError,
                "not_found" => CreateAssetCharacterResponseErrorType5.NotFound,
                "not_implemented" => CreateAssetCharacterResponseErrorType5.NotImplemented,
                "rate_limited" => CreateAssetCharacterResponseErrorType5.RateLimited,
                "server_error" => CreateAssetCharacterResponseErrorType5.ServerError,
                "validation_error" => CreateAssetCharacterResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}