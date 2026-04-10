
#nullable enable

namespace Fal
{
    /// <summary>
    /// Time bucket with grouped analytics records
    /// </summary>
    public sealed partial class ServerlessGetAnalyticsResponseTimeSerie
    {
        /// <summary>
        /// Time bucket timestamp in user's timezone with offset (ISO8601 datetime)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket { get; set; }

        /// <summary>
        /// Analytics records for this time bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.ServerlessGetAnalyticsResponseTimeSerieResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetAnalyticsResponseTimeSerie" /> class.
        /// </summary>
        /// <param name="bucket">
        /// Time bucket timestamp in user's timezone with offset (ISO8601 datetime)
        /// </param>
        /// <param name="results">
        /// Analytics records for this time bucket
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessGetAnalyticsResponseTimeSerie(
            string bucket,
            global::System.Collections.Generic.IList<global::Fal.ServerlessGetAnalyticsResponseTimeSerieResult> results)
        {
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessGetAnalyticsResponseTimeSerie" /> class.
        /// </summary>
        public ServerlessGetAnalyticsResponseTimeSerie()
        {
        }
    }
}