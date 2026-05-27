
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCollectionResponseErrorType5
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
    public static class UpdateAssetCollectionResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCollectionResponseErrorType5 value)
        {
            return value switch
            {
                UpdateAssetCollectionResponseErrorType5.AuthorizationError => "authorization_error",
                UpdateAssetCollectionResponseErrorType5.NotFound => "not_found",
                UpdateAssetCollectionResponseErrorType5.NotImplemented => "not_implemented",
                UpdateAssetCollectionResponseErrorType5.RateLimited => "rate_limited",
                UpdateAssetCollectionResponseErrorType5.ServerError => "server_error",
                UpdateAssetCollectionResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCollectionResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCollectionResponseErrorType5.AuthorizationError,
                "not_found" => UpdateAssetCollectionResponseErrorType5.NotFound,
                "not_implemented" => UpdateAssetCollectionResponseErrorType5.NotImplemented,
                "rate_limited" => UpdateAssetCollectionResponseErrorType5.RateLimited,
                "server_error" => UpdateAssetCollectionResponseErrorType5.ServerError,
                "validation_error" => UpdateAssetCollectionResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}