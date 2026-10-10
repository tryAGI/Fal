#nullable enable

namespace Fal
{
    public partial interface IComputeClient
    {
        /// <summary>
        /// Compute Metrics<br/>
        /// Returns Prometheus-compatible metrics for an active compute cluster owned by the authenticated caller. Requires compute access and compute:instances:read permission. Use the compute_cluster query parameter to select the cluster by label.<br/>
        /// **Required permissions:** `compute:instances:read`. Key presets that include them: `COMPUTE`, `READONLY`, `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="computeCluster">
        /// The label of the compute cluster owned by the caller<br/>
        /// Example: my-cluster
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetComputeMetricsAsync(
            string computeCluster,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compute Metrics<br/>
        /// Returns Prometheus-compatible metrics for an active compute cluster owned by the authenticated caller. Requires compute access and compute:instances:read permission. Use the compute_cluster query parameter to select the cluster by label.<br/>
        /// **Required permissions:** `compute:instances:read`. Key presets that include them: `COMPUTE`, `READONLY`, `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="computeCluster">
        /// The label of the compute cluster owned by the caller<br/>
        /// Example: my-cluster
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<string>> GetComputeMetricsAsResponseAsync(
            string computeCluster,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}