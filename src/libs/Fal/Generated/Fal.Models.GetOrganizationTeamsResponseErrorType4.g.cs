
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationTeamsResponseErrorType4
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
    public static class GetOrganizationTeamsResponseErrorType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationTeamsResponseErrorType4 value)
        {
            return value switch
            {
                GetOrganizationTeamsResponseErrorType4.AuthorizationError => "authorization_error",
                GetOrganizationTeamsResponseErrorType4.NotFound => "not_found",
                GetOrganizationTeamsResponseErrorType4.NotImplemented => "not_implemented",
                GetOrganizationTeamsResponseErrorType4.RateLimited => "rate_limited",
                GetOrganizationTeamsResponseErrorType4.ServerError => "server_error",
                GetOrganizationTeamsResponseErrorType4.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationTeamsResponseErrorType4? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationTeamsResponseErrorType4.AuthorizationError,
                "not_found" => GetOrganizationTeamsResponseErrorType4.NotFound,
                "not_implemented" => GetOrganizationTeamsResponseErrorType4.NotImplemented,
                "rate_limited" => GetOrganizationTeamsResponseErrorType4.RateLimited,
                "server_error" => GetOrganizationTeamsResponseErrorType4.ServerError,
                "validation_error" => GetOrganizationTeamsResponseErrorType4.ValidationError,
                _ => null,
            };
        }
    }
}