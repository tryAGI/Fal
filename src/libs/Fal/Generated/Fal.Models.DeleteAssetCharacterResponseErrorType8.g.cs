
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCharacterResponseErrorType8
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
    public static class DeleteAssetCharacterResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCharacterResponseErrorType8 value)
        {
            return value switch
            {
                DeleteAssetCharacterResponseErrorType8.AuthorizationError => "authorization_error",
                DeleteAssetCharacterResponseErrorType8.NotFound => "not_found",
                DeleteAssetCharacterResponseErrorType8.NotImplemented => "not_implemented",
                DeleteAssetCharacterResponseErrorType8.RateLimited => "rate_limited",
                DeleteAssetCharacterResponseErrorType8.ServerError => "server_error",
                DeleteAssetCharacterResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCharacterResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCharacterResponseErrorType8.AuthorizationError,
                "not_found" => DeleteAssetCharacterResponseErrorType8.NotFound,
                "not_implemented" => DeleteAssetCharacterResponseErrorType8.NotImplemented,
                "rate_limited" => DeleteAssetCharacterResponseErrorType8.RateLimited,
                "server_error" => DeleteAssetCharacterResponseErrorType8.ServerError,
                "validation_error" => DeleteAssetCharacterResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}