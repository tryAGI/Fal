
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum GetOrganizationTeamsResponseErrorType2
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
    public static class GetOrganizationTeamsResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationTeamsResponseErrorType2 value)
        {
            return value switch
            {
                GetOrganizationTeamsResponseErrorType2.AuthorizationError => "authorization_error",
                GetOrganizationTeamsResponseErrorType2.NotFound => "not_found",
                GetOrganizationTeamsResponseErrorType2.NotImplemented => "not_implemented",
                GetOrganizationTeamsResponseErrorType2.RateLimited => "rate_limited",
                GetOrganizationTeamsResponseErrorType2.ServerError => "server_error",
                GetOrganizationTeamsResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationTeamsResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => GetOrganizationTeamsResponseErrorType2.AuthorizationError,
                "not_found" => GetOrganizationTeamsResponseErrorType2.NotFound,
                "not_implemented" => GetOrganizationTeamsResponseErrorType2.NotImplemented,
                "rate_limited" => GetOrganizationTeamsResponseErrorType2.RateLimited,
                "server_error" => GetOrganizationTeamsResponseErrorType2.ServerError,
                "validation_error" => GetOrganizationTeamsResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}