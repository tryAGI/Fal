
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnassignAssetTagResponseErrorType2
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
    public static class UnassignAssetTagResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnassignAssetTagResponseErrorType2 value)
        {
            return value switch
            {
                UnassignAssetTagResponseErrorType2.AuthorizationError => "authorization_error",
                UnassignAssetTagResponseErrorType2.NotFound => "not_found",
                UnassignAssetTagResponseErrorType2.NotImplemented => "not_implemented",
                UnassignAssetTagResponseErrorType2.RateLimited => "rate_limited",
                UnassignAssetTagResponseErrorType2.ServerError => "server_error",
                UnassignAssetTagResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnassignAssetTagResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnassignAssetTagResponseErrorType2.AuthorizationError,
                "not_found" => UnassignAssetTagResponseErrorType2.NotFound,
                "not_implemented" => UnassignAssetTagResponseErrorType2.NotImplemented,
                "rate_limited" => UnassignAssetTagResponseErrorType2.RateLimited,
                "server_error" => UnassignAssetTagResponseErrorType2.ServerError,
                "validation_error" => UnassignAssetTagResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}