
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationTeamsResponseErrorType6
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
    public static class GetOrganizationTeamsResponseErrorType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationTeamsResponseErrorType6 value)
        {
            return value switch
            {
                GetOrganizationTeamsResponseErrorType6.AuthorizationError => "authorization_error",
                GetOrganizationTeamsResponseErrorType6.NotFound => "not_found",
                GetOrganizationTeamsResponseErrorType6.NotImplemented => "not_implemented",
                GetOrganizationTeamsResponseErrorType6.RateLimited => "rate_limited",
                GetOrganizationTeamsResponseErrorType6.ServerError => "server_error",
                GetOrganizationTeamsResponseErrorType6.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationTeamsResponseErrorType6? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationTeamsResponseErrorType6.AuthorizationError,
                "not_found" => GetOrganizationTeamsResponseErrorType6.NotFound,
                "not_implemented" => GetOrganizationTeamsResponseErrorType6.NotImplemented,
                "rate_limited" => GetOrganizationTeamsResponseErrorType6.RateLimited,
                "server_error" => GetOrganizationTeamsResponseErrorType6.ServerError,
                "validation_error" => GetOrganizationTeamsResponseErrorType6.ValidationError,
                _ => null,
            };
        }
    }
}