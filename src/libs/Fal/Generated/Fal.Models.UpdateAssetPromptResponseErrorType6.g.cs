
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetPromptResponseErrorType6
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
    public static class UpdateAssetPromptResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetPromptResponseErrorType6 value)
        {
            return value switch
            {
                UpdateAssetPromptResponseErrorType6.AuthorizationError => "authorization_error",
                UpdateAssetPromptResponseErrorType6.NotFound => "not_found",
                UpdateAssetPromptResponseErrorType6.NotImplemented => "not_implemented",
                UpdateAssetPromptResponseErrorType6.RateLimited => "rate_limited",
                UpdateAssetPromptResponseErrorType6.ServerError => "server_error",
                UpdateAssetPromptResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetPromptResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetPromptResponseErrorType6.AuthorizationError,
                "not_found" => UpdateAssetPromptResponseErrorType6.NotFound,
                "not_implemented" => UpdateAssetPromptResponseErrorType6.NotImplemented,
                "rate_limited" => UpdateAssetPromptResponseErrorType6.RateLimited,
                "server_error" => UpdateAssetPromptResponseErrorType6.ServerError,
                "validation_error" => UpdateAssetPromptResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}