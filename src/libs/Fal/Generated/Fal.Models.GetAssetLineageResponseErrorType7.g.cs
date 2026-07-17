
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetLineageResponseErrorType7
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
    public static class GetAssetLineageResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseErrorType7 value)
        {
            return value switch
            {
                GetAssetLineageResponseErrorType7.AuthorizationError => "authorization_error",
                GetAssetLineageResponseErrorType7.NotFound => "not_found",
                GetAssetLineageResponseErrorType7.NotImplemented => "not_implemented",
                GetAssetLineageResponseErrorType7.RateLimited => "rate_limited",
                GetAssetLineageResponseErrorType7.ServerError => "server_error",
                GetAssetLineageResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetLineageResponseErrorType7.AuthorizationError,
                "not_found" => GetAssetLineageResponseErrorType7.NotFound,
                "not_implemented" => GetAssetLineageResponseErrorType7.NotImplemented,
                "rate_limited" => GetAssetLineageResponseErrorType7.RateLimited,
                "server_error" => GetAssetLineageResponseErrorType7.ServerError,
                "validation_error" => GetAssetLineageResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}