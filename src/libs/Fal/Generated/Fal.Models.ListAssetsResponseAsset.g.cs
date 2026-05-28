
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset item
    /// </summary>
    public sealed partial class ListAssetsResponseAsset
    {
        /// <summary>
        /// Vector ID<br/>
        /// Example: b1a2b4a5-cb89-51dc-a108-6dbfd8e742fc
        /// </summary>
        /// <example>b1a2b4a5-cb89-51dc-a108-6dbfd8e742fc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VectorId { get; set; }

        /// <summary>
        /// Request ID<br/>
        /// Example: 019e6d0a-e5be-7b82-b329-35ae64296902
        /// </summary>
        /// <example>019e6d0a-e5be-7b82-b329-35ae64296902</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Media URL<br/>
        /// Example: https://v3b.fal.media/files/b/0a9b4900/PDbTGyzqRh1aijW2WQiY9_opengraph-1%20%281%29.png
        /// </summary>
        /// <example>https://v3b.fal.media/files/b/0a9b4900/PDbTGyzqRh1aijW2WQiY9_opengraph-1%20%281%29.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Asset media type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.ListAssetsResponseAssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.ListAssetsResponseAssetType Type { get; set; }

        /// <summary>
        /// Display title<br/>
        /// Example: Portrait
        /// </summary>
        /// <example>Portrait</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Model endpoint that produced the asset<br/>
        /// Example: fal-ai/flux/dev
        /// </summary>
        /// <example>fal-ai/flux/dev</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        public string? Endpoint { get; set; }

        /// <summary>
        /// Asset creation time<br/>
        /// Example: 2026-05-23T20:00:00.000Z
        /// </summary>
        /// <example>2026-05-23T20:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Asset source<br/>
        /// Example: upload
        /// </summary>
        /// <example>upload</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Saved prompt or description<br/>
        /// Example: cinematic portrait
        /// </summary>
        /// <example>cinematic portrait</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Width in pixels<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Height in pixels<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// Media content type<br/>
        /// Example: image/png
        /// </summary>
        /// <example>image/png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Whether the asset is favorited<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_favorited")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFavorited { get; set; }

        /// <summary>
        /// Collections containing this asset<br/>
        /// Example: [d8b6elcregj72v34jr8g]
        /// </summary>
        /// <example>[d8b6elcregj72v34jr8g]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CollectionIds { get; set; }

        /// <summary>
        /// Assigned tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.ListAssetsResponseAssetTag> Tags { get; set; }

        /// <summary>
        /// Semantic similarity score when applicable<br/>
        /// Example: 0.92F
        /// </summary>
        /// <example>0.92F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        public double? Similarity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetsResponseAsset" /> class.
        /// </summary>
        /// <param name="vectorId">
        /// Vector ID<br/>
        /// Example: b1a2b4a5-cb89-51dc-a108-6dbfd8e742fc
        /// </param>
        /// <param name="type">
        /// Asset media type
        /// </param>
        /// <param name="title">
        /// Display title<br/>
        /// Example: Portrait
        /// </param>
        /// <param name="isFavorited">
        /// Whether the asset is favorited<br/>
        /// Example: false
        /// </param>
        /// <param name="collectionIds">
        /// Collections containing this asset<br/>
        /// Example: [d8b6elcregj72v34jr8g]
        /// </param>
        /// <param name="tags">
        /// Assigned tags
        /// </param>
        /// <param name="requestId">
        /// Request ID<br/>
        /// Example: 019e6d0a-e5be-7b82-b329-35ae64296902
        /// </param>
        /// <param name="url">
        /// Media URL<br/>
        /// Example: https://v3b.fal.media/files/b/0a9b4900/PDbTGyzqRh1aijW2WQiY9_opengraph-1%20%281%29.png
        /// </param>
        /// <param name="endpoint">
        /// Model endpoint that produced the asset<br/>
        /// Example: fal-ai/flux/dev
        /// </param>
        /// <param name="createdAt">
        /// Asset creation time<br/>
        /// Example: 2026-05-23T20:00:00.000Z
        /// </param>
        /// <param name="source">
        /// Asset source<br/>
        /// Example: upload
        /// </param>
        /// <param name="prompt">
        /// Saved prompt or description<br/>
        /// Example: cinematic portrait
        /// </param>
        /// <param name="width">
        /// Width in pixels<br/>
        /// Example: 1024
        /// </param>
        /// <param name="height">
        /// Height in pixels<br/>
        /// Example: 1024
        /// </param>
        /// <param name="contentType">
        /// Media content type<br/>
        /// Example: image/png
        /// </param>
        /// <param name="similarity">
        /// Semantic similarity score when applicable<br/>
        /// Example: 0.92F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAssetsResponseAsset(
            string vectorId,
            global::Fal.ListAssetsResponseAssetType type,
            string title,
            bool isFavorited,
            global::System.Collections.Generic.IList<string> collectionIds,
            global::System.Collections.Generic.IList<global::Fal.ListAssetsResponseAssetTag> tags,
            string? requestId,
            string? url,
            string? endpoint,
            string? createdAt,
            string? source,
            string? prompt,
            double? width,
            double? height,
            string? contentType,
            double? similarity)
        {
            this.VectorId = vectorId ?? throw new global::System.ArgumentNullException(nameof(vectorId));
            this.RequestId = requestId;
            this.Url = url;
            this.Type = type;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Endpoint = endpoint;
            this.CreatedAt = createdAt;
            this.Source = source;
            this.Prompt = prompt;
            this.Width = width;
            this.Height = height;
            this.ContentType = contentType;
            this.IsFavorited = isFavorited;
            this.CollectionIds = collectionIds ?? throw new global::System.ArgumentNullException(nameof(collectionIds));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Similarity = similarity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetsResponseAsset" /> class.
        /// </summary>
        public ListAssetsResponseAsset()
        {
        }

    }
}