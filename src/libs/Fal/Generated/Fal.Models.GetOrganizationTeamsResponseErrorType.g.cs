
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationTeamsResponseErrorType
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
    public static class GetOrganizationTeamsResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationTeamsResponseErrorType value)
        {
            return value switch
            {
                GetOrganizationTeamsResponseErrorType.AuthorizationError => "authorization_error",
                GetOrganizationTeamsResponseErrorType.NotFound => "not_found",
                GetOrganizationTeamsResponseErrorType.NotImplemented => "not_implemented",
                GetOrganizationTeamsResponseErrorType.RateLimited => "rate_limited",
                GetOrganizationTeamsResponseErrorType.ServerError => "server_error",
                GetOrganizationTeamsResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationTeamsResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationTeamsResponseErrorType.AuthorizationError,
                "not_found" => GetOrganizationTeamsResponseErrorType.NotFound,
                "not_implemented" => GetOrganizationTeamsResponseErrorType.NotImplemented,
                "rate_limited" => GetOrganizationTeamsResponseErrorType.RateLimited,
                "server_error" => GetOrganizationTeamsResponseErrorType.ServerError,
                "validation_error" => GetOrganizationTeamsResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}