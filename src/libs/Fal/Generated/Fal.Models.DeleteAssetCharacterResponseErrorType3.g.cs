
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCharacterResponseErrorType3
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
    public static class DeleteAssetCharacterResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCharacterResponseErrorType3 value)
        {
            return value switch
            {
                DeleteAssetCharacterResponseErrorType3.AuthorizationError => "authorization_error",
                DeleteAssetCharacterResponseErrorType3.NotFound => "not_found",
                DeleteAssetCharacterResponseErrorType3.NotImplemented => "not_implemented",
                DeleteAssetCharacterResponseErrorType3.RateLimited => "rate_limited",
                DeleteAssetCharacterResponseErrorType3.ServerError => "server_error",
                DeleteAssetCharacterResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCharacterResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCharacterResponseErrorType3.AuthorizationError,
                "not_found" => DeleteAssetCharacterResponseErrorType3.NotFound,
                "not_implemented" => DeleteAssetCharacterResponseErrorType3.NotImplemented,
                "rate_limited" => DeleteAssetCharacterResponseErrorType3.RateLimited,
                "server_error" => DeleteAssetCharacterResponseErrorType3.ServerError,
                "validation_error" => DeleteAssetCharacterResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}