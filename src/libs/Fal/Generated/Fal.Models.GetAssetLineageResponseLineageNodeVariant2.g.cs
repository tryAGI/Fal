
#nullable enable

namespace Fal
{
    /// <summary>
    /// An input that is not (or no longer) in the asset library
    /// </summary>
    public sealed partial class GetAssetLineageResponseLineageNodeVariant2
    {
        /// <summary>
        /// Node kind
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant2KindJsonConverter))]
        public global::Fal.GetAssetLineageResponseLineageNodeVariant2Kind Kind { get; set; }

        /// <summary>
        /// Graph node ID<br/>
        /// Example: external:9e107d9d372bb6826bd81d3542a419d6
        /// </summary>
        /// <example>external:9e107d9d372bb6826bd81d3542a419d6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Content-addressed asset identity (md5 of the media URL)<br/>
        /// Example: 9e107d9d372bb6826bd81d3542a419d6
        /// </summary>
        /// <example>9e107d9d372bb6826bd81d3542a419d6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputKey { get; set; }

        /// <summary>
        /// Source media URL when known<br/>
        /// Example: https://fal.media/files/source.png
        /// </summary>
        /// <example>https://fal.media/files/source.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineageNodeVariant2" /> class.
        /// </summary>
        /// <param name="id">
        /// Graph node ID<br/>
        /// Example: external:9e107d9d372bb6826bd81d3542a419d6
        /// </param>
        /// <param name="outputKey">
        /// Content-addressed asset identity (md5 of the media URL)<br/>
        /// Example: 9e107d9d372bb6826bd81d3542a419d6
        /// </param>
        /// <param name="kind">
        /// Node kind
        /// </param>
        /// <param name="url">
        /// Source media URL when known<br/>
        /// Example: https://fal.media/files/source.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAssetLineageResponseLineageNodeVariant2(
            string id,
            string outputKey,
            global::Fal.GetAssetLineageResponseLineageNodeVariant2Kind kind,
            string? url)
        {
            this.Kind = kind;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OutputKey = outputKey ?? throw new global::System.ArgumentNullException(nameof(outputKey));
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineageNodeVariant2" /> class.
        /// </summary>
        public GetAssetLineageResponseLineageNodeVariant2()
        {
        }

    }
}