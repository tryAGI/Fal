
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum MoveAssetCollectionResponseErrorType
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
    public static class MoveAssetCollectionResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveAssetCollectionResponseErrorType value)
        {
            return value switch
            {
                MoveAssetCollectionResponseErrorType.AuthorizationError => "authorization_error",
                MoveAssetCollectionResponseErrorType.NotFound => "not_found",
                MoveAssetCollectionResponseErrorType.NotImplemented => "not_implemented",
                MoveAssetCollectionResponseErrorType.RateLimited => "rate_limited",
                MoveAssetCollectionResponseErrorType.ServerError => "server_error",
                MoveAssetCollectionResponseErrorType.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveAssetCollectionResponseErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => MoveAssetCollectionResponseErrorType.AuthorizationError,
                "not_found" => MoveAssetCollectionResponseErrorType.NotFound,
                "not_implemented" => MoveAssetCollectionResponseErrorType.NotImplemented,
                "rate_limited" => MoveAssetCollectionResponseErrorType.RateLimited,
                "server_error" => MoveAssetCollectionResponseErrorType.ServerError,
                "validation_error" => MoveAssetCollectionResponseErrorType.ValidationError,
                _ => null,
            };
        }
    }
}