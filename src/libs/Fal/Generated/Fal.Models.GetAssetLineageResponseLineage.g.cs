
#nullable enable

namespace Fal
{
    /// <summary>
    /// Derivation lineage graph of the asset
    /// </summary>
    public sealed partial class GetAssetLineageResponseLineage
    {
        /// <summary>
        /// Node ID of the queried asset<br/>
        /// Example: asset:0f343b0931126a20f133d67c2b018a3b
        /// </summary>
        /// <example>asset:0f343b0931126a20f133d67c2b018a3b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("focus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Focus { get; set; }

        /// <summary>
        /// Lineage graph nodes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>> Nodes { get; set; }

        /// <summary>
        /// Lineage graph edges
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.GetAssetLineageResponseLineageEdge> Edges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineage" /> class.
        /// </summary>
        /// <param name="focus">
        /// Node ID of the queried asset<br/>
        /// Example: asset:0f343b0931126a20f133d67c2b018a3b
        /// </param>
        /// <param name="nodes">
        /// Lineage graph nodes
        /// </param>
        /// <param name="edges">
        /// Lineage graph edges
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAssetLineageResponseLineage(
            string focus,
            global::System.Collections.Generic.IList<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>> nodes,
            global::System.Collections.Generic.IList<global::Fal.GetAssetLineageResponseLineageEdge> edges)
        {
            this.Focus = focus ?? throw new global::System.ArgumentNullException(nameof(focus));
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Edges = edges ?? throw new global::System.ArgumentNullException(nameof(edges));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineage" /> class.
        /// </summary>
        public GetAssetLineageResponseLineage()
        {
        }

    }
}