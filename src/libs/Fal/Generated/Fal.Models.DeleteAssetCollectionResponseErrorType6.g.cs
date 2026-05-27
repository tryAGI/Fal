
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCollectionResponseErrorType6
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
    public static class DeleteAssetCollectionResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCollectionResponseErrorType6 value)
        {
            return value switch
            {
                DeleteAssetCollectionResponseErrorType6.AuthorizationError => "authorization_error",
                DeleteAssetCollectionResponseErrorType6.NotFound => "not_found",
                DeleteAssetCollectionResponseErrorType6.NotImplemented => "not_implemented",
                DeleteAssetCollectionResponseErrorType6.RateLimited => "rate_limited",
                DeleteAssetCollectionResponseErrorType6.ServerError => "server_error",
                DeleteAssetCollectionResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCollectionResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCollectionResponseErrorType6.AuthorizationError,
                "not_found" => DeleteAssetCollectionResponseErrorType6.NotFound,
                "not_implemented" => DeleteAssetCollectionResponseErrorType6.NotImplemented,
                "rate_limited" => DeleteAssetCollectionResponseErrorType6.RateLimited,
                "server_error" => DeleteAssetCollectionResponseErrorType6.ServerError,
                "validation_error" => DeleteAssetCollectionResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}