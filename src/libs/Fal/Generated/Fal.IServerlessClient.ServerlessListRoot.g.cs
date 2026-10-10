#nullable enable

namespace Fal
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// List files (root)<br/>
        /// Lists files and folders in the root of your project storage.<br/>
        /// **Required permissions:** `serverless:files:read`. Key presets that include them: `SERVERLESS`, `DEPLOY`, `READONLY`, `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Fal.ServerlessListRootResponseItem>> ServerlessListRootAsync(
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List files (root)<br/>
        /// Lists files and folders in the root of your project storage.<br/>
        /// **Required permissions:** `serverless:files:read`. Key presets that include them: `SERVERLESS`, `DEPLOY`, `READONLY`, `FULL`. See [key permissions](https://fal.ai/docs/documentation/model-apis/authentication/key-based#permissions).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Fal.ServerlessListRootResponseItem>>> ServerlessListRootAsResponseAsync(
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}