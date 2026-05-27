
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAssetCharactersResponse
    {
        /// <summary>
        /// Asset characters visible to the authenticated user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.ListAssetCharactersResponseCharacter> Characters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetCharactersResponse" /> class.
        /// </summary>
        /// <param name="characters">
        /// Asset characters visible to the authenticated user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAssetCharactersResponse(
            global::System.Collections.Generic.IList<global::Fal.ListAssetCharactersResponseCharacter> characters)
        {
            this.Characters = characters ?? throw new global::System.ArgumentNullException(nameof(characters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAssetCharactersResponse" /> class.
        /// </summary>
        public ListAssetCharactersResponse()
        {
        }

    }
}