
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetTagResponseErrorType7
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
    public static class CreateAssetTagResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetTagResponseErrorType7 value)
        {
            return value switch
            {
                CreateAssetTagResponseErrorType7.AuthorizationError => "authorization_error",
                CreateAssetTagResponseErrorType7.NotFound => "not_found",
                CreateAssetTagResponseErrorType7.NotImplemented => "not_implemented",
                CreateAssetTagResponseErrorType7.RateLimited => "rate_limited",
                CreateAssetTagResponseErrorType7.ServerError => "server_error",
                CreateAssetTagResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetTagResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetTagResponseErrorType7.AuthorizationError,
                "not_found" => CreateAssetTagResponseErrorType7.NotFound,
                "not_implemented" => CreateAssetTagResponseErrorType7.NotImplemented,
                "rate_limited" => CreateAssetTagResponseErrorType7.RateLimited,
                "server_error" => CreateAssetTagResponseErrorType7.ServerError,
                "validation_error" => CreateAssetTagResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}