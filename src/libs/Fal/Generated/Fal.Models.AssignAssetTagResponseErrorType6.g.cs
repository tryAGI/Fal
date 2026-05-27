
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AssignAssetTagResponseErrorType6
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
    public static class AssignAssetTagResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignAssetTagResponseErrorType6 value)
        {
            return value switch
            {
                AssignAssetTagResponseErrorType6.AuthorizationError => "authorization_error",
                AssignAssetTagResponseErrorType6.NotFound => "not_found",
                AssignAssetTagResponseErrorType6.NotImplemented => "not_implemented",
                AssignAssetTagResponseErrorType6.RateLimited => "rate_limited",
                AssignAssetTagResponseErrorType6.ServerError => "server_error",
                AssignAssetTagResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignAssetTagResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AssignAssetTagResponseErrorType6.AuthorizationError,
                "not_found" => AssignAssetTagResponseErrorType6.NotFound,
                "not_implemented" => AssignAssetTagResponseErrorType6.NotImplemented,
                "rate_limited" => AssignAssetTagResponseErrorType6.RateLimited,
                "server_error" => AssignAssetTagResponseErrorType6.ServerError,
                "validation_error" => AssignAssetTagResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}