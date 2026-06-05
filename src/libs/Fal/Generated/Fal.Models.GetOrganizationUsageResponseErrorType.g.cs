
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationUsageResponseErrorType
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
    public static class GetOrganizationUsageResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationUsageResponseErrorType value)
        {
            return value switch
            {
                GetOrganizationUsageResponseErrorType.AuthorizationError => "authorization_error",
                GetOrganizationUsageResponseErrorType.NotFound => "not_found",
                GetOrganizationUsageResponseErrorType.NotImplemented => "not_implemented",
                GetOrganizationUsageResponseErrorType.RateLimited => "rate_limited",
                GetOrganizationUsageResponseErrorType.ServerError => "server_error",
                GetOrganizationUsageResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationUsageResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationUsageResponseErrorType.AuthorizationError,
                "not_found" => GetOrganizationUsageResponseErrorType.NotFound,
                "not_implemented" => GetOrganizationUsageResponseErrorType.NotImplemented,
                "rate_limited" => GetOrganizationUsageResponseErrorType.RateLimited,
                "server_error" => GetOrganizationUsageResponseErrorType.ServerError,
                "validation_error" => GetOrganizationUsageResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}