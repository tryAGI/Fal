
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetLineageResponseErrorType
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
    public static class GetAssetLineageResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseErrorType value)
        {
            return value switch
            {
                GetAssetLineageResponseErrorType.AuthorizationError => "authorization_error",
                GetAssetLineageResponseErrorType.NotFound => "not_found",
                GetAssetLineageResponseErrorType.NotImplemented => "not_implemented",
                GetAssetLineageResponseErrorType.RateLimited => "rate_limited",
                GetAssetLineageResponseErrorType.ServerError => "server_error",
                GetAssetLineageResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetLineageResponseErrorType.AuthorizationError,
                "not_found" => GetAssetLineageResponseErrorType.NotFound,
                "not_implemented" => GetAssetLineageResponseErrorType.NotImplemented,
                "rate_limited" => GetAssetLineageResponseErrorType.RateLimited,
                "server_error" => GetAssetLineageResponseErrorType.ServerError,
                "validation_error" => GetAssetLineageResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}