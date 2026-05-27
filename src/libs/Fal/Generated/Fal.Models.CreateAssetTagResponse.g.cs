
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAssetTagResponse
    {
        /// <summary>
        /// Asset tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.CreateAssetTagResponseTag Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetTagResponse" /> class.
        /// </summary>
        /// <param name="tag">
        /// Asset tag
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetTagResponse(
            global::Fal.CreateAssetTagResponseTag tag)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetTagResponse" /> class.
        /// </summary>
        public CreateAssetTagResponse()
        {
        }

    }
}