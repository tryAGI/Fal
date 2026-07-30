
#nullable enable

namespace Fal
{
    /// <summary>
    /// A deployed revision of a serverless application
    /// </summary>
    public sealed partial class ServerlessListAppRevisionsResponseRevision
    {
        /// <summary>
        /// Unique revision identifier<br/>
        /// Example: my-app-a1b2c3d4
        /// </summary>
        /// <example>my-app-a1b2c3d4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RevisionId { get; set; }

        /// <summary>
        /// Revision creation timestamp (UTC ISO8601)<br/>
        /// Example: 2026-07-01T12:00:00Z
        /// </summary>
        /// <example>2026-07-01T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Whether this revision is the one currently serving traffic<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_current")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCurrent { get; set; }

        /// <summary>
        /// Deployment status derived from recent deployment events. Null when no deployment events are available for this revision (e.g. revisions older than the event retention window).<br/>
        /// Example: deployed
        /// </summary>
        /// <example>deployed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.ServerlessListAppRevisionsResponseRevisionStatusJsonConverter))]
        public global::Fal.ServerlessListAppRevisionsResponseRevisionStatus? Status { get; set; }

        /// <summary>
        /// Nickname or display name of the user who deployed this revision, when known from recent deployment events<br/>
        /// Example: user_123
        /// </summary>
        /// <example>user_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployed_by")]
        public string? DeployedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppRevisionsResponseRevision" /> class.
        /// </summary>
        /// <param name="revisionId">
        /// Unique revision identifier<br/>
        /// Example: my-app-a1b2c3d4
        /// </param>
        /// <param name="createdAt">
        /// Revision creation timestamp (UTC ISO8601)<br/>
        /// Example: 2026-07-01T12:00:00Z
        /// </param>
        /// <param name="isCurrent">
        /// Whether this revision is the one currently serving traffic<br/>
        /// Example: true
        /// </param>
        /// <param name="status">
        /// Deployment status derived from recent deployment events. Null when no deployment events are available for this revision (e.g. revisions older than the event retention window).<br/>
        /// Example: deployed
        /// </param>
        /// <param name="deployedBy">
        /// Nickname or display name of the user who deployed this revision, when known from recent deployment events<br/>
        /// Example: user_123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessListAppRevisionsResponseRevision(
            string revisionId,
            string createdAt,
            bool isCurrent,
            global::Fal.ServerlessListAppRevisionsResponseRevisionStatus? status,
            string? deployedBy)
        {
            this.RevisionId = revisionId ?? throw new global::System.ArgumentNullException(nameof(revisionId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.IsCurrent = isCurrent;
            this.Status = status;
            this.DeployedBy = deployedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppRevisionsResponseRevision" /> class.
        /// </summary>
        public ServerlessListAppRevisionsResponseRevision()
        {
        }

    }
}