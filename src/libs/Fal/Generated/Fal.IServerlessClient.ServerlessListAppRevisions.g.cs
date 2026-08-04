#nullable enable

namespace Fal
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Application Revisions<br/>
        /// Returns the revision history for an application, newest first: every<br/>
        /// deployed version with its creation time, whether it is currently serving<br/>
        /// traffic, and a deployment status derived from recent deployment events.<br/>
        /// **Use cases:**<br/>
        /// - Incident correlation: answer "did this regression start with a deploy?"<br/>
        ///   by lining revision boundaries up against error/latency changes from the<br/>
        ///   analytics endpoint<br/>
        /// - Rollback context: identify the previous known-good revision<br/>
        /// `status` and `deployed_by` are derived from the last 30 days of<br/>
        /// deployment events; older revisions return null for both. `message` and<br/>
        /// `annotations` are the deploy-time metadata set via `fal deploy<br/>
        /// --message`/`--annotation`; both are null when the deploy did not set them.<br/>
        /// **Authentication:** Required via API key. Only the app owner can query it.
        /// </summary>
        /// <param name="owner">
        /// Username of the app owner<br/>
        /// Example: user_123
        /// </param>
        /// <param name="name">
        /// Application name<br/>
        /// Example: my-app
        /// </param>
        /// <param name="limit">
        /// Maximum number of revisions to return per page (1-100)<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ServerlessListAppRevisionsResponse> ServerlessListAppRevisionsAsync(
            string owner,
            string name,
            int? limit = default,
            string? cursor = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Application Revisions<br/>
        /// Returns the revision history for an application, newest first: every<br/>
        /// deployed version with its creation time, whether it is currently serving<br/>
        /// traffic, and a deployment status derived from recent deployment events.<br/>
        /// **Use cases:**<br/>
        /// - Incident correlation: answer "did this regression start with a deploy?"<br/>
        ///   by lining revision boundaries up against error/latency changes from the<br/>
        ///   analytics endpoint<br/>
        /// - Rollback context: identify the previous known-good revision<br/>
        /// `status` and `deployed_by` are derived from the last 30 days of<br/>
        /// deployment events; older revisions return null for both. `message` and<br/>
        /// `annotations` are the deploy-time metadata set via `fal deploy<br/>
        /// --message`/`--annotation`; both are null when the deploy did not set them.<br/>
        /// **Authentication:** Required via API key. Only the app owner can query it.
        /// </summary>
        /// <param name="owner">
        /// Username of the app owner<br/>
        /// Example: user_123
        /// </param>
        /// <param name="name">
        /// Application name<br/>
        /// Example: my-app
        /// </param>
        /// <param name="limit">
        /// Maximum number of revisions to return per page (1-100)<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ServerlessListAppRevisionsResponse>> ServerlessListAppRevisionsAsResponseAsync(
            string owner,
            string name,
            int? limit = default,
            string? cursor = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}