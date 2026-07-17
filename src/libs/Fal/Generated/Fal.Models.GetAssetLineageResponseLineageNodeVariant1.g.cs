
#nullable enable

namespace Fal
{
    /// <summary>
    /// An asset in the user's library
    /// </summary>
    public sealed partial class GetAssetLineageResponseLineageNodeVariant1
    {
        /// <summary>
        /// Node kind
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant1KindJsonConverter))]
        public global::Fal.GetAssetLineageResponseLineageNodeVariant1Kind Kind { get; set; }

        /// <summary>
        /// Graph node ID<br/>
        /// Example: asset:0f343b0931126a20f133d67c2b018a3b
        /// </summary>
        /// <example>asset:0f343b0931126a20f133d67c2b018a3b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Content-addressed asset identity (md5 of the media URL)<br/>
        /// Example: 0f343b0931126a20f133d67c2b018a3b
        /// </summary>
        /// <example>0f343b0931126a20f133d67c2b018a3b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputKey { get; set; }

        /// <summary>
        /// Media URL; null when the asset is deleted or expired<br/>
        /// Example: https://v3b.fal.media/files/b/0a9b4900/portrait.png
        /// </summary>
        /// <example>https://v3b.fal.media/files/b/0a9b4900/portrait.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Asset media type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant1TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.GetAssetLineageResponseLineageNodeVariant1Type Type { get; set; }

        /// <summary>
        /// Request that generated this asset<br/>
        /// Example: 019e6d0a-e5be-7b82-b329-35ae64296902
        /// </summary>
        /// <example>019e6d0a-e5be-7b82-b329-35ae64296902</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Asset ID (navigable handle); null when the asset is deleted or expired<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </summary>
        /// <example>d8b6elcregj72v34jr8g</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_id")]
        public string? AssetId { get; set; }

        /// <summary>
        /// Whether the asset has been deleted or has expired<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tombstone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Tombstone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineageNodeVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// Graph node ID<br/>
        /// Example: asset:0f343b0931126a20f133d67c2b018a3b
        /// </param>
        /// <param name="outputKey">
        /// Content-addressed asset identity (md5 of the media URL)<br/>
        /// Example: 0f343b0931126a20f133d67c2b018a3b
        /// </param>
        /// <param name="type">
        /// Asset media type
        /// </param>
        /// <param name="requestId">
        /// Request that generated this asset<br/>
        /// Example: 019e6d0a-e5be-7b82-b329-35ae64296902
        /// </param>
        /// <param name="tombstone">
        /// Whether the asset has been deleted or has expired<br/>
        /// Example: false
        /// </param>
        /// <param name="kind">
        /// Node kind
        /// </param>
        /// <param name="url">
        /// Media URL; null when the asset is deleted or expired<br/>
        /// Example: https://v3b.fal.media/files/b/0a9b4900/portrait.png
        /// </param>
        /// <param name="assetId">
        /// Asset ID (navigable handle); null when the asset is deleted or expired<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAssetLineageResponseLineageNodeVariant1(
            string id,
            string outputKey,
            global::Fal.GetAssetLineageResponseLineageNodeVariant1Type type,
            string requestId,
            bool tombstone,
            global::Fal.GetAssetLineageResponseLineageNodeVariant1Kind kind,
            string? url,
            string? assetId)
        {
            this.Kind = kind;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OutputKey = outputKey ?? throw new global::System.ArgumentNullException(nameof(outputKey));
            this.Url = url;
            this.Type = type;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.AssetId = assetId;
            this.Tombstone = tombstone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineageNodeVariant1" /> class.
        /// </summary>
        public GetAssetLineageResponseLineageNodeVariant1()
        {
        }

    }
}