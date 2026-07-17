
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetLineageResponseErrorType3
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
    public static class GetAssetLineageResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseErrorType3 value)
        {
            return value switch
            {
                GetAssetLineageResponseErrorType3.AuthorizationError => "authorization_error",
                GetAssetLineageResponseErrorType3.NotFound => "not_found",
                GetAssetLineageResponseErrorType3.NotImplemented => "not_implemented",
                GetAssetLineageResponseErrorType3.RateLimited => "rate_limited",
                GetAssetLineageResponseErrorType3.ServerError => "server_error",
                GetAssetLineageResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetLineageResponseErrorType3.AuthorizationError,
                "not_found" => GetAssetLineageResponseErrorType3.NotFound,
                "not_implemented" => GetAssetLineageResponseErrorType3.NotImplemented,
                "rate_limited" => GetAssetLineageResponseErrorType3.RateLimited,
                "server_error" => GetAssetLineageResponseErrorType3.ServerError,
                "validation_error" => GetAssetLineageResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}