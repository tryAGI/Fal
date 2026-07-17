
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset lineage response
    /// </summary>
    public sealed partial class GetAssetLineageResponse
    {
        /// <summary>
        /// Derivation lineage graph of the asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.GetAssetLineageResponseLineage Lineage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponse" /> class.
        /// </summary>
        /// <param name="lineage">
        /// Derivation lineage graph of the asset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAssetLineageResponse(
            global::Fal.GetAssetLineageResponseLineage lineage)
        {
            this.Lineage = lineage ?? throw new global::System.ArgumentNullException(nameof(lineage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAssetLineageResponse" /> class.
        /// </summary>
        public GetAssetLineageResponse()
        {
        }

    }
}