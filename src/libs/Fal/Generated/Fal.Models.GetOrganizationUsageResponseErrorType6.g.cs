
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationUsageResponseErrorType6
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
    public static class GetOrganizationUsageResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationUsageResponseErrorType6 value)
        {
            return value switch
            {
                GetOrganizationUsageResponseErrorType6.AuthorizationError => "authorization_error",
                GetOrganizationUsageResponseErrorType6.NotFound => "not_found",
                GetOrganizationUsageResponseErrorType6.NotImplemented => "not_implemented",
                GetOrganizationUsageResponseErrorType6.RateLimited => "rate_limited",
                GetOrganizationUsageResponseErrorType6.ServerError => "server_error",
                GetOrganizationUsageResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationUsageResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationUsageResponseErrorType6.AuthorizationError,
                "not_found" => GetOrganizationUsageResponseErrorType6.NotFound,
                "not_implemented" => GetOrganizationUsageResponseErrorType6.NotImplemented,
                "rate_limited" => GetOrganizationUsageResponseErrorType6.RateLimited,
                "server_error" => GetOrganizationUsageResponseErrorType6.ServerError,
                "validation_error" => GetOrganizationUsageResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}