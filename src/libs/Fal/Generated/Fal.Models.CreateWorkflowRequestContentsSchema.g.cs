
#nullable enable

namespace Fal
{
    /// <summary>
    /// Input/output schema for the workflow
    /// </summary>
    public sealed partial class CreateWorkflowRequestContentsSchema
    {
        /// <summary>
        /// Input fields schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Output fields schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowRequestContentsSchema" /> class.
        /// </summary>
        /// <param name="input">
        /// Input fields schema
        /// </param>
        /// <param name="output">
        /// Output fields schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflowRequestContentsSchema(
            object input,
            object output)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowRequestContentsSchema" /> class.
        /// </summary>
        public CreateWorkflowRequestContentsSchema()
        {
        }

    }
}