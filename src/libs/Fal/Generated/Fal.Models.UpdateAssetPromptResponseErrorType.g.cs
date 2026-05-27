
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetPromptResponseErrorType
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
    public static class UpdateAssetPromptResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetPromptResponseErrorType value)
        {
            return value switch
            {
                UpdateAssetPromptResponseErrorType.AuthorizationError => "authorization_error",
                UpdateAssetPromptResponseErrorType.NotFound => "not_found",
                UpdateAssetPromptResponseErrorType.NotImplemented => "not_implemented",
                UpdateAssetPromptResponseErrorType.RateLimited => "rate_limited",
                UpdateAssetPromptResponseErrorType.ServerError => "server_error",
                UpdateAssetPromptResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetPromptResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetPromptResponseErrorType.AuthorizationError,
                "not_found" => UpdateAssetPromptResponseErrorType.NotFound,
                "not_implemented" => UpdateAssetPromptResponseErrorType.NotImplemented,
                "rate_limited" => UpdateAssetPromptResponseErrorType.RateLimited,
                "server_error" => UpdateAssetPromptResponseErrorType.ServerError,
                "validation_error" => UpdateAssetPromptResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}