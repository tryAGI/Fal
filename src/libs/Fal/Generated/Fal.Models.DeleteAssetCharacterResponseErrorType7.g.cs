
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCharacterResponseErrorType7
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
    public static class DeleteAssetCharacterResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCharacterResponseErrorType7 value)
        {
            return value switch
            {
                DeleteAssetCharacterResponseErrorType7.AuthorizationError => "authorization_error",
                DeleteAssetCharacterResponseErrorType7.NotFound => "not_found",
                DeleteAssetCharacterResponseErrorType7.NotImplemented => "not_implemented",
                DeleteAssetCharacterResponseErrorType7.RateLimited => "rate_limited",
                DeleteAssetCharacterResponseErrorType7.ServerError => "server_error",
                DeleteAssetCharacterResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCharacterResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCharacterResponseErrorType7.AuthorizationError,
                "not_found" => DeleteAssetCharacterResponseErrorType7.NotFound,
                "not_implemented" => DeleteAssetCharacterResponseErrorType7.NotImplemented,
                "rate_limited" => DeleteAssetCharacterResponseErrorType7.RateLimited,
                "server_error" => DeleteAssetCharacterResponseErrorType7.ServerError,
                "validation_error" => DeleteAssetCharacterResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}