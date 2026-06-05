
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationUsageResponseErrorType5
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
    public static class GetOrganizationUsageResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationUsageResponseErrorType5 value)
        {
            return value switch
            {
                GetOrganizationUsageResponseErrorType5.AuthorizationError => "authorization_error",
                GetOrganizationUsageResponseErrorType5.NotFound => "not_found",
                GetOrganizationUsageResponseErrorType5.NotImplemented => "not_implemented",
                GetOrganizationUsageResponseErrorType5.RateLimited => "rate_limited",
                GetOrganizationUsageResponseErrorType5.ServerError => "server_error",
                GetOrganizationUsageResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationUsageResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationUsageResponseErrorType5.AuthorizationError,
                "not_found" => GetOrganizationUsageResponseErrorType5.NotFound,
                "not_implemented" => GetOrganizationUsageResponseErrorType5.NotImplemented,
                "rate_limited" => GetOrganizationUsageResponseErrorType5.RateLimited,
                "server_error" => GetOrganizationUsageResponseErrorType5.ServerError,
                "validation_error" => GetOrganizationUsageResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}