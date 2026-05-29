
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationTeamsResponseErrorType5
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
    public static class GetOrganizationTeamsResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationTeamsResponseErrorType5 value)
        {
            return value switch
            {
                GetOrganizationTeamsResponseErrorType5.AuthorizationError => "authorization_error",
                GetOrganizationTeamsResponseErrorType5.NotFound => "not_found",
                GetOrganizationTeamsResponseErrorType5.NotImplemented => "not_implemented",
                GetOrganizationTeamsResponseErrorType5.RateLimited => "rate_limited",
                GetOrganizationTeamsResponseErrorType5.ServerError => "server_error",
                GetOrganizationTeamsResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationTeamsResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationTeamsResponseErrorType5.AuthorizationError,
                "not_found" => GetOrganizationTeamsResponseErrorType5.NotFound,
                "not_implemented" => GetOrganizationTeamsResponseErrorType5.NotImplemented,
                "rate_limited" => GetOrganizationTeamsResponseErrorType5.RateLimited,
                "server_error" => GetOrganizationTeamsResponseErrorType5.ServerError,
                "validation_error" => GetOrganizationTeamsResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}