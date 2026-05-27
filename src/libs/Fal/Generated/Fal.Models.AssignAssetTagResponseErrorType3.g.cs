
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AssignAssetTagResponseErrorType3
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
    public static class AssignAssetTagResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignAssetTagResponseErrorType3 value)
        {
            return value switch
            {
                AssignAssetTagResponseErrorType3.AuthorizationError => "authorization_error",
                AssignAssetTagResponseErrorType3.NotFound => "not_found",
                AssignAssetTagResponseErrorType3.NotImplemented => "not_implemented",
                AssignAssetTagResponseErrorType3.RateLimited => "rate_limited",
                AssignAssetTagResponseErrorType3.ServerError => "server_error",
                AssignAssetTagResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignAssetTagResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AssignAssetTagResponseErrorType3.AuthorizationError,
                "not_found" => AssignAssetTagResponseErrorType3.NotFound,
                "not_implemented" => AssignAssetTagResponseErrorType3.NotImplemented,
                "rate_limited" => AssignAssetTagResponseErrorType3.RateLimited,
                "server_error" => AssignAssetTagResponseErrorType3.ServerError,
                "validation_error" => AssignAssetTagResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}