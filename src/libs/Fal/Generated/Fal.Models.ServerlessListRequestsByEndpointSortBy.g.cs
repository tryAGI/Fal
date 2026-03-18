
#nullable enable

namespace Fal
{
    /// <summary>
    /// Sort results by end time or duration<br/>
    /// Default Value: ended_at<br/>
    /// Example: ended_at
    /// </summary>
    public enum ServerlessListRequestsByEndpointSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        EndedAt,
        /// <summary>
        /// 
        /// </summary>
        Duration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessListRequestsByEndpointSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListRequestsByEndpointSortBy value)
        {
            return value switch
            {
                ServerlessListRequestsByEndpointSortBy.EndedAt => "ended_at",
                ServerlessListRequestsByEndpointSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListRequestsByEndpointSortBy? ToEnum(string value)
        {
            return value switch
            {
                "ended_at" => ServerlessListRequestsByEndpointSortBy.EndedAt,
                "duration" => ServerlessListRequestsByEndpointSortBy.Duration,
                _ => null,
            };
        }
    }
}