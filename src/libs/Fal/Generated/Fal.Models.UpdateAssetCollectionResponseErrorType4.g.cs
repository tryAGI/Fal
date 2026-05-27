
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCollectionResponseErrorType4
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
    public static class UpdateAssetCollectionResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCollectionResponseErrorType4 value)
        {
            return value switch
            {
                UpdateAssetCollectionResponseErrorType4.AuthorizationError => "authorization_error",
                UpdateAssetCollectionResponseErrorType4.NotFound => "not_found",
                UpdateAssetCollectionResponseErrorType4.NotImplemented => "not_implemented",
                UpdateAssetCollectionResponseErrorType4.RateLimited => "rate_limited",
                UpdateAssetCollectionResponseErrorType4.ServerError => "server_error",
                UpdateAssetCollectionResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCollectionResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCollectionResponseErrorType4.AuthorizationError,
                "not_found" => UpdateAssetCollectionResponseErrorType4.NotFound,
                "not_implemented" => UpdateAssetCollectionResponseErrorType4.NotImplemented,
                "rate_limited" => UpdateAssetCollectionResponseErrorType4.RateLimited,
                "server_error" => UpdateAssetCollectionResponseErrorType4.ServerError,
                "validation_error" => UpdateAssetCollectionResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}