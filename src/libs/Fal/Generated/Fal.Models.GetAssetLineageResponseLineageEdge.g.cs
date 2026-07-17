
#nullable enable

namespace Fal
{
    /// <summary>
    /// A directed edge in the lineage graph
    /// </summary>
    public sealed partial class GetAssetLineageResponseLineageEdge
    {
        /// <summary>
        /// Source node ID; edges point in generation-flow direction<br/>
        /// Example: external:9e107d9d372bb6826bd81d3542a419d6
        /// </summary>
        /// <example>external:9e107d9d372bb6826bd81d3542a419d6</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string From { get; set; }

        /// <summary>
        /// Target node ID<br/>
        /// Example: request:019e6d0a-e5be-7b82-b329-35ae64296902
        /// </summary>
        /// <example>request:019e6d0a-e5be-7b82-b329-35ae64296902</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string To { get; set; }

        /// <summary>
        /// How one lineage node relates to another
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.GetAssetLineageResponseLineageEdgeKindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.GetAssetLineageResponseLineageEdgeKind Kind { get; set; }

        /// <summary>
        /// Input role for input_to / referenced_entity edges; null for generated_by
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetAssetLineageResponseLineageEdgeRole?, object, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.AnyOf<global::Fal.GetAssetLineageResponseLineageEdgeRole?, object, object> Role { get; set; }

        /// <summary>
        /// input_to edges only: smart entities this input is the reference image of and that the request referenced
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::Fal.GetAssetLineageResponseLineageEdgeEntitie>? Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineageEdge" /> class.
        /// </summary>
        /// <param name="from">
        /// Source node ID; edges point in generation-flow direction<br/>
        /// Example: external:9e107d9d372bb6826bd81d3542a419d6
        /// </param>
        /// <param name="to">
        /// Target node ID<br/>
        /// Example: request:019e6d0a-e5be-7b82-b329-35ae64296902
        /// </param>
        /// <param name="kind">
        /// How one lineage node relates to another
        /// </param>
        /// <param name="role">
        /// Input role for input_to / referenced_entity edges; null for generated_by
        /// </param>
        /// <param name="entities">
        /// input_to edges only: smart entities this input is the reference image of and that the request referenced
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAssetLineageResponseLineageEdge(
            string from,
            string to,
            global::Fal.GetAssetLineageResponseLineageEdgeKind kind,
            global::Fal.AnyOf<global::Fal.GetAssetLineageResponseLineageEdgeRole?, object, object> role,
            global::System.Collections.Generic.IList<global::Fal.GetAssetLineageResponseLineageEdgeEntitie>? entities)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Kind = kind;
            this.Role = role;
            this.Entities = entities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponseLineageEdge" /> class.
        /// </summary>
        public GetAssetLineageResponseLineageEdge()
        {
        }

    }
}