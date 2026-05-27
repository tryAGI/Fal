
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AssignAssetTagResponseErrorType5
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
    public static class AssignAssetTagResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignAssetTagResponseErrorType5 value)
        {
            return value switch
            {
                AssignAssetTagResponseErrorType5.AuthorizationError => "authorization_error",
                AssignAssetTagResponseErrorType5.NotFound => "not_found",
                AssignAssetTagResponseErrorType5.NotImplemented => "not_implemented",
                AssignAssetTagResponseErrorType5.RateLimited => "rate_limited",
                AssignAssetTagResponseErrorType5.ServerError => "server_error",
                AssignAssetTagResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignAssetTagResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AssignAssetTagResponseErrorType5.AuthorizationError,
                "not_found" => AssignAssetTagResponseErrorType5.NotFound,
                "not_implemented" => AssignAssetTagResponseErrorType5.NotImplemented,
                "rate_limited" => AssignAssetTagResponseErrorType5.RateLimited,
                "server_error" => AssignAssetTagResponseErrorType5.ServerError,
                "validation_error" => AssignAssetTagResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}