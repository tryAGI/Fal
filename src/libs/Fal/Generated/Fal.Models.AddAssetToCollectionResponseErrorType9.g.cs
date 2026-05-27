
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AddAssetToCollectionResponseErrorType9
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
    public static class AddAssetToCollectionResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddAssetToCollectionResponseErrorType9 value)
        {
            return value switch
            {
                AddAssetToCollectionResponseErrorType9.AuthorizationError => "authorization_error",
                AddAssetToCollectionResponseErrorType9.NotFound => "not_found",
                AddAssetToCollectionResponseErrorType9.NotImplemented => "not_implemented",
                AddAssetToCollectionResponseErrorType9.RateLimited => "rate_limited",
                AddAssetToCollectionResponseErrorType9.ServerError => "server_error",
                AddAssetToCollectionResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddAssetToCollectionResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AddAssetToCollectionResponseErrorType9.AuthorizationError,
                "not_found" => AddAssetToCollectionResponseErrorType9.NotFound,
                "not_implemented" => AddAssetToCollectionResponseErrorType9.NotImplemented,
                "rate_limited" => AddAssetToCollectionResponseErrorType9.RateLimited,
                "server_error" => AddAssetToCollectionResponseErrorType9.ServerError,
                "validation_error" => AddAssetToCollectionResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}