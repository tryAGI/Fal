
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnassignAssetTagResponseErrorType7
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
    public static class UnassignAssetTagResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnassignAssetTagResponseErrorType7 value)
        {
            return value switch
            {
                UnassignAssetTagResponseErrorType7.AuthorizationError => "authorization_error",
                UnassignAssetTagResponseErrorType7.NotFound => "not_found",
                UnassignAssetTagResponseErrorType7.NotImplemented => "not_implemented",
                UnassignAssetTagResponseErrorType7.RateLimited => "rate_limited",
                UnassignAssetTagResponseErrorType7.ServerError => "server_error",
                UnassignAssetTagResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnassignAssetTagResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnassignAssetTagResponseErrorType7.AuthorizationError,
                "not_found" => UnassignAssetTagResponseErrorType7.NotFound,
                "not_implemented" => UnassignAssetTagResponseErrorType7.NotImplemented,
                "rate_limited" => UnassignAssetTagResponseErrorType7.RateLimited,
                "server_error" => UnassignAssetTagResponseErrorType7.ServerError,
                "validation_error" => UnassignAssetTagResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}