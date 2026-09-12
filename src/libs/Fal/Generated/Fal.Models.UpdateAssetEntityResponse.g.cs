
#nullable enable

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAssetEntityResponse
    {
        /// <summary>
        /// Saved smart entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.UpdateAssetEntityResponseEntity Entity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetEntityResponse" /> class.
        /// </summary>
        /// <param name="entity">
        /// Saved smart entity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAssetEntityResponse(
            global::Fal.UpdateAssetEntityResponseEntity entity)
        {
            this.Entity = entity ?? throw new global::System.ArgumentNullException(nameof(entity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetEntityResponse" /> class.
        /// </summary>
        public UpdateAssetEntityResponse()
        {
        }

    }
}