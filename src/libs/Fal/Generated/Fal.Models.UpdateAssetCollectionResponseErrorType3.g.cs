
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCollectionResponseErrorType3
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
    public static class UpdateAssetCollectionResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCollectionResponseErrorType3 value)
        {
            return value switch
            {
                UpdateAssetCollectionResponseErrorType3.AuthorizationError => "authorization_error",
                UpdateAssetCollectionResponseErrorType3.NotFound => "not_found",
                UpdateAssetCollectionResponseErrorType3.NotImplemented => "not_implemented",
                UpdateAssetCollectionResponseErrorType3.RateLimited => "rate_limited",
                UpdateAssetCollectionResponseErrorType3.ServerError => "server_error",
                UpdateAssetCollectionResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCollectionResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCollectionResponseErrorType3.AuthorizationError,
                "not_found" => UpdateAssetCollectionResponseErrorType3.NotFound,
                "not_implemented" => UpdateAssetCollectionResponseErrorType3.NotImplemented,
                "rate_limited" => UpdateAssetCollectionResponseErrorType3.RateLimited,
                "server_error" => UpdateAssetCollectionResponseErrorType3.ServerError,
                "validation_error" => UpdateAssetCollectionResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}