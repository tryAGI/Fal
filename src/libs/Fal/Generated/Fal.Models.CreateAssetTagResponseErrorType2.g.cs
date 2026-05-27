
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetTagResponseErrorType2
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
    public static class CreateAssetTagResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetTagResponseErrorType2 value)
        {
            return value switch
            {
                CreateAssetTagResponseErrorType2.AuthorizationError => "authorization_error",
                CreateAssetTagResponseErrorType2.NotFound => "not_found",
                CreateAssetTagResponseErrorType2.NotImplemented => "not_implemented",
                CreateAssetTagResponseErrorType2.RateLimited => "rate_limited",
                CreateAssetTagResponseErrorType2.ServerError => "server_error",
                CreateAssetTagResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetTagResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetTagResponseErrorType2.AuthorizationError,
                "not_found" => CreateAssetTagResponseErrorType2.NotFound,
                "not_implemented" => CreateAssetTagResponseErrorType2.NotImplemented,
                "rate_limited" => CreateAssetTagResponseErrorType2.RateLimited,
                "server_error" => CreateAssetTagResponseErrorType2.ServerError,
                "validation_error" => CreateAssetTagResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}