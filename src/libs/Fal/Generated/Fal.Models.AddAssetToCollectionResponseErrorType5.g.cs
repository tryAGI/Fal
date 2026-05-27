
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AddAssetToCollectionResponseErrorType5
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
    public static class AddAssetToCollectionResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddAssetToCollectionResponseErrorType5 value)
        {
            return value switch
            {
                AddAssetToCollectionResponseErrorType5.AuthorizationError => "authorization_error",
                AddAssetToCollectionResponseErrorType5.NotFound => "not_found",
                AddAssetToCollectionResponseErrorType5.NotImplemented => "not_implemented",
                AddAssetToCollectionResponseErrorType5.RateLimited => "rate_limited",
                AddAssetToCollectionResponseErrorType5.ServerError => "server_error",
                AddAssetToCollectionResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddAssetToCollectionResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AddAssetToCollectionResponseErrorType5.AuthorizationError,
                "not_found" => AddAssetToCollectionResponseErrorType5.NotFound,
                "not_implemented" => AddAssetToCollectionResponseErrorType5.NotImplemented,
                "rate_limited" => AddAssetToCollectionResponseErrorType5.RateLimited,
                "server_error" => AddAssetToCollectionResponseErrorType5.ServerError,
                "validation_error" => AddAssetToCollectionResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}