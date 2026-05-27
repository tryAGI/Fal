
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnassignAssetTagResponseErrorType9
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
    public static class UnassignAssetTagResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnassignAssetTagResponseErrorType9 value)
        {
            return value switch
            {
                UnassignAssetTagResponseErrorType9.AuthorizationError => "authorization_error",
                UnassignAssetTagResponseErrorType9.NotFound => "not_found",
                UnassignAssetTagResponseErrorType9.NotImplemented => "not_implemented",
                UnassignAssetTagResponseErrorType9.RateLimited => "rate_limited",
                UnassignAssetTagResponseErrorType9.ServerError => "server_error",
                UnassignAssetTagResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnassignAssetTagResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnassignAssetTagResponseErrorType9.AuthorizationError,
                "not_found" => UnassignAssetTagResponseErrorType9.NotFound,
                "not_implemented" => UnassignAssetTagResponseErrorType9.NotImplemented,
                "rate_limited" => UnassignAssetTagResponseErrorType9.RateLimited,
                "server_error" => UnassignAssetTagResponseErrorType9.ServerError,
                "validation_error" => UnassignAssetTagResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}