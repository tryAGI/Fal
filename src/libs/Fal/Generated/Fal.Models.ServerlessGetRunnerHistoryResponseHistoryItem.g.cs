
#nullable enable

namespace Fal
{
    /// <summary>
    /// Runner counts by state for one time bucket
    /// </summary>
    public sealed partial class ServerlessGetRunnerHistoryResponseHistoryItem
    {
        /// <summary>
        /// Bucket start timestamp (UTC ISO8601)<br/>
        /// Example: 2026-07-01T12:00:00Z
        /// </summary>
        /// <example>2026-07-01T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Runners actively processing requests<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("running")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Running { get; set; }

        /// <summary>
        /// Warm runners waiting for requests (billed but unused)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Idle { get; set; }

        /// <summary>
        /// Runners waiting to be scheduled or starting up<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Pending { get; set; }

        /// <summary>
        /// Runners finishing in-flight work before shutting down<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("draining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Draining { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetRunnerHistoryResponseHistoryItem" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Bucket start timestamp (UTC ISO8601)<br/>
        /// Example: 2026-07-01T12:00:00Z
        /// </param>
        /// <param name="running">
        /// Runners actively processing requests<br/>
        /// Example: 2
        /// </param>
        /// <param name="idle">
        /// Warm runners waiting for requests (billed but unused)<br/>
        /// Example: 1
        /// </param>
        /// <param name="pending">
        /// Runners waiting to be scheduled or starting up<br/>
        /// Example: 0
        /// </param>
        /// <param name="draining">
        /// Runners finishing in-flight work before shutting down<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessGetRunnerHistoryResponseHistoryItem(
            string timestamp,
            double running,
            double idle,
            double pending,
            double draining)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Running = running;
            this.Idle = idle;
            this.Pending = pending;
            this.Draining = draining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetRunnerHistoryResponseHistoryItem" /> class.
        /// </summary>
        public ServerlessGetRunnerHistoryResponseHistoryItem()
        {
        }

    }
}