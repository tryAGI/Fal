
#nullable enable

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListAssetEntitiesResponse
    {
        /// <summary>
        /// Saved smart entities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.ListAssetEntitiesResponseEntitie> Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetEntitiesResponse" /> class.
        /// </summary>
        /// <param name="entities">
        /// Saved smart entities
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAssetEntitiesResponse(
            global::System.Collections.Generic.IList<global::Fal.ListAssetEntitiesResponseEntitie> entities)
        {
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetEntitiesResponse" /> class.
        /// </summary>
        public ListAssetEntitiesResponse()
        {
        }

    }
}