
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum MoveAssetCollectionResponseErrorType9
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
    public static class MoveAssetCollectionResponseErrorType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveAssetCollectionResponseErrorType9 value)
        {
            return value switch
            {
                MoveAssetCollectionResponseErrorType9.AuthorizationError => "authorization_error",
                MoveAssetCollectionResponseErrorType9.NotFound => "not_found",
                MoveAssetCollectionResponseErrorType9.NotImplemented => "not_implemented",
                MoveAssetCollectionResponseErrorType9.RateLimited => "rate_limited",
                MoveAssetCollectionResponseErrorType9.ServerError => "server_error",
                MoveAssetCollectionResponseErrorType9.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveAssetCollectionResponseErrorType9? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => MoveAssetCollectionResponseErrorType9.AuthorizationError,
                "not_found" => MoveAssetCollectionResponseErrorType9.NotFound,
                "not_implemented" => MoveAssetCollectionResponseErrorType9.NotImplemented,
                "rate_limited" => MoveAssetCollectionResponseErrorType9.RateLimited,
                "server_error" => MoveAssetCollectionResponseErrorType9.ServerError,
                "validation_error" => MoveAssetCollectionResponseErrorType9.ValidationError,
                _ => null,
            };
        }
    }
}