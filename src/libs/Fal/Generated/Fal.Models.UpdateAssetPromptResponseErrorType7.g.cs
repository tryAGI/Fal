
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetPromptResponseErrorType7
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
    public static class UpdateAssetPromptResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetPromptResponseErrorType7 value)
        {
            return value switch
            {
                UpdateAssetPromptResponseErrorType7.AuthorizationError => "authorization_error",
                UpdateAssetPromptResponseErrorType7.NotFound => "not_found",
                UpdateAssetPromptResponseErrorType7.NotImplemented => "not_implemented",
                UpdateAssetPromptResponseErrorType7.RateLimited => "rate_limited",
                UpdateAssetPromptResponseErrorType7.ServerError => "server_error",
                UpdateAssetPromptResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetPromptResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetPromptResponseErrorType7.AuthorizationError,
                "not_found" => UpdateAssetPromptResponseErrorType7.NotFound,
                "not_implemented" => UpdateAssetPromptResponseErrorType7.NotImplemented,
                "rate_limited" => UpdateAssetPromptResponseErrorType7.RateLimited,
                "server_error" => UpdateAssetPromptResponseErrorType7.ServerError,
                "validation_error" => UpdateAssetPromptResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}