
#nullable enable

namespace Fal
{
    /// <summary>
    /// An operational event on a serverless application
    /// </summary>
    public sealed partial class ServerlessListAppEventsResponseEvent
    {
        /// <summary>
        /// Unique event identifier<br/>
        /// Example: a1b2c3d4-0000-0000-0000-000000000000
        /// </summary>
        /// <example>a1b2c3d4-0000-0000-0000-000000000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// Event category<br/>
        /// Example: deployment_started
        /// </summary>
        /// <example>deployment_started</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.ServerlessListAppEventsResponseEventCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.ServerlessListAppEventsResponseEventCategory Category { get; set; }

        /// <summary>
        /// Event timestamp (UTC ISO8601)<br/>
        /// Example: 2026-07-01T12:00:00Z
        /// </summary>
        /// <example>2026-07-01T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Event details; populated fields depend on the event category (runner_*, deployment_*, config_changed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.ServerlessListAppEventsResponseEventPayload Payload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppEventsResponseEvent" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Unique event identifier<br/>
        /// Example: a1b2c3d4-0000-0000-0000-000000000000
        /// </param>
        /// <param name="category">
        /// Event category<br/>
        /// Example: deployment_started
        /// </param>
        /// <param name="createdAt">
        /// Event timestamp (UTC ISO8601)<br/>
        /// Example: 2026-07-01T12:00:00Z
        /// </param>
        /// <param name="payload">
        /// Event details; populated fields depend on the event category (runner_*, deployment_*, config_changed)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessListAppEventsResponseEvent(
            string eventId,
            global::Fal.ServerlessListAppEventsResponseEventCategory category,
            string createdAt,
            global::Fal.ServerlessListAppEventsResponseEventPayload payload)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Category = category;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Payload = payload ?? throw new global::System.ArgumentNullException(nameof(payload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppEventsResponseEvent" /> class.
        /// </summary>
        public ServerlessListAppEventsResponseEvent()
        {
        }

    }
}