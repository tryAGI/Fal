
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAssetCollectionHierarchyResponse
    {
        /// <summary>
        /// Subtree rooted at the requested collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.GetAssetCollectionHierarchyResponseHierarchy Hierarchy { get; set; }

        /// <summary>
        /// Ancestor collections ordered from the top level down to the direct parent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ancestors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.GetAssetCollectionHierarchyResponseAncestor> Ancestors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetCollectionHierarchyResponse" /> class.
        /// </summary>
        /// <param name="hierarchy">
        /// Subtree rooted at the requested collection
        /// </param>
        /// <param name="ancestors">
        /// Ancestor collections ordered from the top level down to the direct parent
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAssetCollectionHierarchyResponse(
            global::Fal.GetAssetCollectionHierarchyResponseHierarchy hierarchy,
            global::System.Collections.Generic.IList<global::Fal.GetAssetCollectionHierarchyResponseAncestor> ancestors)
        {
            this.Hierarchy = hierarchy ?? throw new global::System.ArgumentNullException(nameof(hierarchy));
            this.Ancestors = ancestors ?? throw new global::System.ArgumentNullException(nameof(ancestors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetCollectionHierarchyResponse" /> class.
        /// </summary>
        public GetAssetCollectionHierarchyResponse()
        {
        }

    }
}