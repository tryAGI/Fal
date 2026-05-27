
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCollectionResponseErrorType9
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
    public static class DeleteAssetCollectionResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCollectionResponseErrorType9 value)
        {
            return value switch
            {
                DeleteAssetCollectionResponseErrorType9.AuthorizationError => "authorization_error",
                DeleteAssetCollectionResponseErrorType9.NotFound => "not_found",
                DeleteAssetCollectionResponseErrorType9.NotImplemented => "not_implemented",
                DeleteAssetCollectionResponseErrorType9.RateLimited => "rate_limited",
                DeleteAssetCollectionResponseErrorType9.ServerError => "server_error",
                DeleteAssetCollectionResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCollectionResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCollectionResponseErrorType9.AuthorizationError,
                "not_found" => DeleteAssetCollectionResponseErrorType9.NotFound,
                "not_implemented" => DeleteAssetCollectionResponseErrorType9.NotImplemented,
                "rate_limited" => DeleteAssetCollectionResponseErrorType9.RateLimited,
                "server_error" => DeleteAssetCollectionResponseErrorType9.ServerError,
                "validation_error" => DeleteAssetCollectionResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}