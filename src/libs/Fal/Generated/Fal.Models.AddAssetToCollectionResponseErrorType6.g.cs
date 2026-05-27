
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AddAssetToCollectionResponseErrorType6
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
    public static class AddAssetToCollectionResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddAssetToCollectionResponseErrorType6 value)
        {
            return value switch
            {
                AddAssetToCollectionResponseErrorType6.AuthorizationError => "authorization_error",
                AddAssetToCollectionResponseErrorType6.NotFound => "not_found",
                AddAssetToCollectionResponseErrorType6.NotImplemented => "not_implemented",
                AddAssetToCollectionResponseErrorType6.RateLimited => "rate_limited",
                AddAssetToCollectionResponseErrorType6.ServerError => "server_error",
                AddAssetToCollectionResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddAssetToCollectionResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AddAssetToCollectionResponseErrorType6.AuthorizationError,
                "not_found" => AddAssetToCollectionResponseErrorType6.NotFound,
                "not_implemented" => AddAssetToCollectionResponseErrorType6.NotImplemented,
                "rate_limited" => AddAssetToCollectionResponseErrorType6.RateLimited,
                "server_error" => AddAssetToCollectionResponseErrorType6.ServerError,
                "validation_error" => AddAssetToCollectionResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}