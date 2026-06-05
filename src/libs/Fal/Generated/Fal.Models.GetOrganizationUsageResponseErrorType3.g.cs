
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationUsageResponseErrorType3
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
    public static class GetOrganizationUsageResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationUsageResponseErrorType3 value)
        {
            return value switch
            {
                GetOrganizationUsageResponseErrorType3.AuthorizationError => "authorization_error",
                GetOrganizationUsageResponseErrorType3.NotFound => "not_found",
                GetOrganizationUsageResponseErrorType3.NotImplemented => "not_implemented",
                GetOrganizationUsageResponseErrorType3.RateLimited => "rate_limited",
                GetOrganizationUsageResponseErrorType3.ServerError => "server_error",
                GetOrganizationUsageResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationUsageResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationUsageResponseErrorType3.AuthorizationError,
                "not_found" => GetOrganizationUsageResponseErrorType3.NotFound,
                "not_implemented" => GetOrganizationUsageResponseErrorType3.NotImplemented,
                "rate_limited" => GetOrganizationUsageResponseErrorType3.RateLimited,
                "server_error" => GetOrganizationUsageResponseErrorType3.ServerError,
                "validation_error" => GetOrganizationUsageResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}