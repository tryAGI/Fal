
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AssignAssetTagResponseErrorType9
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
    public static class AssignAssetTagResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignAssetTagResponseErrorType9 value)
        {
            return value switch
            {
                AssignAssetTagResponseErrorType9.AuthorizationError => "authorization_error",
                AssignAssetTagResponseErrorType9.NotFound => "not_found",
                AssignAssetTagResponseErrorType9.NotImplemented => "not_implemented",
                AssignAssetTagResponseErrorType9.RateLimited => "rate_limited",
                AssignAssetTagResponseErrorType9.ServerError => "server_error",
                AssignAssetTagResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignAssetTagResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AssignAssetTagResponseErrorType9.AuthorizationError,
                "not_found" => AssignAssetTagResponseErrorType9.NotFound,
                "not_implemented" => AssignAssetTagResponseErrorType9.NotImplemented,
                "rate_limited" => AssignAssetTagResponseErrorType9.RateLimited,
                "server_error" => AssignAssetTagResponseErrorType9.ServerError,
                "validation_error" => AssignAssetTagResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}