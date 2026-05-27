
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCollectionResponseErrorType7
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
    public static class CreateAssetCollectionResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCollectionResponseErrorType7 value)
        {
            return value switch
            {
                CreateAssetCollectionResponseErrorType7.AuthorizationError => "authorization_error",
                CreateAssetCollectionResponseErrorType7.NotFound => "not_found",
                CreateAssetCollectionResponseErrorType7.NotImplemented => "not_implemented",
                CreateAssetCollectionResponseErrorType7.RateLimited => "rate_limited",
                CreateAssetCollectionResponseErrorType7.ServerError => "server_error",
                CreateAssetCollectionResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCollectionResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCollectionResponseErrorType7.AuthorizationError,
                "not_found" => CreateAssetCollectionResponseErrorType7.NotFound,
                "not_implemented" => CreateAssetCollectionResponseErrorType7.NotImplemented,
                "rate_limited" => CreateAssetCollectionResponseErrorType7.RateLimited,
                "server_error" => CreateAssetCollectionResponseErrorType7.ServerError,
                "validation_error" => CreateAssetCollectionResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}