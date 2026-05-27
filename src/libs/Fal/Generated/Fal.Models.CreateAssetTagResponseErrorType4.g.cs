
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum CreateAssetTagResponseErrorType4
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
    public static class CreateAssetTagResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetTagResponseErrorType4 value)
        {
            return value switch
            {
                CreateAssetTagResponseErrorType4.AuthorizationError => "authorization_error",
                CreateAssetTagResponseErrorType4.NotFound => "not_found",
                CreateAssetTagResponseErrorType4.NotImplemented => "not_implemented",
                CreateAssetTagResponseErrorType4.RateLimited => "rate_limited",
                CreateAssetTagResponseErrorType4.ServerError => "server_error",
                CreateAssetTagResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetTagResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => CreateAssetTagResponseErrorType4.AuthorizationError,
                "not_found" => CreateAssetTagResponseErrorType4.NotFound,
                "not_implemented" => CreateAssetTagResponseErrorType4.NotImplemented,
                "rate_limited" => CreateAssetTagResponseErrorType4.RateLimited,
                "server_error" => CreateAssetTagResponseErrorType4.ServerError,
                "validation_error" => CreateAssetTagResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}