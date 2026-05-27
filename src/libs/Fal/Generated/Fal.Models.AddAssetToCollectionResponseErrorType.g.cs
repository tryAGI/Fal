
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AddAssetToCollectionResponseErrorType
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
    public static class AddAssetToCollectionResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddAssetToCollectionResponseErrorType value)
        {
            return value switch
            {
                AddAssetToCollectionResponseErrorType.AuthorizationError => "authorization_error",
                AddAssetToCollectionResponseErrorType.NotFound => "not_found",
                AddAssetToCollectionResponseErrorType.NotImplemented => "not_implemented",
                AddAssetToCollectionResponseErrorType.RateLimited => "rate_limited",
                AddAssetToCollectionResponseErrorType.ServerError => "server_error",
                AddAssetToCollectionResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddAssetToCollectionResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AddAssetToCollectionResponseErrorType.AuthorizationError,
                "not_found" => AddAssetToCollectionResponseErrorType.NotFound,
                "not_implemented" => AddAssetToCollectionResponseErrorType.NotImplemented,
                "rate_limited" => AddAssetToCollectionResponseErrorType.RateLimited,
                "server_error" => AddAssetToCollectionResponseErrorType.ServerError,
                "validation_error" => AddAssetToCollectionResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}