
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetLineageResponseErrorType9
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
    public static class GetAssetLineageResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseErrorType9 value)
        {
            return value switch
            {
                GetAssetLineageResponseErrorType9.AuthorizationError => "authorization_error",
                GetAssetLineageResponseErrorType9.NotFound => "not_found",
                GetAssetLineageResponseErrorType9.NotImplemented => "not_implemented",
                GetAssetLineageResponseErrorType9.RateLimited => "rate_limited",
                GetAssetLineageResponseErrorType9.ServerError => "server_error",
                GetAssetLineageResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetLineageResponseErrorType9.AuthorizationError,
                "not_found" => GetAssetLineageResponseErrorType9.NotFound,
                "not_implemented" => GetAssetLineageResponseErrorType9.NotImplemented,
                "rate_limited" => GetAssetLineageResponseErrorType9.RateLimited,
                "server_error" => GetAssetLineageResponseErrorType9.ServerError,
                "validation_error" => GetAssetLineageResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}