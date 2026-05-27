
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnassignAssetTagResponseErrorType
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
    public static class UnassignAssetTagResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnassignAssetTagResponseErrorType value)
        {
            return value switch
            {
                UnassignAssetTagResponseErrorType.AuthorizationError => "authorization_error",
                UnassignAssetTagResponseErrorType.NotFound => "not_found",
                UnassignAssetTagResponseErrorType.NotImplemented => "not_implemented",
                UnassignAssetTagResponseErrorType.RateLimited => "rate_limited",
                UnassignAssetTagResponseErrorType.ServerError => "server_error",
                UnassignAssetTagResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnassignAssetTagResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnassignAssetTagResponseErrorType.AuthorizationError,
                "not_found" => UnassignAssetTagResponseErrorType.NotFound,
                "not_implemented" => UnassignAssetTagResponseErrorType.NotImplemented,
                "rate_limited" => UnassignAssetTagResponseErrorType.RateLimited,
                "server_error" => UnassignAssetTagResponseErrorType.ServerError,
                "validation_error" => UnassignAssetTagResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}