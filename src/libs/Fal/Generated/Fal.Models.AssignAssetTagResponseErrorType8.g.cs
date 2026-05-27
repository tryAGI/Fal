
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AssignAssetTagResponseErrorType8
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
    public static class AssignAssetTagResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignAssetTagResponseErrorType8 value)
        {
            return value switch
            {
                AssignAssetTagResponseErrorType8.AuthorizationError => "authorization_error",
                AssignAssetTagResponseErrorType8.NotFound => "not_found",
                AssignAssetTagResponseErrorType8.NotImplemented => "not_implemented",
                AssignAssetTagResponseErrorType8.RateLimited => "rate_limited",
                AssignAssetTagResponseErrorType8.ServerError => "server_error",
                AssignAssetTagResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignAssetTagResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AssignAssetTagResponseErrorType8.AuthorizationError,
                "not_found" => AssignAssetTagResponseErrorType8.NotFound,
                "not_implemented" => AssignAssetTagResponseErrorType8.NotImplemented,
                "rate_limited" => AssignAssetTagResponseErrorType8.RateLimited,
                "server_error" => AssignAssetTagResponseErrorType8.ServerError,
                "validation_error" => AssignAssetTagResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}