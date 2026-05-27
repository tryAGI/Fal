
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AddAssetToCollectionResponseErrorType3
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
    public static class AddAssetToCollectionResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddAssetToCollectionResponseErrorType3 value)
        {
            return value switch
            {
                AddAssetToCollectionResponseErrorType3.AuthorizationError => "authorization_error",
                AddAssetToCollectionResponseErrorType3.NotFound => "not_found",
                AddAssetToCollectionResponseErrorType3.NotImplemented => "not_implemented",
                AddAssetToCollectionResponseErrorType3.RateLimited => "rate_limited",
                AddAssetToCollectionResponseErrorType3.ServerError => "server_error",
                AddAssetToCollectionResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddAssetToCollectionResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AddAssetToCollectionResponseErrorType3.AuthorizationError,
                "not_found" => AddAssetToCollectionResponseErrorType3.NotFound,
                "not_implemented" => AddAssetToCollectionResponseErrorType3.NotImplemented,
                "rate_limited" => AddAssetToCollectionResponseErrorType3.RateLimited,
                "server_error" => AddAssetToCollectionResponseErrorType3.ServerError,
                "validation_error" => AddAssetToCollectionResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}