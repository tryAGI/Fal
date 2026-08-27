
#nullable enable

namespace Fal
{
    /// <summary>
    /// Deployment status derived from recent deployment events. Null when no deployment events are available for this revision (e.g. revisions older than the event retention window).<br/>
    /// Example: deployed
    /// </summary>
    public enum ServerlessListAppRevisionsResponseRevisionStatus
    {
        /// <summary>
        ///
        /// </summary>
        Deployed,
        /// <summary>
        ///
        /// </summary>
        Deploying,
        /// <summary>
        ///
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessListAppRevisionsResponseRevisionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppRevisionsResponseRevisionStatus value)
        {
            return value switch
            {
                ServerlessListAppRevisionsResponseRevisionStatus.Deployed => "deployed",
                ServerlessListAppRevisionsResponseRevisionStatus.Deploying => "deploying",
                ServerlessListAppRevisionsResponseRevisionStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppRevisionsResponseRevisionStatus? ToEnum(string value)
        {
            return value switch
            {
                "deployed" => ServerlessListAppRevisionsResponseRevisionStatus.Deployed,
                "deploying" => ServerlessListAppRevisionsResponseRevisionStatus.Deploying,
                "failed" => ServerlessListAppRevisionsResponseRevisionStatus.Failed,
                _ => null,
            };
        }
    }
}