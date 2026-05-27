
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AddAssetToCollectionResponseErrorType2
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
    public static class AddAssetToCollectionResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddAssetToCollectionResponseErrorType2 value)
        {
            return value switch
            {
                AddAssetToCollectionResponseErrorType2.AuthorizationError => "authorization_error",
                AddAssetToCollectionResponseErrorType2.NotFound => "not_found",
                AddAssetToCollectionResponseErrorType2.NotImplemented => "not_implemented",
                AddAssetToCollectionResponseErrorType2.RateLimited => "rate_limited",
                AddAssetToCollectionResponseErrorType2.ServerError => "server_error",
                AddAssetToCollectionResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddAssetToCollectionResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AddAssetToCollectionResponseErrorType2.AuthorizationError,
                "not_found" => AddAssetToCollectionResponseErrorType2.NotFound,
                "not_implemented" => AddAssetToCollectionResponseErrorType2.NotImplemented,
                "rate_limited" => AddAssetToCollectionResponseErrorType2.RateLimited,
                "server_error" => AddAssetToCollectionResponseErrorType2.ServerError,
                "validation_error" => AddAssetToCollectionResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}