
#nullable enable

namespace Fal
{
    /// <summary>
    /// The workflow definition/configuration object<br/>
    /// Example: {"name":"my-image-workflow","version":"1.0.0","nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"run","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}}},"output":{"image":"$node_a1b2c3.images.0.url"},"schema":{"input":{"prompt":{"type":"string"}},"output":{"image":{"type":"string"}}}}
    /// </summary>
    public sealed partial class CreateWorkflowRequestContents
    {
        /// <summary>
        /// Internal name of the workflow definition<br/>
        /// Example: my-image-workflow
        /// </summary>
        /// <example>my-image-workflow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Workflow definition format version<br/>
        /// Example: 1.0.0
        /// </summary>
        /// <example>1.0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Workflow nodes keyed by node id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object> Nodes { get; set; }

        /// <summary>
        /// Output field mappings keyed by output name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Output { get; set; }

        /// <summary>
        /// Input/output schema for the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.CreateWorkflowRequestContentsSchema Schema { get; set; }

        /// <summary>
        /// Optional workflow metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowRequestContents" /> class.
        /// </summary>
        /// <param name="name">
        /// Internal name of the workflow definition<br/>
        /// Example: my-image-workflow
        /// </param>
        /// <param name="version">
        /// Workflow definition format version<br/>
        /// Example: 1.0.0
        /// </param>
        /// <param name="nodes">
        /// Workflow nodes keyed by node id
        /// </param>
        /// <param name="output">
        /// Output field mappings keyed by output name
        /// </param>
        /// <param name="schema">
        /// Input/output schema for the workflow
        /// </param>
        /// <param name="metadata">
        /// Optional workflow metadata
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflowRequestContents(
            string name,
            string version,
            global::System.Collections.Generic.Dictionary<string, object> nodes,
            global::System.Collections.Generic.Dictionary<string, string> output,
            global::Fal.CreateWorkflowRequestContentsSchema schema,
            object? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowRequestContents" /> class.
        /// </summary>
        public CreateWorkflowRequestContents()
        {
        }

    }
}