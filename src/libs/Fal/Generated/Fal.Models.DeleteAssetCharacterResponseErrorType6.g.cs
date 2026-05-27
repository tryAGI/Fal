
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCharacterResponseErrorType6
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
    public static class DeleteAssetCharacterResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCharacterResponseErrorType6 value)
        {
            return value switch
            {
                DeleteAssetCharacterResponseErrorType6.AuthorizationError => "authorization_error",
                DeleteAssetCharacterResponseErrorType6.NotFound => "not_found",
                DeleteAssetCharacterResponseErrorType6.NotImplemented => "not_implemented",
                DeleteAssetCharacterResponseErrorType6.RateLimited => "rate_limited",
                DeleteAssetCharacterResponseErrorType6.ServerError => "server_error",
                DeleteAssetCharacterResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCharacterResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCharacterResponseErrorType6.AuthorizationError,
                "not_found" => DeleteAssetCharacterResponseErrorType6.NotFound,
                "not_implemented" => DeleteAssetCharacterResponseErrorType6.NotImplemented,
                "rate_limited" => DeleteAssetCharacterResponseErrorType6.RateLimited,
                "server_error" => DeleteAssetCharacterResponseErrorType6.ServerError,
                "validation_error" => DeleteAssetCharacterResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}