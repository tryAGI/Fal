
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetLineageResponseErrorType4
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
    public static class GetAssetLineageResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseErrorType4 value)
        {
            return value switch
            {
                GetAssetLineageResponseErrorType4.AuthorizationError => "authorization_error",
                GetAssetLineageResponseErrorType4.NotFound => "not_found",
                GetAssetLineageResponseErrorType4.NotImplemented => "not_implemented",
                GetAssetLineageResponseErrorType4.RateLimited => "rate_limited",
                GetAssetLineageResponseErrorType4.ServerError => "server_error",
                GetAssetLineageResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetLineageResponseErrorType4.AuthorizationError,
                "not_found" => GetAssetLineageResponseErrorType4.NotFound,
                "not_implemented" => GetAssetLineageResponseErrorType4.NotImplemented,
                "rate_limited" => GetAssetLineageResponseErrorType4.RateLimited,
                "server_error" => GetAssetLineageResponseErrorType4.ServerError,
                "validation_error" => GetAssetLineageResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}