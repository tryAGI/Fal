
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAssetTagResponse
    {
        /// <summary>
        /// Asset tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.UpdateAssetTagResponseTag Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetTagResponse" /> class.
        /// </summary>
        /// <param name="tag">
        /// Asset tag
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAssetTagResponse(
            global::Fal.UpdateAssetTagResponseTag tag)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetTagResponse" /> class.
        /// </summary>
        public UpdateAssetTagResponse()
        {
        }

    }
}