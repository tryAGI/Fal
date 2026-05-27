
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetPromptResponseErrorType5
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
    public static class UpdateAssetPromptResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetPromptResponseErrorType5 value)
        {
            return value switch
            {
                UpdateAssetPromptResponseErrorType5.AuthorizationError => "authorization_error",
                UpdateAssetPromptResponseErrorType5.NotFound => "not_found",
                UpdateAssetPromptResponseErrorType5.NotImplemented => "not_implemented",
                UpdateAssetPromptResponseErrorType5.RateLimited => "rate_limited",
                UpdateAssetPromptResponseErrorType5.ServerError => "server_error",
                UpdateAssetPromptResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetPromptResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetPromptResponseErrorType5.AuthorizationError,
                "not_found" => UpdateAssetPromptResponseErrorType5.NotFound,
                "not_implemented" => UpdateAssetPromptResponseErrorType5.NotImplemented,
                "rate_limited" => UpdateAssetPromptResponseErrorType5.RateLimited,
                "server_error" => UpdateAssetPromptResponseErrorType5.ServerError,
                "validation_error" => UpdateAssetPromptResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}