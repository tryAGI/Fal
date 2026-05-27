
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnassignAssetTagResponseErrorType6
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
    public static class UnassignAssetTagResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnassignAssetTagResponseErrorType6 value)
        {
            return value switch
            {
                UnassignAssetTagResponseErrorType6.AuthorizationError => "authorization_error",
                UnassignAssetTagResponseErrorType6.NotFound => "not_found",
                UnassignAssetTagResponseErrorType6.NotImplemented => "not_implemented",
                UnassignAssetTagResponseErrorType6.RateLimited => "rate_limited",
                UnassignAssetTagResponseErrorType6.ServerError => "server_error",
                UnassignAssetTagResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnassignAssetTagResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnassignAssetTagResponseErrorType6.AuthorizationError,
                "not_found" => UnassignAssetTagResponseErrorType6.NotFound,
                "not_implemented" => UnassignAssetTagResponseErrorType6.NotImplemented,
                "rate_limited" => UnassignAssetTagResponseErrorType6.RateLimited,
                "server_error" => UnassignAssetTagResponseErrorType6.ServerError,
                "validation_error" => UnassignAssetTagResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}