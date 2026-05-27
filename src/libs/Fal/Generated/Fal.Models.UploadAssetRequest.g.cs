
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadAssetRequest
    {
        /// <summary>
        /// fal-hosted media URL to ingest into the asset library
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Media type for the uploaded asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.UploadAssetRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.UploadAssetRequestType Type { get; set; }

        /// <summary>
        /// Optional caller-provided caption or description to index with the uploaded asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Optional manual collection ID to add the uploaded asset to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_id")]
        public string? CollectionId { get; set; }

        /// <summary>
        /// Whether to favorite the uploaded asset immediately<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favorite")]
        public bool? Favorite { get; set; }

        /// <summary>
        /// Tag IDs to assign to the uploaded asset<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_ids")]
        public global::System.Collections.Generic.IList<string>? TagIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAssetRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// fal-hosted media URL to ingest into the asset library
        /// </param>
        /// <param name="type">
        /// Media type for the uploaded asset
        /// </param>
        /// <param name="prompt">
        /// Optional caller-provided caption or description to index with the uploaded asset
        /// </param>
        /// <param name="collectionId">
        /// Optional manual collection ID to add the uploaded asset to
        /// </param>
        /// <param name="favorite">
        /// Whether to favorite the uploaded asset immediately<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tagIds">
        /// Tag IDs to assign to the uploaded asset<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadAssetRequest(
            string url,
            global::Fal.UploadAssetRequestType type,
            string? prompt,
            string? collectionId,
            bool? favorite,
            global::System.Collections.Generic.IList<string>? tagIds)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
            this.Prompt = prompt;
            this.CollectionId = collectionId;
            this.Favorite = favorite;
            this.TagIds = tagIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAssetRequest" /> class.
        /// </summary>
        public UploadAssetRequest()
        {
        }

    }
}