
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCharacterResponseErrorType8
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
    public static class CreateAssetCharacterResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCharacterResponseErrorType8 value)
        {
            return value switch
            {
                CreateAssetCharacterResponseErrorType8.AuthorizationError => "authorization_error",
                CreateAssetCharacterResponseErrorType8.NotFound => "not_found",
                CreateAssetCharacterResponseErrorType8.NotImplemented => "not_implemented",
                CreateAssetCharacterResponseErrorType8.RateLimited => "rate_limited",
                CreateAssetCharacterResponseErrorType8.ServerError => "server_error",
                CreateAssetCharacterResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCharacterResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCharacterResponseErrorType8.AuthorizationError,
                "not_found" => CreateAssetCharacterResponseErrorType8.NotFound,
                "not_implemented" => CreateAssetCharacterResponseErrorType8.NotImplemented,
                "rate_limited" => CreateAssetCharacterResponseErrorType8.RateLimited,
                "server_error" => CreateAssetCharacterResponseErrorType8.ServerError,
                "validation_error" => CreateAssetCharacterResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}