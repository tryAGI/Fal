
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAssetPromptRequest
    {
        /// <summary>
        /// Updated prompt or description for an uploaded asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetPromptRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Updated prompt or description for an uploaded asset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAssetPromptRequest(
            string prompt)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetPromptRequest" /> class.
        /// </summary>
        public UpdateAssetPromptRequest()
        {
        }

    }
}