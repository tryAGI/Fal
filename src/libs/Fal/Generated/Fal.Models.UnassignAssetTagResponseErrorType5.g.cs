
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnassignAssetTagResponseErrorType5
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
    public static class UnassignAssetTagResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnassignAssetTagResponseErrorType5 value)
        {
            return value switch
            {
                UnassignAssetTagResponseErrorType5.AuthorizationError => "authorization_error",
                UnassignAssetTagResponseErrorType5.NotFound => "not_found",
                UnassignAssetTagResponseErrorType5.NotImplemented => "not_implemented",
                UnassignAssetTagResponseErrorType5.RateLimited => "rate_limited",
                UnassignAssetTagResponseErrorType5.ServerError => "server_error",
                UnassignAssetTagResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnassignAssetTagResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnassignAssetTagResponseErrorType5.AuthorizationError,
                "not_found" => UnassignAssetTagResponseErrorType5.NotFound,
                "not_implemented" => UnassignAssetTagResponseErrorType5.NotImplemented,
                "rate_limited" => UnassignAssetTagResponseErrorType5.RateLimited,
                "server_error" => UnassignAssetTagResponseErrorType5.ServerError,
                "validation_error" => UnassignAssetTagResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}