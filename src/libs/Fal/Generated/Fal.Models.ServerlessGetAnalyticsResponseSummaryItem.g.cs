
#nullable enable

namespace Fal
{
    /// <summary>
    /// Aggregate performance statistics for the entire date range
    /// </summary>
    public sealed partial class ServerlessGetAnalyticsResponseSummaryItem
    {
        /// <summary>
        /// Endpoint identifier for these statistics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Total number of requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_count")]
        public int? RequestCount { get; set; }

        /// <summary>
        /// Number of successful requests (2xx responses)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_count")]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// Number of user errors (4xx responses)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_error_count")]
        public int? UserErrorCount { get; set; }

        /// <summary>
        /// Number of server errors (5xx responses)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// 50th percentile queue/prepare time before execution in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50_prepare_duration")]
        public double? P50PrepareDuration { get; set; }

        /// <summary>
        /// 75th percentile queue/prepare time before execution in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p75_prepare_duration")]
        public double? P75PrepareDuration { get; set; }

        /// <summary>
        /// 90th percentile queue/prepare time before execution in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90_prepare_duration")]
        public double? P90PrepareDuration { get; set; }

        /// <summary>
        /// 95th percentile queue/prepare time before execution in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95_prepare_duration")]
        public double? P95PrepareDuration { get; set; }

        /// <summary>
        /// 99th percentile queue/prepare time before execution in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99_prepare_duration")]
        public double? P99PrepareDuration { get; set; }

        /// <summary>
        /// 50th percentile request execution duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50_duration")]
        public double? P50Duration { get; set; }

        /// <summary>
        /// 75th percentile request execution duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p75_duration")]
        public double? P75Duration { get; set; }

        /// <summary>
        /// 90th percentile request execution duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90_duration")]
        public double? P90Duration { get; set; }

        /// <summary>
        /// 25th percentile request execution duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p25_duration")]
        public double? P25Duration { get; set; }

        /// <summary>
        /// 95th percentile request execution duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95_duration")]
        public double? P95Duration { get; set; }

        /// <summary>
        /// 99th percentile request execution duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99_duration")]
        public double? P99Duration { get; set; }

        /// <summary>
        /// Number of startup errors (startup timeout, scheduling failure)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startup_error_count")]
        public int? StartupErrorCount { get; set; }

        /// <summary>
        /// Number of connection errors (connection timeout, disconnected, refused)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_error_count")]
        public int? ConnectionErrorCount { get; set; }

        /// <summary>
        /// Number of request timeout errors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_error_count")]
        public int? TimeoutErrorCount { get; set; }

        /// <summary>
        /// Number of runtime errors (internal error, server error)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runtime_error_count")]
        public int? RuntimeErrorCount { get; set; }

        /// <summary>
        /// Number of requests with cold boot (startup time &gt; 1 second)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cold_boot_count")]
        public int? ColdBootCount { get; set; }

        /// <summary>
        /// 50th percentile cold boot duration in seconds (only cold starts)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50_cold_boot_duration")]
        public double? P50ColdBootDuration { get; set; }

        /// <summary>
        /// 75th percentile cold boot duration in seconds (only cold starts)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p75_cold_boot_duration")]
        public double? P75ColdBootDuration { get; set; }

        /// <summary>
        /// 90th percentile cold boot duration in seconds (only cold starts)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90_cold_boot_duration")]
        public double? P90ColdBootDuration { get; set; }

