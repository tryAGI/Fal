
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum UnassignAssetTagResponseErrorType8
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
    public static class UnassignAssetTagResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnassignAssetTagResponseErrorType8 value)
        {
            return value switch
            {
                UnassignAssetTagResponseErrorType8.AuthorizationError => "authorization_error",
                UnassignAssetTagResponseErrorType8.NotFound => "not_found",
                UnassignAssetTagResponseErrorType8.NotImplemented => "not_implemented",
                UnassignAssetTagResponseErrorType8.RateLimited => "rate_limited",
                UnassignAssetTagResponseErrorType8.ServerError => "server_error",
                UnassignAssetTagResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnassignAssetTagResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => UnassignAssetTagResponseErrorType8.AuthorizationError,
                "not_found" => UnassignAssetTagResponseErrorType8.NotFound,
                "not_implemented" => UnassignAssetTagResponseErrorType8.NotImplemented,
                "rate_limited" => UnassignAssetTagResponseErrorType8.RateLimited,
                "server_error" => UnassignAssetTagResponseErrorType8.ServerError,
                "validation_error" => UnassignAssetTagResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}