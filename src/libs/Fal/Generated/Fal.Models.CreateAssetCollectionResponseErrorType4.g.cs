
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetCollectionResponseErrorType4
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
    public static class CreateAssetCollectionResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetCollectionResponseErrorType4 value)
        {
            return value switch
            {
                CreateAssetCollectionResponseErrorType4.AuthorizationError => "authorization_error",
                CreateAssetCollectionResponseErrorType4.NotFound => "not_found",
                CreateAssetCollectionResponseErrorType4.NotImplemented => "not_implemented",
                CreateAssetCollectionResponseErrorType4.RateLimited => "rate_limited",
                CreateAssetCollectionResponseErrorType4.ServerError => "server_error",
                CreateAssetCollectionResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetCollectionResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetCollectionResponseErrorType4.AuthorizationError,
                "not_found" => CreateAssetCollectionResponseErrorType4.NotFound,
                "not_implemented" => CreateAssetCollectionResponseErrorType4.NotImplemented,
                "rate_limited" => CreateAssetCollectionResponseErrorType4.RateLimited,
                "server_error" => CreateAssetCollectionResponseErrorType4.ServerError,
                "validation_error" => CreateAssetCollectionResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}