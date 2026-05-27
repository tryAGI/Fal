
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UpdateAssetCollectionResponseErrorType8
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
    public static class UpdateAssetCollectionResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssetCollectionResponseErrorType8 value)
        {
            return value switch
            {
                UpdateAssetCollectionResponseErrorType8.AuthorizationError => "authorization_error",
                UpdateAssetCollectionResponseErrorType8.NotFound => "not_found",
                UpdateAssetCollectionResponseErrorType8.NotImplemented => "not_implemented",
                UpdateAssetCollectionResponseErrorType8.RateLimited => "rate_limited",
                UpdateAssetCollectionResponseErrorType8.ServerError => "server_error",
                UpdateAssetCollectionResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssetCollectionResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UpdateAssetCollectionResponseErrorType8.AuthorizationError,
                "not_found" => UpdateAssetCollectionResponseErrorType8.NotFound,
                "not_implemented" => UpdateAssetCollectionResponseErrorType8.NotImplemented,
                "rate_limited" => UpdateAssetCollectionResponseErrorType8.RateLimited,
                "server_error" => UpdateAssetCollectionResponseErrorType8.ServerError,
                "validation_error" => UpdateAssetCollectionResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}