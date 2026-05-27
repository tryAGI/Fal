
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCollectionResponseErrorType6
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
    public static class UpdateAssetCollectionResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCollectionResponseErrorType6 value)
        {
            return value switch
            {
                UpdateAssetCollectionResponseErrorType6.AuthorizationError => "authorization_error",
                UpdateAssetCollectionResponseErrorType6.NotFound => "not_found",
                UpdateAssetCollectionResponseErrorType6.NotImplemented => "not_implemented",
                UpdateAssetCollectionResponseErrorType6.RateLimited => "rate_limited",
                UpdateAssetCollectionResponseErrorType6.ServerError => "server_error",
                UpdateAssetCollectionResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCollectionResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCollectionResponseErrorType6.AuthorizationError,
                "not_found" => UpdateAssetCollectionResponseErrorType6.NotFound,
                "not_implemented" => UpdateAssetCollectionResponseErrorType6.NotImplemented,
                "rate_limited" => UpdateAssetCollectionResponseErrorType6.RateLimited,
                "server_error" => UpdateAssetCollectionResponseErrorType6.ServerError,
                "validation_error" => UpdateAssetCollectionResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}