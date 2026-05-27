
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum AssignAssetTagResponseErrorType2
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
    public static class AssignAssetTagResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssignAssetTagResponseErrorType2 value)
        {
            return value switch
            {
                AssignAssetTagResponseErrorType2.AuthorizationError => "authorization_error",
                AssignAssetTagResponseErrorType2.NotFound => "not_found",
                AssignAssetTagResponseErrorType2.NotImplemented => "not_implemented",
                AssignAssetTagResponseErrorType2.RateLimited => "rate_limited",
                AssignAssetTagResponseErrorType2.ServerError => "server_error",
                AssignAssetTagResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssignAssetTagResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => AssignAssetTagResponseErrorType2.AuthorizationError,
                "not_found" => AssignAssetTagResponseErrorType2.NotFound,
                "not_implemented" => AssignAssetTagResponseErrorType2.NotImplemented,
                "rate_limited" => AssignAssetTagResponseErrorType2.RateLimited,
                "server_error" => AssignAssetTagResponseErrorType2.ServerError,
                "validation_error" => AssignAssetTagResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}