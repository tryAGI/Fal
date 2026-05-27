
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCharacterResponseErrorType4
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
    public static class DeleteAssetCharacterResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCharacterResponseErrorType4 value)
        {
            return value switch
            {
                DeleteAssetCharacterResponseErrorType4.AuthorizationError => "authorization_error",
                DeleteAssetCharacterResponseErrorType4.NotFound => "not_found",
                DeleteAssetCharacterResponseErrorType4.NotImplemented => "not_implemented",
                DeleteAssetCharacterResponseErrorType4.RateLimited => "rate_limited",
                DeleteAssetCharacterResponseErrorType4.ServerError => "server_error",
                DeleteAssetCharacterResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCharacterResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCharacterResponseErrorType4.AuthorizationError,
                "not_found" => DeleteAssetCharacterResponseErrorType4.NotFound,
                "not_implemented" => DeleteAssetCharacterResponseErrorType4.NotImplemented,
                "rate_limited" => DeleteAssetCharacterResponseErrorType4.RateLimited,
                "server_error" => DeleteAssetCharacterResponseErrorType4.ServerError,
                "validation_error" => DeleteAssetCharacterResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}