
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCollectionResponseErrorType5
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
    public static class DeleteAssetCollectionResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCollectionResponseErrorType5 value)
        {
            return value switch
            {
                DeleteAssetCollectionResponseErrorType5.AuthorizationError => "authorization_error",
                DeleteAssetCollectionResponseErrorType5.NotFound => "not_found",
                DeleteAssetCollectionResponseErrorType5.NotImplemented => "not_implemented",
                DeleteAssetCollectionResponseErrorType5.RateLimited => "rate_limited",
                DeleteAssetCollectionResponseErrorType5.ServerError => "server_error",
                DeleteAssetCollectionResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCollectionResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCollectionResponseErrorType5.AuthorizationError,
                "not_found" => DeleteAssetCollectionResponseErrorType5.NotFound,
                "not_implemented" => DeleteAssetCollectionResponseErrorType5.NotImplemented,
                "rate_limited" => DeleteAssetCollectionResponseErrorType5.RateLimited,
                "server_error" => DeleteAssetCollectionResponseErrorType5.ServerError,
                "validation_error" => DeleteAssetCollectionResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}