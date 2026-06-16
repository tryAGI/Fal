
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationTeamsResponseErrorType3
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
    public static class GetOrganizationTeamsResponseErrorType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationTeamsResponseErrorType3 value)
        {
            return value switch
            {
                GetOrganizationTeamsResponseErrorType3.AuthorizationError => "authorization_error",
                GetOrganizationTeamsResponseErrorType3.NotFound => "not_found",
                GetOrganizationTeamsResponseErrorType3.NotImplemented => "not_implemented",
                GetOrganizationTeamsResponseErrorType3.RateLimited => "rate_limited",
                GetOrganizationTeamsResponseErrorType3.ServerError => "server_error",
                GetOrganizationTeamsResponseErrorType3.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationTeamsResponseErrorType3? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationTeamsResponseErrorType3.AuthorizationError,
                "not_found" => GetOrganizationTeamsResponseErrorType3.NotFound,
                "not_implemented" => GetOrganizationTeamsResponseErrorType3.NotImplemented,
                "rate_limited" => GetOrganizationTeamsResponseErrorType3.RateLimited,
                "server_error" => GetOrganizationTeamsResponseErrorType3.ServerError,
                "validation_error" => GetOrganizationTeamsResponseErrorType3.ValidationError,
                _ => null,
            };
        }
    }
}