
#nullable enable

namespace Fal
{
    /// <summary>
    /// Event details; populated fields depend on the event category (runner_*, deployment_*, config_changed)
    /// </summary>
    public sealed partial class ServerlessListAppEventsResponseEventPayload
    {
        /// <summary>
        /// Runner identifier (runner_* events)<br/>
        /// Example: 5f8e9c2a
        /// </summary>
        /// <example>5f8e9c2a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// Machine type of the runner (runner_* events)<br/>
        /// Example: GPU-H100
        /// </summary>
        /// <example>GPU-H100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("machine_type")]
        public string? MachineType { get; set; }

        /// <summary>
        /// Human-readable reason for the transition, when available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Runner state at failure time (runner_failed events)<br/>
        /// Example: RUNNING
        /// </summary>
        /// <example>RUNNING</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Revision deployed by this event (deployment_* events)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_application_id")]
        public string? NewApplicationId { get; set; }

        /// <summary>
        /// Revision being replaced (deployment_* events)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_application_id")]
        public string? OldApplicationId { get; set; }

        /// <summary>
        /// Application config before the change (config_changed events)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_config")]
        public object? OldConfig { get; set; }

        /// <summary>
        /// Application config after the change (config_changed events)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_config")]
        public object? NewConfig { get; set; }

        /// <summary>
        /// Endpoint auth mode before the change (config_changed events)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_app_auth_mode")]
        public string? OldAppAuthMode { get; set; }

        /// <summary>
        /// Endpoint auth mode after the change (config_changed events)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_app_auth_mode")]
        public string? NewAppAuthMode { get; set; }

        /// <summary>
        /// User who triggered the event, when known
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        public global::Fal.ServerlessListAppEventsResponseEventPayloadActor? Actor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppEventsResponseEventPayload" /> class.
        /// </summary>
        /// <param name="jobId">
        /// Runner identifier (runner_* events)<br/>
        /// Example: 5f8e9c2a
        /// </param>
        /// <param name="machineType">
        /// Machine type of the runner (runner_* events)<br/>
        /// Example: GPU-H100
        /// </param>
        /// <param name="reason">
        /// Human-readable reason for the transition, when available
        /// </param>
        /// <param name="state">
        /// Runner state at failure time (runner_failed events)<br/>
        /// Example: RUNNING
        /// </param>
        /// <param name="newApplicationId">
        /// Revision deployed by this event (deployment_* events)
        /// </param>
        /// <param name="oldApplicationId">
        /// Revision being replaced (deployment_* events)
        /// </param>
        /// <param name="oldConfig">
        /// Application config before the change (config_changed events)
        /// </param>
        /// <param name="newConfig">
        /// Application config after the change (config_changed events)
        /// </param>
        /// <param name="oldAppAuthMode">
        /// Endpoint auth mode before the change (config_changed events)
        /// </param>
        /// <param name="newAppAuthMode">
        /// Endpoint auth mode after the change (config_changed events)
        /// </param>
        /// <param name="actor">
        /// User who triggered the event, when known
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessListAppEventsResponseEventPayload(
            string? jobId,
            string? machineType,
            string? reason,
            string? state,
            string? newApplicationId,
            string? oldApplicationId,
            object? oldConfig,
            object? newConfig,
            string? oldAppAuthMode,
            string? newAppAuthMode,
            global::Fal.ServerlessListAppEventsResponseEventPayloadActor? actor)
        {
            this.JobId = jobId;
            this.MachineType = machineType;
            this.Reason = reason;
            this.State = state;
            this.NewApplicationId = newApplicationId;
            this.OldApplicationId = oldApplicationId;
            this.OldConfig = oldConfig;
            this.NewConfig = newConfig;
            this.OldAppAuthMode = oldAppAuthMode;
            this.NewAppAuthMode = newAppAuthMode;
            this.Actor = actor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppEventsResponseEventPayload" /> class.
        /// </summary>
        public ServerlessListAppEventsResponseEventPayload()
        {
        }

    }
}