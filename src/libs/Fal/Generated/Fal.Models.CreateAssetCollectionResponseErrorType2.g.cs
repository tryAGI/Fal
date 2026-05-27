
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCollectionResponseErrorType2
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
    public static class CreateAssetCollectionResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCollectionResponseErrorType2 value)
        {
            return value switch
            {
                CreateAssetCollectionResponseErrorType2.AuthorizationError => "authorization_error",
                CreateAssetCollectionResponseErrorType2.NotFound => "not_found",
                CreateAssetCollectionResponseErrorType2.NotImplemented => "not_implemented",
                CreateAssetCollectionResponseErrorType2.RateLimited => "rate_limited",
                CreateAssetCollectionResponseErrorType2.ServerError => "server_error",
                CreateAssetCollectionResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCollectionResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCollectionResponseErrorType2.AuthorizationError,
                "not_found" => CreateAssetCollectionResponseErrorType2.NotFound,
                "not_implemented" => CreateAssetCollectionResponseErrorType2.NotImplemented,
                "rate_limited" => CreateAssetCollectionResponseErrorType2.RateLimited,
                "server_error" => CreateAssetCollectionResponseErrorType2.ServerError,
                "validation_error" => CreateAssetCollectionResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}