
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum DeleteAssetCollectionResponseErrorType8
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
    public static class DeleteAssetCollectionResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssetCollectionResponseErrorType8 value)
        {
            return value switch
            {
                DeleteAssetCollectionResponseErrorType8.AuthorizationError => "authorization_error",
                DeleteAssetCollectionResponseErrorType8.NotFound => "not_found",
                DeleteAssetCollectionResponseErrorType8.NotImplemented => "not_implemented",
                DeleteAssetCollectionResponseErrorType8.RateLimited => "rate_limited",
                DeleteAssetCollectionResponseErrorType8.ServerError => "server_error",
                DeleteAssetCollectionResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssetCollectionResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => DeleteAssetCollectionResponseErrorType8.AuthorizationError,
                "not_found" => DeleteAssetCollectionResponseErrorType8.NotFound,
                "not_implemented" => DeleteAssetCollectionResponseErrorType8.NotImplemented,
                "rate_limited" => DeleteAssetCollectionResponseErrorType8.RateLimited,
                "server_error" => DeleteAssetCollectionResponseErrorType8.ServerError,
                "validation_error" => DeleteAssetCollectionResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}