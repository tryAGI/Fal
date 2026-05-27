
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCollectionResponseErrorType4
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
    public static class DeleteAssetCollectionResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCollectionResponseErrorType4 value)
        {
            return value switch
            {
                DeleteAssetCollectionResponseErrorType4.AuthorizationError => "authorization_error",
                DeleteAssetCollectionResponseErrorType4.NotFound => "not_found",
                DeleteAssetCollectionResponseErrorType4.NotImplemented => "not_implemented",
                DeleteAssetCollectionResponseErrorType4.RateLimited => "rate_limited",
                DeleteAssetCollectionResponseErrorType4.ServerError => "server_error",
                DeleteAssetCollectionResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCollectionResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCollectionResponseErrorType4.AuthorizationError,
                "not_found" => DeleteAssetCollectionResponseErrorType4.NotFound,
                "not_implemented" => DeleteAssetCollectionResponseErrorType4.NotImplemented,
                "rate_limited" => DeleteAssetCollectionResponseErrorType4.RateLimited,
                "server_error" => DeleteAssetCollectionResponseErrorType4.ServerError,
                "validation_error" => DeleteAssetCollectionResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}