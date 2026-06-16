#nullable enable

namespace Fal
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Create a workflow<br/>
        /// Create a new workflow owned by the authenticated user.<br/>
        /// **Authentication:** Required.<br/>
        /// **Common Use Cases:**<br/>
        /// - Save a newly built workflow<br/>
        /// - Programmatically provision workflows<br/>
        /// **Note:** Workflow names must be unique within your namespace. Creating a<br/>
        /// workflow with a name you already use returns a 400 validation error.<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.CreateWorkflowResponse> CreateWorkflowAsync(

            global::Fal.CreateWorkflowRequest request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a workflow<br/>
        /// Create a new workflow owned by the authenticated user.<br/>
        /// **Authentication:** Required.<br/>
        /// **Common Use Cases:**<br/>
        /// - Save a newly built workflow<br/>
        /// - Programmatically provision workflows<br/>
        /// **Note:** Workflow names must be unique within your namespace. Creating a<br/>
        /// workflow with a name you already use returns a 400 validation error.<br/>
        ///     
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.CreateWorkflowResponse>> CreateWorkflowAsResponseAsync(

            global::Fal.CreateWorkflowRequest request,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a workflow<br/>
        /// Create a new workflow owned by the authenticated user.<br/>
        /// **Authentication:** Required.<br/>
        /// **Common Use Cases:**<br/>
        /// - Save a newly built workflow<br/>
        /// - Programmatically provision workflows<br/>
        /// **Note:** Workflow names must be unique within your namespace. Creating a<br/>
        /// workflow with a name you already use returns a 400 validation error.<br/>
        ///     
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.CreateWorkflowResponse> CreateWorkflowAsync(
            string name,
            string title,
            global::Fal.CreateWorkflowRequestContents contents,
            bool? isPublic = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}