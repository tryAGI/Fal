
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AddAssetToCollectionResponseErrorType8
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
    public static class AddAssetToCollectionResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddAssetToCollectionResponseErrorType8 value)
        {
            return value switch
            {
                AddAssetToCollectionResponseErrorType8.AuthorizationError => "authorization_error",
                AddAssetToCollectionResponseErrorType8.NotFound => "not_found",
                AddAssetToCollectionResponseErrorType8.NotImplemented => "not_implemented",
                AddAssetToCollectionResponseErrorType8.RateLimited => "rate_limited",
                AddAssetToCollectionResponseErrorType8.ServerError => "server_error",
                AddAssetToCollectionResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddAssetToCollectionResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AddAssetToCollectionResponseErrorType8.AuthorizationError,
                "not_found" => AddAssetToCollectionResponseErrorType8.NotFound,
                "not_implemented" => AddAssetToCollectionResponseErrorType8.NotImplemented,
                "rate_limited" => AddAssetToCollectionResponseErrorType8.RateLimited,
                "server_error" => AddAssetToCollectionResponseErrorType8.ServerError,
                "validation_error" => AddAssetToCollectionResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}