
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCollectionResponseErrorType3
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
    public static class DeleteAssetCollectionResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCollectionResponseErrorType3 value)
        {
            return value switch
            {
                DeleteAssetCollectionResponseErrorType3.AuthorizationError => "authorization_error",
                DeleteAssetCollectionResponseErrorType3.NotFound => "not_found",
                DeleteAssetCollectionResponseErrorType3.NotImplemented => "not_implemented",
                DeleteAssetCollectionResponseErrorType3.RateLimited => "rate_limited",
                DeleteAssetCollectionResponseErrorType3.ServerError => "server_error",
                DeleteAssetCollectionResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCollectionResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCollectionResponseErrorType3.AuthorizationError,
                "not_found" => DeleteAssetCollectionResponseErrorType3.NotFound,
                "not_implemented" => DeleteAssetCollectionResponseErrorType3.NotImplemented,
                "rate_limited" => DeleteAssetCollectionResponseErrorType3.RateLimited,
                "server_error" => DeleteAssetCollectionResponseErrorType3.ServerError,
                "validation_error" => DeleteAssetCollectionResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}