        /// <summary>
        /// Total billable execution duration in seconds (sum of all request durations)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_billable_duration")]
        public double? TotalBillableDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetAnalyticsResponseSummaryItem" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// Endpoint identifier for these statistics
        /// </param>
        /// <param name="requestCount">
        /// Total number of requests
        /// </param>
        /// <param name="successCount">
        /// Number of successful requests (2xx responses)
        /// </param>
        /// <param name="userErrorCount">
        /// Number of user errors (4xx responses)
        /// </param>
        /// <param name="errorCount">
        /// Number of server errors (5xx responses)
        /// </param>
        /// <param name="p50PrepareDuration">
        /// 50th percentile queue/prepare time before execution in seconds
        /// </param>
        /// <param name="p75PrepareDuration">
        /// 75th percentile queue/prepare time before execution in seconds
        /// </param>
        /// <param name="p90PrepareDuration">
        /// 90th percentile queue/prepare time before execution in seconds
        /// </param>
        /// <param name="p95PrepareDuration">
        /// 95th percentile queue/prepare time before execution in seconds
        /// </param>
        /// <param name="p99PrepareDuration">
        /// 99th percentile queue/prepare time before execution in seconds
        /// </param>
        /// <param name="p50Duration">
        /// 50th percentile request execution duration in seconds
        /// </param>
        /// <param name="p75Duration">
        /// 75th percentile request execution duration in seconds
        /// </param>
        /// <param name="p90Duration">
        /// 90th percentile request execution duration in seconds
        /// </param>
        /// <param name="p25Duration">
        /// 25th percentile request execution duration in seconds
        /// </param>
        /// <param name="p95Duration">
        /// 95th percentile request execution duration in seconds
        /// </param>
        /// <param name="p99Duration">
        /// 99th percentile request execution duration in seconds
        /// </param>
        /// <param name="startupErrorCount">
        /// Number of startup errors (startup timeout, scheduling failure)
        /// </param>
        /// <param name="connectionErrorCount">
        /// Number of connection errors (connection timeout, disconnected, refused)
        /// </param>
        /// <param name="timeoutErrorCount">
        /// Number of request timeout errors
        /// </param>
        /// <param name="runtimeErrorCount">
        /// Number of runtime errors (internal error, server error)
        /// </param>
        /// <param name="coldBootCount">
        /// Number of requests with cold boot (startup time &gt; 1 second)
        /// </param>
        /// <param name="p50ColdBootDuration">
        /// 50th percentile cold boot duration in seconds (only cold starts)
        /// </param>
        /// <param name="p75ColdBootDuration">
        /// 75th percentile cold boot duration in seconds (only cold starts)
        /// </param>
        /// <param name="p90ColdBootDuration">
        /// 90th percentile cold boot duration in seconds (only cold starts)
        /// </param>
        /// <param name="totalBillableDuration">
        /// Total billable execution duration in seconds (sum of all request durations)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessGetAnalyticsResponseSummaryItem(
            string endpointId,
            int? requestCount,
            int? successCount,
            int? userErrorCount,
            int? errorCount,
            double? p50PrepareDuration,
            double? p75PrepareDuration,
            double? p90PrepareDuration,
            double? p95PrepareDuration,
            double? p99PrepareDuration,
            double? p50Duration,
            double? p75Duration,
            double? p90Duration,
            double? p25Duration,
            double? p95Duration,
            double? p99Duration,
            int? startupErrorCount,
            int? connectionErrorCount,
            int? timeoutErrorCount,
            int? runtimeErrorCount,
            int? coldBootCount,
            double? p50ColdBootDuration,
            double? p75ColdBootDuration,
            double? p90ColdBootDuration,
            double? totalBillableDuration)
        {
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.RequestCount = requestCount;
            this.SuccessCount = successCount;
            this.UserErrorCount = userErrorCount;
            this.ErrorCount = errorCount;
            this.P50PrepareDuration = p50PrepareDuration;
            this.P75PrepareDuration = p75PrepareDuration;
            this.P90PrepareDuration = p90PrepareDuration;
            this.P95PrepareDuration = p95PrepareDuration;
            this.P99PrepareDuration = p99PrepareDuration;
            this.P50Duration = p50Duration;
            this.P75Duration = p75Duration;
            this.P90Duration = p90Duration;
            this.P25Duration = p25Duration;
            this.P95Duration = p95Duration;
            this.P99Duration = p99Duration;
            this.StartupErrorCount = startupErrorCount;
            this.ConnectionErrorCount = connectionErrorCount;
            this.TimeoutErrorCount = timeoutErrorCount;
            this.RuntimeErrorCount = runtimeErrorCount;
            this.ColdBootCount = coldBootCount;
            this.P50ColdBootDuration = p50ColdBootDuration;
            this.P75ColdBootDuration = p75ColdBootDuration;
            this.P90ColdBootDuration = p90ColdBootDuration;
            this.TotalBillableDuration = totalBillableDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetAnalyticsResponseSummaryItem" /> class.
        /// </summary>
        public ServerlessGetAnalyticsResponseSummaryItem()
        {
        }

    }
}