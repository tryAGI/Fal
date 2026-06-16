
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum MoveAssetCollectionResponseErrorType7
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
    public static class MoveAssetCollectionResponseErrorType7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveAssetCollectionResponseErrorType7 value)
        {
            return value switch
            {
                MoveAssetCollectionResponseErrorType7.AuthorizationError => "authorization_error",
                MoveAssetCollectionResponseErrorType7.NotFound => "not_found",
                MoveAssetCollectionResponseErrorType7.NotImplemented => "not_implemented",
                MoveAssetCollectionResponseErrorType7.RateLimited => "rate_limited",
                MoveAssetCollectionResponseErrorType7.ServerError => "server_error",
                MoveAssetCollectionResponseErrorType7.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveAssetCollectionResponseErrorType7? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => MoveAssetCollectionResponseErrorType7.AuthorizationError,
                "not_found" => MoveAssetCollectionResponseErrorType7.NotFound,
                "not_implemented" => MoveAssetCollectionResponseErrorType7.NotImplemented,
                "rate_limited" => MoveAssetCollectionResponseErrorType7.RateLimited,
                "server_error" => MoveAssetCollectionResponseErrorType7.ServerError,
                "validation_error" => MoveAssetCollectionResponseErrorType7.ValidationError,
                _ => null,
            };
        }
    }
}