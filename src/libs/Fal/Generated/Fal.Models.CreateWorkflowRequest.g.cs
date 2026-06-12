
#nullable enable

namespace Fal
{
    /// <summary>
    /// Request body for creating a new workflow
    /// </summary>
    public sealed partial class CreateWorkflowRequest
    {
        /// <summary>
        /// Unique workflow name/slug within the user's namespace<br/>
        /// Example: my-image-workflow
        /// </summary>
        /// <example>my-image-workflow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable workflow title<br/>
        /// Example: My Image Generation Workflow
        /// </summary>
        /// <example>My Image Generation Workflow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The workflow definition/configuration object<br/>
        /// Example: {"name":"my-image-workflow","version":"1.0.0","nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"run","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}}},"output":{"image":"$node_a1b2c3.images.0.url"},"schema":{"input":{"prompt":{"type":"string"}},"output":{"image":{"type":"string"}}}}
        /// </summary>
        /// <example>{"name":"my-image-workflow","version":"1.0.0","nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"run","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}}},"output":{"image":"$node_a1b2c3.images.0.url"},"schema":{"input":{"prompt":{"type":"string"}},"output":{"image":{"type":"string"}}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.CreateWorkflowRequestContents Contents { get; set; }

        /// <summary>
        /// Whether the workflow is publicly visible<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique workflow name/slug within the user's namespace<br/>
        /// Example: my-image-workflow
        /// </param>
        /// <param name="title">
        /// Human-readable workflow title<br/>
        /// Example: My Image Generation Workflow
        /// </param>
        /// <param name="contents">
        /// The workflow definition/configuration object<br/>
        /// Example: {"name":"my-image-workflow","version":"1.0.0","nodes":{"node_a1b2c3":{"id":"node_a1b2c3","type":"run","app":"fal-ai/flux/dev","depends":[],"input":{"prompt":"$input.prompt"},"metadata":{"position":{"x":300,"y":100}}}},"output":{"image":"$node_a1b2c3.images.0.url"},"schema":{"input":{"prompt":{"type":"string"}},"output":{"image":{"type":"string"}}}}
        /// </param>
        /// <param name="isPublic">
        /// Whether the workflow is publicly visible<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflowRequest(
            string name,
            string title,
            global::Fal.CreateWorkflowRequestContents contents,
            bool? isPublic)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Contents = contents ?? throw new global::System.ArgumentNullException(nameof(contents));
            this.IsPublic = isPublic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowRequest" /> class.
        /// </summary>
        public CreateWorkflowRequest()
        {
        }

    }
}