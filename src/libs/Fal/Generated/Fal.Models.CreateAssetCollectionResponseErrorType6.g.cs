
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCollectionResponseErrorType6
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
    public static class CreateAssetCollectionResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCollectionResponseErrorType6 value)
        {
            return value switch
            {
                CreateAssetCollectionResponseErrorType6.AuthorizationError => "authorization_error",
                CreateAssetCollectionResponseErrorType6.NotFound => "not_found",
                CreateAssetCollectionResponseErrorType6.NotImplemented => "not_implemented",
                CreateAssetCollectionResponseErrorType6.RateLimited => "rate_limited",
                CreateAssetCollectionResponseErrorType6.ServerError => "server_error",
                CreateAssetCollectionResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCollectionResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCollectionResponseErrorType6.AuthorizationError,
                "not_found" => CreateAssetCollectionResponseErrorType6.NotFound,
                "not_implemented" => CreateAssetCollectionResponseErrorType6.NotImplemented,
                "rate_limited" => CreateAssetCollectionResponseErrorType6.RateLimited,
                "server_error" => CreateAssetCollectionResponseErrorType6.ServerError,
                "validation_error" => CreateAssetCollectionResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}