
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItem
    {
        /// <summary>
        /// Collection ID<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </summary>
        /// <example>d8b6elcregj72v34jr8g</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Collection display name<br/>
        /// Example: Campaign concepts
        /// </summary>
        /// <example>Campaign concepts</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Collection type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType Type { get; set; }

        /// <summary>
        /// Child collections
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItem> Children { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Collection ID<br/>
        /// Example: d8b6elcregj72v34jr8g
        /// </param>
        /// <param name="name">
        /// Collection display name<br/>
        /// Example: Campaign concepts
        /// </param>
        /// <param name="type">
        /// Collection type
        /// </param>
        /// <param name="children">
        /// Child collections
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItem(
            string id,
            string name,
            global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType type,
            global::System.Collections.Generic.IList<global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItem> children)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Children = children ?? throw new global::System.ArgumentNullException(nameof(children));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItem" /> class.
        /// </summary>
        public GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItem()
        {
        }

    }
}