
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCollectionResponseErrorType9
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
    public static class UpdateAssetCollectionResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCollectionResponseErrorType9 value)
        {
            return value switch
            {
                UpdateAssetCollectionResponseErrorType9.AuthorizationError => "authorization_error",
                UpdateAssetCollectionResponseErrorType9.NotFound => "not_found",
                UpdateAssetCollectionResponseErrorType9.NotImplemented => "not_implemented",
                UpdateAssetCollectionResponseErrorType9.RateLimited => "rate_limited",
                UpdateAssetCollectionResponseErrorType9.ServerError => "server_error",
                UpdateAssetCollectionResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCollectionResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCollectionResponseErrorType9.AuthorizationError,
                "not_found" => UpdateAssetCollectionResponseErrorType9.NotFound,
                "not_implemented" => UpdateAssetCollectionResponseErrorType9.NotImplemented,
                "rate_limited" => UpdateAssetCollectionResponseErrorType9.RateLimited,
                "server_error" => UpdateAssetCollectionResponseErrorType9.ServerError,
                "validation_error" => UpdateAssetCollectionResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}