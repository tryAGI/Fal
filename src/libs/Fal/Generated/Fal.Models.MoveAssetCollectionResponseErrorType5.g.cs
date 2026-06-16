
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum MoveAssetCollectionResponseErrorType5
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
    public static class MoveAssetCollectionResponseErrorType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveAssetCollectionResponseErrorType5 value)
        {
            return value switch
            {
                MoveAssetCollectionResponseErrorType5.AuthorizationError => "authorization_error",
                MoveAssetCollectionResponseErrorType5.NotFound => "not_found",
                MoveAssetCollectionResponseErrorType5.NotImplemented => "not_implemented",
                MoveAssetCollectionResponseErrorType5.RateLimited => "rate_limited",
                MoveAssetCollectionResponseErrorType5.ServerError => "server_error",
                MoveAssetCollectionResponseErrorType5.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveAssetCollectionResponseErrorType5? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => MoveAssetCollectionResponseErrorType5.AuthorizationError,
                "not_found" => MoveAssetCollectionResponseErrorType5.NotFound,
                "not_implemented" => MoveAssetCollectionResponseErrorType5.NotImplemented,
                "rate_limited" => MoveAssetCollectionResponseErrorType5.RateLimited,
                "server_error" => MoveAssetCollectionResponseErrorType5.ServerError,
                "validation_error" => MoveAssetCollectionResponseErrorType5.ValidationError,
                _ => null,
            };
        }
    }
}