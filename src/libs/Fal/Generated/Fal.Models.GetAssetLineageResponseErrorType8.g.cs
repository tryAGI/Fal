
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetAssetLineageResponseErrorType8
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
    public static class GetAssetLineageResponseErrorType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAssetLineageResponseErrorType8 value)
        {
            return value switch
            {
                GetAssetLineageResponseErrorType8.AuthorizationError => "authorization_error",
                GetAssetLineageResponseErrorType8.NotFound => "not_found",
                GetAssetLineageResponseErrorType8.NotImplemented => "not_implemented",
                GetAssetLineageResponseErrorType8.RateLimited => "rate_limited",
                GetAssetLineageResponseErrorType8.ServerError => "server_error",
                GetAssetLineageResponseErrorType8.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAssetLineageResponseErrorType8? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetAssetLineageResponseErrorType8.AuthorizationError,
                "not_found" => GetAssetLineageResponseErrorType8.NotFound,
                "not_implemented" => GetAssetLineageResponseErrorType8.NotImplemented,
                "rate_limited" => GetAssetLineageResponseErrorType8.RateLimited,
                "server_error" => GetAssetLineageResponseErrorType8.ServerError,
                "validation_error" => GetAssetLineageResponseErrorType8.ValidationError,
                _ => null,
            };
        }
    }
}