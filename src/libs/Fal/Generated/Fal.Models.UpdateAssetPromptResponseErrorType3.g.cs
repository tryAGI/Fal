
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetPromptResponseErrorType3
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
    public static class UpdateAssetPromptResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetPromptResponseErrorType3 value)
        {
            return value switch
            {
                UpdateAssetPromptResponseErrorType3.AuthorizationError => "authorization_error",
                UpdateAssetPromptResponseErrorType3.NotFound => "not_found",
                UpdateAssetPromptResponseErrorType3.NotImplemented => "not_implemented",
                UpdateAssetPromptResponseErrorType3.RateLimited => "rate_limited",
                UpdateAssetPromptResponseErrorType3.ServerError => "server_error",
                UpdateAssetPromptResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetPromptResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetPromptResponseErrorType3.AuthorizationError,
                "not_found" => UpdateAssetPromptResponseErrorType3.NotFound,
                "not_implemented" => UpdateAssetPromptResponseErrorType3.NotImplemented,
                "rate_limited" => UpdateAssetPromptResponseErrorType3.RateLimited,
                "server_error" => UpdateAssetPromptResponseErrorType3.ServerError,
                "validation_error" => UpdateAssetPromptResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}