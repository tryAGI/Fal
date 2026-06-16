
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MoveAssetCollectionRequest
    {
        /// <summary>
        /// Parent collection ID to move this collection under, or null to move it to the top level. Must be a manual collection; nesting is limited to 5 levels and cannot create a cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_collection_id")]
        public string? ParentCollectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveAssetCollectionRequest" /> class.
        /// </summary>
        /// <param name="parentCollectionId">
        /// Parent collection ID to move this collection under, or null to move it to the top level. Must be a manual collection; nesting is limited to 5 levels and cannot create a cycle.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MoveAssetCollectionRequest(
            string? parentCollectionId)
        {
            this.ParentCollectionId = parentCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveAssetCollectionRequest" /> class.
        /// </summary>
        public MoveAssetCollectionRequest()
        {
        }

    }
}