
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCollectionResponseErrorType7
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
    public static class DeleteAssetCollectionResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCollectionResponseErrorType7 value)
        {
            return value switch
            {
                DeleteAssetCollectionResponseErrorType7.AuthorizationError => "authorization_error",
                DeleteAssetCollectionResponseErrorType7.NotFound => "not_found",
                DeleteAssetCollectionResponseErrorType7.NotImplemented => "not_implemented",
                DeleteAssetCollectionResponseErrorType7.RateLimited => "rate_limited",
                DeleteAssetCollectionResponseErrorType7.ServerError => "server_error",
                DeleteAssetCollectionResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCollectionResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCollectionResponseErrorType7.AuthorizationError,
                "not_found" => DeleteAssetCollectionResponseErrorType7.NotFound,
                "not_implemented" => DeleteAssetCollectionResponseErrorType7.NotImplemented,
                "rate_limited" => DeleteAssetCollectionResponseErrorType7.RateLimited,
                "server_error" => DeleteAssetCollectionResponseErrorType7.ServerError,
                "validation_error" => DeleteAssetCollectionResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}