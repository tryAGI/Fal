
#nullable enable

namespace Fal
{
    /// <summary>
    /// The category of error that occurred
    /// </summary>
    public enum MoveAssetCollectionResponseErrorType2
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
    public static class MoveAssetCollectionResponseErrorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MoveAssetCollectionResponseErrorType2 value)
        {
            return value switch
            {
                MoveAssetCollectionResponseErrorType2.AuthorizationError => "authorization_error",
                MoveAssetCollectionResponseErrorType2.NotFound => "not_found",
                MoveAssetCollectionResponseErrorType2.NotImplemented => "not_implemented",
                MoveAssetCollectionResponseErrorType2.RateLimited => "rate_limited",
                MoveAssetCollectionResponseErrorType2.ServerError => "server_error",
                MoveAssetCollectionResponseErrorType2.ValidationError => "validation_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MoveAssetCollectionResponseErrorType2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_error" => MoveAssetCollectionResponseErrorType2.AuthorizationError,
                "not_found" => MoveAssetCollectionResponseErrorType2.NotFound,
                "not_implemented" => MoveAssetCollectionResponseErrorType2.NotImplemented,
                "rate_limited" => MoveAssetCollectionResponseErrorType2.RateLimited,
                "server_error" => MoveAssetCollectionResponseErrorType2.ServerError,
                "validation_error" => MoveAssetCollectionResponseErrorType2.ValidationError,
                _ => null,
            };
        }
    }
}