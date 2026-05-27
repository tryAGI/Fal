
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCollectionResponseErrorType2
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
    public static class DeleteAssetCollectionResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCollectionResponseErrorType2 value)
        {
            return value switch
            {
                DeleteAssetCollectionResponseErrorType2.AuthorizationError => "authorization_error",
                DeleteAssetCollectionResponseErrorType2.NotFound => "not_found",
                DeleteAssetCollectionResponseErrorType2.NotImplemented => "not_implemented",
                DeleteAssetCollectionResponseErrorType2.RateLimited => "rate_limited",
                DeleteAssetCollectionResponseErrorType2.ServerError => "server_error",
                DeleteAssetCollectionResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCollectionResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCollectionResponseErrorType2.AuthorizationError,
                "not_found" => DeleteAssetCollectionResponseErrorType2.NotFound,
                "not_implemented" => DeleteAssetCollectionResponseErrorType2.NotImplemented,
                "rate_limited" => DeleteAssetCollectionResponseErrorType2.RateLimited,
                "server_error" => DeleteAssetCollectionResponseErrorType2.ServerError,
                "validation_error" => DeleteAssetCollectionResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}