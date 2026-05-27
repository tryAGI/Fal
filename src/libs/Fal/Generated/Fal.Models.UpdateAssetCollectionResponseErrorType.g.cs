
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCollectionResponseErrorType
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
    public static class UpdateAssetCollectionResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCollectionResponseErrorType value)
        {
            return value switch
            {
                UpdateAssetCollectionResponseErrorType.AuthorizationError => "authorization_error",
                UpdateAssetCollectionResponseErrorType.NotFound => "not_found",
                UpdateAssetCollectionResponseErrorType.NotImplemented => "not_implemented",
                UpdateAssetCollectionResponseErrorType.RateLimited => "rate_limited",
                UpdateAssetCollectionResponseErrorType.ServerError => "server_error",
                UpdateAssetCollectionResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCollectionResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCollectionResponseErrorType.AuthorizationError,
                "not_found" => UpdateAssetCollectionResponseErrorType.NotFound,
                "not_implemented" => UpdateAssetCollectionResponseErrorType.NotImplemented,
                "rate_limited" => UpdateAssetCollectionResponseErrorType.RateLimited,
                "server_error" => UpdateAssetCollectionResponseErrorType.ServerError,
                "validation_error" => UpdateAssetCollectionResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}