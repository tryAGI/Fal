
#nullable enable

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServerlessStopRunnerResponse
    {
        /// <summary>
        /// ID of the runner whose graceful stop was requested<br/>
        /// Example: f1e2d3c4-b5a6-7890-dcba-0987654321fe
        /// </summary>
        /// <example>f1e2d3c4-b5a6-7890-dcba-0987654321fe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("runner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessStopRunnerResponse" /> class.
        /// </summary>
        /// <param name="runnerId">
        /// ID of the runner whose graceful stop was requested<br/>
        /// Example: f1e2d3c4-b5a6-7890-dcba-0987654321fe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessStopRunnerResponse(
            string runnerId)
        {
            this.RunnerId = runnerId ?? throw new global::System.ArgumentNullException(nameof(runnerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessStopRunnerResponse" /> class.
        /// </summary>
        public ServerlessStopRunnerResponse()
        {
        }

    }
}