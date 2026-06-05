
#nullable enable

namespace Fal
{
    /// <summary>
    /// Time bucket with grouped usage records
    /// </summary>
    public sealed partial class GetOrganizationUsageResponseTimeSerie
    {
        /// <summary>
        /// Time bucket timestamp in user's timezone with offset (ISO8601 datetime)<br/>
        /// Example: 2025-01-15T00:00:00-05:00
        /// </summary>
        /// <example>2025-01-15T00:00:00-05:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Bucket { get; set; }

        /// <summary>
        /// Usage records for this time bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.GetOrganizationUsageResponseTimeSerieResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationUsageResponseTimeSerie" /> class.
        /// </summary>
        /// <param name="bucket">
        /// Time bucket timestamp in user's timezone with offset (ISO8601 datetime)<br/>
        /// Example: 2025-01-15T00:00:00-05:00
        /// </param>
        /// <param name="results">
        /// Usage records for this time bucket
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationUsageResponseTimeSerie(
            string bucket,
            global::System.Collections.Generic.IList<global::Fal.GetOrganizationUsageResponseTimeSerieResult> results)
        {
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationUsageResponseTimeSerie" /> class.
        /// </summary>
        public GetOrganizationUsageResponseTimeSerie()
        {
        }

    }
}