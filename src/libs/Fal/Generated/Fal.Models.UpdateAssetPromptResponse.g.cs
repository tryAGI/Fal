
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAssetPromptResponse
    {
        /// <summary>
        /// Asset details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.UpdateAssetPromptResponseAsset Asset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetPromptResponse" /> class.
        /// </summary>
        /// <param name="asset">
        /// Asset details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAssetPromptResponse(
            global::Fal.UpdateAssetPromptResponseAsset asset)
        {
            this.Asset = asset ?? throw new global::System.ArgumentNullException(nameof(asset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetPromptResponse" /> class.
        /// </summary>
        public UpdateAssetPromptResponse()
        {
        }

    }
}