
#nullable enable

namespace Fal
{
    /// <summary>
    /// Historical runner state counts for an application
    /// </summary>
    public sealed partial class ServerlessGetRunnerHistoryResponse
    {
        /// <summary>
        /// Canonical endpoint identifier ('&lt;owner&gt;/&lt;name&gt;')<br/>
        /// Example: user_123/my-app
        /// </summary>
        /// <example>user_123/my-app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Bucket size used for the series (resolved if auto-detected)<br/>
        /// Example: day
        /// </summary>
        /// <example>day</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeframe")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseTimeframeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.ServerlessGetRunnerHistoryResponseTimeframe Timeframe { get; set; }

        /// <summary>
        /// Aggregation applied within each bucket<br/>
        /// Example: max
        /// </summary>
        /// <example>max</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseAggregationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.ServerlessGetRunnerHistoryResponseAggregation Aggregation { get; set; }

        /// <summary>
        /// Runner state counts per time bucket, oldest first
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.ServerlessGetRunnerHistoryResponseHistoryItem> History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetRunnerHistoryResponse" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// Canonical endpoint identifier ('&lt;owner&gt;/&lt;name&gt;')<br/>
        /// Example: user_123/my-app
        /// </param>
        /// <param name="timeframe">
        /// Bucket size used for the series (resolved if auto-detected)<br/>
        /// Example: day
        /// </param>
        /// <param name="aggregation">
        /// Aggregation applied within each bucket<br/>
        /// Example: max
        /// </param>
        /// <param name="history">
        /// Runner state counts per time bucket, oldest first
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessGetRunnerHistoryResponse(
            string endpointId,
            global::Fal.ServerlessGetRunnerHistoryResponseTimeframe timeframe,
            global::Fal.ServerlessGetRunnerHistoryResponseAggregation aggregation,
            global::System.Collections.Generic.IList<global::Fal.ServerlessGetRunnerHistoryResponseHistoryItem> history)
        {
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Timeframe = timeframe;
            this.Aggregation = aggregation;
            this.History = history ?? throw new global::System.ArgumentNullException(nameof(history));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetRunnerHistoryResponse" /> class.
        /// </summary>
        public ServerlessGetRunnerHistoryResponse()
        {
        }

    }
}