
#nullable enable

namespace Fal
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignAssetTagResponse
    {
        /// <summary>
        /// Whether the operation succeeded<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignAssetTagResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the operation succeeded<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignAssetTagResponse(
            bool success)
        {
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignAssetTagResponse" /> class.
        /// </summary>
        public AssignAssetTagResponse()
        {
        }

    }
}