#nullable enable

namespace Fal
{
    public partial interface IServerlessClient
    {
        /// <summary>
        /// List files (directory)<br/>
        /// Lists files and folders within the specified directory path.
        /// </summary>
        /// <param name="dir">
        /// Directory path to list<br/>
        /// Example: datasets/images
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Fal.ServerlessListDirectoryResponseItem>> ServerlessListDirectoryAsync(
            string dir,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}