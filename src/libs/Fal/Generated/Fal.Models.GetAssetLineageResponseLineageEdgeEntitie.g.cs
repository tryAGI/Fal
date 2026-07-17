
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAssetLineageResponseLineageEdgeEntitie
    {
        /// <summary>
        /// Smart entity ID<br/>
        /// Example: 43ce3411-1a25-4d14-875e-3562d341b090
        /// </summary>
        /// <example>43ce3411-1a25-4d14-875e-3562d341b090</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// Smart entity type<br/>
        /// Example: character
        /// </summary>
        /// <example>character</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.GetAssetLineageResponseLineageEdgeEntitieEntityTypeJsonConverter))]
        public global::Fal.GetAssetLineageResponseLineageEdgeEntitieEntityType EntityType { get; set; }

        /// <summary>
        /// Entity display name; null when the entity is deleted<br/>
        /// Example: Alice
        /// </summary>
        /// <example>Alice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Entity @mention handle; null when the entity is deleted<br/>
        /// Example: alice
        /// </summary>
        /// <example>alice</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineageEdgeEntitie" /> class.
        /// </summary>
        /// <param name="entityId">
        /// Smart entity ID<br/>
        /// Example: 43ce3411-1a25-4d14-875e-3562d341b090
        /// </param>
        /// <param name="entityType">
        /// Smart entity type<br/>
        /// Example: character
        /// </param>
        /// <param name="name">
        /// Entity display name; null when the entity is deleted<br/>
        /// Example: Alice
        /// </param>
        /// <param name="handle">
        /// Entity @mention handle; null when the entity is deleted<br/>
        /// Example: alice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAssetLineageResponseLineageEdgeEntitie(
            string entityId,
            global::Fal.GetAssetLineageResponseLineageEdgeEntitieEntityType entityType,
            string? name,
            string? handle)
        {
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.EntityType = entityType;
            this.Name = name;
            this.Handle = handle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineageEdgeEntitie" /> class.
        /// </summary>
        public GetAssetLineageResponseLineageEdgeEntitie()
        {
        }

    }
}