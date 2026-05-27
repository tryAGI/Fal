
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCharacterResponseErrorType9
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
    public static class DeleteAssetCharacterResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCharacterResponseErrorType9 value)
        {
            return value switch
            {
                DeleteAssetCharacterResponseErrorType9.AuthorizationError => "authorization_error",
                DeleteAssetCharacterResponseErrorType9.NotFound => "not_found",
                DeleteAssetCharacterResponseErrorType9.NotImplemented => "not_implemented",
                DeleteAssetCharacterResponseErrorType9.RateLimited => "rate_limited",
                DeleteAssetCharacterResponseErrorType9.ServerError => "server_error",
                DeleteAssetCharacterResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCharacterResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCharacterResponseErrorType9.AuthorizationError,
                "not_found" => DeleteAssetCharacterResponseErrorType9.NotFound,
                "not_implemented" => DeleteAssetCharacterResponseErrorType9.NotImplemented,
                "rate_limited" => DeleteAssetCharacterResponseErrorType9.RateLimited,
                "server_error" => DeleteAssetCharacterResponseErrorType9.ServerError,
                "validation_error" => DeleteAssetCharacterResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}