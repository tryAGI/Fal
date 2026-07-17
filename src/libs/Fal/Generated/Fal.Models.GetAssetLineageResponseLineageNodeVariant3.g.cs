
#nullable enable

namespace Fal
{
    /// <summary>
    /// A generation request in the lineage
    /// </summary>
    public sealed partial class GetAssetLineageResponseLineageNodeVariant3
    {
        /// <summary>
        /// Node kind
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant3KindJsonConverter))]
        public global::Fal.GetAssetLineageResponseLineageNodeVariant3Kind Kind { get; set; }

        /// <summary>
        /// Graph node ID<br/>
        /// Example: request:019e6d0a-e5be-7b82-b329-35ae64296902
        /// </summary>
        /// <example>request:019e6d0a-e5be-7b82-b329-35ae64296902</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Request ID<br/>
        /// Example: 019e6d0a-e5be-7b82-b329-35ae64296902
        /// </summary>
        /// <example>019e6d0a-e5be-7b82-b329-35ae64296902</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Model endpoint that ran the request<br/>
        /// Example: fal-ai/flux/dev
        /// </summary>
        /// <example>fal-ai/flux/dev</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Prompt used by the request when captured<br/>
        /// Example: cinematic portrait
        /// </summary>
        /// <example>cinematic portrait</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Request time when captured<br/>
        /// Example: 2026-05-23T20:00:00.000Z
        /// </summary>
        /// <example>2026-05-23T20:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineageNodeVariant3" /> class.
        /// </summary>
        /// <param name="id">
        /// Graph node ID<br/>
        /// Example: request:019e6d0a-e5be-7b82-b329-35ae64296902
        /// </param>
        /// <param name="requestId">
        /// Request ID<br/>
        /// Example: 019e6d0a-e5be-7b82-b329-35ae64296902
        /// </param>
        /// <param name="kind">
        /// Node kind
        /// </param>
        /// <param name="endpoint">
        /// Model endpoint that ran the request<br/>
        /// Example: fal-ai/flux/dev
        /// </param>
        /// <param name="prompt">
        /// Prompt used by the request when captured<br/>
        /// Example: cinematic portrait
        /// </param>
        /// <param name="createdAt">
        /// Request time when captured<br/>
        /// Example: 2026-05-23T20:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAssetLineageResponseLineageNodeVariant3(
            string id,
            string requestId,
            global::Fal.GetAssetLineageResponseLineageNodeVariant3Kind kind,
            string? endpoint,
            string? prompt,
            string? createdAt)
        {
            this.Kind = kind;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Endpoint = endpoint;
            this.Prompt = prompt;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineageNodeVariant3" /> class.
        /// </summary>
        public GetAssetLineageResponseLineageNodeVariant3()
        {
        }

    }
}