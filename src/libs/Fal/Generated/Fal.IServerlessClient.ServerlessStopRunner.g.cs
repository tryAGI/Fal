#nullable enable

namespace Fal
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// Stop Runner<br/>
        /// Gracefully stops a serverless runner owned by the authenticated account.<br/>
        /// The runner stops accepting new requests and finishes in-flight work before shutting down.<br/>
        /// Set `replace_first=true` to start a replacement before stopping this runner.<br/>
        /// This option applies to deployed application runners, not standalone `fal run` runners.<br/>
        /// A successful response acknowledges the stop request; the runner may still be draining.<br/>
        /// Stopping a runner does not change the application's scaling configuration, so autoscaling may start new runners.<br/>
        /// **Required permissions:** `serverless:runners:terminate`. Key presets that include them: `COMPUTE`, `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="runnerId">
        /// ID of the serverless runner to stop<br/>
        /// Example: f1e2d3c4-b5a6-7890-dcba-0987654321fe
        /// </param>
        /// <param name="replaceFirst">
        /// Whether to start a replacement runner before stopping this one. Defaults to false.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.ServerlessStopRunnerResponse> ServerlessStopRunnerAsync(
            string runnerId,
            global::Fal.ServerlessStopRunnerReplaceFirst? replaceFirst = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stop Runner<br/>
        /// Gracefully stops a serverless runner owned by the authenticated account.<br/>
        /// The runner stops accepting new requests and finishes in-flight work before shutting down.<br/>
        /// Set `replace_first=true` to start a replacement before stopping this runner.<br/>
        /// This option applies to deployed application runners, not standalone `fal run` runners.<br/>
        /// A successful response acknowledges the stop request; the runner may still be draining.<br/>
        /// Stopping a runner does not change the application's scaling configuration, so autoscaling may start new runners.<br/>
        /// **Required permissions:** `serverless:runners:terminate`. Key presets that include them: `COMPUTE`, `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="runnerId">
        /// ID of the serverless runner to stop<br/>
        /// Example: f1e2d3c4-b5a6-7890-dcba-0987654321fe
        /// </param>
        /// <param name="replaceFirst">
        /// Whether to start a replacement runner before stopping this one. Defaults to false.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ServerlessStopRunnerResponse>> ServerlessStopRunnerAsResponseAsync(
            string runnerId,
            global::Fal.ServerlessStopRunnerReplaceFirst? replaceFirst = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}