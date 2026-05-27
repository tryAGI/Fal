
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnassignAssetTagResponseErrorType4
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
    public static class UnassignAssetTagResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnassignAssetTagResponseErrorType4 value)
        {
            return value switch
            {
                UnassignAssetTagResponseErrorType4.AuthorizationError => "authorization_error",
                UnassignAssetTagResponseErrorType4.NotFound => "not_found",
                UnassignAssetTagResponseErrorType4.NotImplemented => "not_implemented",
                UnassignAssetTagResponseErrorType4.RateLimited => "rate_limited",
                UnassignAssetTagResponseErrorType4.ServerError => "server_error",
                UnassignAssetTagResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnassignAssetTagResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnassignAssetTagResponseErrorType4.AuthorizationError,
                "not_found" => UnassignAssetTagResponseErrorType4.NotFound,
                "not_implemented" => UnassignAssetTagResponseErrorType4.NotImplemented,
                "rate_limited" => UnassignAssetTagResponseErrorType4.RateLimited,
                "server_error" => UnassignAssetTagResponseErrorType4.ServerError,
                "validation_error" => UnassignAssetTagResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}