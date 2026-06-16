
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationUsageResponseErrorType4
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
    public static class GetOrganizationUsageResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationUsageResponseErrorType4 value)
        {
            return value switch
            {
                GetOrganizationUsageResponseErrorType4.AuthorizationError => "authorization_error",
                GetOrganizationUsageResponseErrorType4.NotFound => "not_found",
                GetOrganizationUsageResponseErrorType4.NotImplemented => "not_implemented",
                GetOrganizationUsageResponseErrorType4.RateLimited => "rate_limited",
                GetOrganizationUsageResponseErrorType4.ServerError => "server_error",
                GetOrganizationUsageResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationUsageResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationUsageResponseErrorType4.AuthorizationError,
                "not_found" => GetOrganizationUsageResponseErrorType4.NotFound,
                "not_implemented" => GetOrganizationUsageResponseErrorType4.NotImplemented,
                "rate_limited" => GetOrganizationUsageResponseErrorType4.RateLimited,
                "server_error" => GetOrganizationUsageResponseErrorType4.ServerError,
                "validation_error" => GetOrganizationUsageResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}