
#nullable enable

namespace Fal
{
    /// <summary>
    /// Custom key/value annotations attached to this revision at deploy time (fal deploy --annotation KEY=VALUE). Null when the deploy did not set any.<br/>
    /// Example: {"GIT_SHA":"a1b2c3d4"}
    /// </summary>
    public sealed partial class ServerlessListAppRevisionsResponseRevisionAnnotations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}