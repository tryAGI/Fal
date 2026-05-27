
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AssignAssetTagResponseErrorType
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
    public static class AssignAssetTagResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignAssetTagResponseErrorType value)
        {
            return value switch
            {
                AssignAssetTagResponseErrorType.AuthorizationError => "authorization_error",
                AssignAssetTagResponseErrorType.NotFound => "not_found",
                AssignAssetTagResponseErrorType.NotImplemented => "not_implemented",
                AssignAssetTagResponseErrorType.RateLimited => "rate_limited",
                AssignAssetTagResponseErrorType.ServerError => "server_error",
                AssignAssetTagResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignAssetTagResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AssignAssetTagResponseErrorType.AuthorizationError,
                "not_found" => AssignAssetTagResponseErrorType.NotFound,
                "not_implemented" => AssignAssetTagResponseErrorType.NotImplemented,
                "rate_limited" => AssignAssetTagResponseErrorType.RateLimited,
                "server_error" => AssignAssetTagResponseErrorType.ServerError,
                "validation_error" => AssignAssetTagResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}