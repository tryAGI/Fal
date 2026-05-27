
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCharacterResponseErrorType5
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
    public static class DeleteAssetCharacterResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCharacterResponseErrorType5 value)
        {
            return value switch
            {
                DeleteAssetCharacterResponseErrorType5.AuthorizationError => "authorization_error",
                DeleteAssetCharacterResponseErrorType5.NotFound => "not_found",
                DeleteAssetCharacterResponseErrorType5.NotImplemented => "not_implemented",
                DeleteAssetCharacterResponseErrorType5.RateLimited => "rate_limited",
                DeleteAssetCharacterResponseErrorType5.ServerError => "server_error",
                DeleteAssetCharacterResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCharacterResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCharacterResponseErrorType5.AuthorizationError,
                "not_found" => DeleteAssetCharacterResponseErrorType5.NotFound,
                "not_implemented" => DeleteAssetCharacterResponseErrorType5.NotImplemented,
                "rate_limited" => DeleteAssetCharacterResponseErrorType5.RateLimited,
                "server_error" => DeleteAssetCharacterResponseErrorType5.ServerError,
                "validation_error" => DeleteAssetCharacterResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}