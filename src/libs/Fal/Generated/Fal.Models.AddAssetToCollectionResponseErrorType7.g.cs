
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AddAssetToCollectionResponseErrorType7
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
    public static class AddAssetToCollectionResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddAssetToCollectionResponseErrorType7 value)
        {
            return value switch
            {
                AddAssetToCollectionResponseErrorType7.AuthorizationError => "authorization_error",
                AddAssetToCollectionResponseErrorType7.NotFound => "not_found",
                AddAssetToCollectionResponseErrorType7.NotImplemented => "not_implemented",
                AddAssetToCollectionResponseErrorType7.RateLimited => "rate_limited",
                AddAssetToCollectionResponseErrorType7.ServerError => "server_error",
                AddAssetToCollectionResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddAssetToCollectionResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AddAssetToCollectionResponseErrorType7.AuthorizationError,
                "not_found" => AddAssetToCollectionResponseErrorType7.NotFound,
                "not_implemented" => AddAssetToCollectionResponseErrorType7.NotImplemented,
                "rate_limited" => AddAssetToCollectionResponseErrorType7.RateLimited,
                "server_error" => AddAssetToCollectionResponseErrorType7.ServerError,
                "validation_error" => AddAssetToCollectionResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}