
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAssetCharacterResponse
    {
        /// <summary>
        /// Asset character
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.UpdateAssetCharacterResponseCharacter Character { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetCharacterResponse" /> class.
        /// </summary>
        /// <param name="character">
        /// Asset character
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAssetCharacterResponse(
            global::Fal.UpdateAssetCharacterResponseCharacter character)
        {
            this.Character = character ?? throw new global::System.ArgumentNullException(nameof(character));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssetCharacterResponse" /> class.
        /// </summary>
        public UpdateAssetCharacterResponse()
        {
        }

    }
}