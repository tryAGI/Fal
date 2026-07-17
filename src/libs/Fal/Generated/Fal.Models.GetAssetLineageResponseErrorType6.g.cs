
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetLineageResponseErrorType6
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
    public static class GetAssetLineageResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseErrorType6 value)
        {
            return value switch
            {
                GetAssetLineageResponseErrorType6.AuthorizationError => "authorization_error",
                GetAssetLineageResponseErrorType6.NotFound => "not_found",
                GetAssetLineageResponseErrorType6.NotImplemented => "not_implemented",
                GetAssetLineageResponseErrorType6.RateLimited => "rate_limited",
                GetAssetLineageResponseErrorType6.ServerError => "server_error",
                GetAssetLineageResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetLineageResponseErrorType6.AuthorizationError,
                "not_found" => GetAssetLineageResponseErrorType6.NotFound,
                "not_implemented" => GetAssetLineageResponseErrorType6.NotImplemented,
                "rate_limited" => GetAssetLineageResponseErrorType6.RateLimited,
                "server_error" => GetAssetLineageResponseErrorType6.ServerError,
                "validation_error" => GetAssetLineageResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}