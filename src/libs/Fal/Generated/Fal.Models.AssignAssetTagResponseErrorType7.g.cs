
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AssignAssetTagResponseErrorType7
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
    public static class AssignAssetTagResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignAssetTagResponseErrorType7 value)
        {
            return value switch
            {
                AssignAssetTagResponseErrorType7.AuthorizationError => "authorization_error",
                AssignAssetTagResponseErrorType7.NotFound => "not_found",
                AssignAssetTagResponseErrorType7.NotImplemented => "not_implemented",
                AssignAssetTagResponseErrorType7.RateLimited => "rate_limited",
                AssignAssetTagResponseErrorType7.ServerError => "server_error",
                AssignAssetTagResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignAssetTagResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AssignAssetTagResponseErrorType7.AuthorizationError,
                "not_found" => AssignAssetTagResponseErrorType7.NotFound,
                "not_implemented" => AssignAssetTagResponseErrorType7.NotImplemented,
                "rate_limited" => AssignAssetTagResponseErrorType7.RateLimited,
                "server_error" => AssignAssetTagResponseErrorType7.ServerError,
                "validation_error" => AssignAssetTagResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}