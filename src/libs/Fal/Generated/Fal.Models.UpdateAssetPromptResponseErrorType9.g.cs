
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetPromptResponseErrorType9
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
    public static class UpdateAssetPromptResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetPromptResponseErrorType9 value)
        {
            return value switch
            {
                UpdateAssetPromptResponseErrorType9.AuthorizationError => "authorization_error",
                UpdateAssetPromptResponseErrorType9.NotFound => "not_found",
                UpdateAssetPromptResponseErrorType9.NotImplemented => "not_implemented",
                UpdateAssetPromptResponseErrorType9.RateLimited => "rate_limited",
                UpdateAssetPromptResponseErrorType9.ServerError => "server_error",
                UpdateAssetPromptResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetPromptResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetPromptResponseErrorType9.AuthorizationError,
                "not_found" => UpdateAssetPromptResponseErrorType9.NotFound,
                "not_implemented" => UpdateAssetPromptResponseErrorType9.NotImplemented,
                "rate_limited" => UpdateAssetPromptResponseErrorType9.RateLimited,
                "server_error" => UpdateAssetPromptResponseErrorType9.ServerError,
                "validation_error" => UpdateAssetPromptResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}