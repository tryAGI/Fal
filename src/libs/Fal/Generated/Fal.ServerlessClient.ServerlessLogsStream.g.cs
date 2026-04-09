
#nullable enable

namespace Fal
{
    public partial class ServerlessClient
    {


        private static readonly global::Fal.EndPointSecurityRequirement s_ServerlessLogsStreamSecurityRequirement0 =
            new global::Fal.EndPointSecurityRequirement
            {
                Authorizations = new global::Fal.EndPointAuthorizationRequirement[]
                {                    new global::Fal.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Fal.EndPointSecurityRequirement[] s_ServerlessLogsStreamSecurityRequirements =
            new global::Fal.EndPointSecurityRequirement[]
            {                s_ServerlessLogsStreamSecurityRequirement0,
            };
        partial void PrepareServerlessLogsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Fal.AnyOf<global::System.DateTime?, string>? start,
            ref global::Fal.AnyOf<global::System.DateTime?, string>? end,
            global::System.Collections.Generic.IList<string>? appId,
            ref string? revision,
            ref global::Fal.ServerlessLogsStreamRunSource? runSource,
            ref bool? traceback,
            ref string? search,
            ref string? level,
            ref string? jobId,
            ref string? requestId,
            global::System.Collections.Generic.IList<global::Fal.ServerlessLogsStreamRequestItem> request);
        partial void PrepareServerlessLogsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Fal.AnyOf<global::System.DateTime?, string>? start,
            global::Fal.AnyOf<global::System.DateTime?, string>? end,
            global::System.Collections.Generic.IList<string>? appId,
            string? revision,
            global::Fal.ServerlessLogsStreamRunSource? runSource,
            bool? traceback,
            string? search,
            string? level,
            string? jobId,
            string? requestId,
            global::System.Collections.Generic.IList<global::Fal.ServerlessLogsStreamRequestItem> request);
        partial void ProcessServerlessLogsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Logs stream (SSE)<br/>
        /// Streams live logs that match the provided filters using Server-Sent Events.
        /// </summary>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="appId">
        /// Filter by app IDs<br/>
        /// Example: [my-app]
        /// </param>
        /// <param name="revision">
        /// Filter by revision<br/>
        /// Example: rev_abc123
        /// </param>
        /// <param name="runSource">
        /// Filter by run source<br/>
        /// Example: grpc-run
        /// </param>
        /// <param name="traceback">
        /// Include tracebacks<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="search">
        /// Free-text search<br/>
        /// Example: error
        /// </param>
        /// <param name="level">
        /// Minimum log level<br/>
        /// Example: error
        /// </param>
        /// <param name="jobId">
        /// Filter by job id<br/>
        /// Example: job_123
        /// </param>
        /// <param name="requestId">
        /// Filter by request id<br/>
        /// Example: req_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<string> ServerlessLogsStreamAsync(

            global::System.Collections.Generic.IList<global::Fal.ServerlessLogsStreamRequestItem> request,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::System.Collections.Generic.IList<string>? appId = default,
            string? revision = default,
            global::Fal.ServerlessLogsStreamRunSource? runSource = default,
            bool? traceback = default,
            string? search = default,
            string? level = default,
            string? jobId = default,
            string? requestId = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareServerlessLogsStreamArguments(
                httpClient: HttpClient,
                start: ref start,
                end: ref end,
                appId: appId,
                revision: ref revision,
                runSource: ref runSource,
                traceback: ref traceback,
                search: ref search,
                level: ref level,
                jobId: ref jobId,
                requestId: ref requestId,
                request: request);


            var __authorizations = global::Fal.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ServerlessLogsStreamSecurityRequirements,
                operationName: "ServerlessLogsStreamAsync");

            var __pathBuilder = new global::Fal.PathBuilder(
                path: "/serverless/logs/stream",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("start", start?.ToString())
                .AddOptionalParameter("end", end?.ToString())
                .AddOptionalParameter("app_id", appId, delimiter: ",", explode: true)
                .AddOptionalParameter("revision", revision)
                .AddOptionalParameter("run_source", runSource?.ToValueString())
                .AddOptionalParameter("traceback", traceback?.ToString().ToLowerInvariant())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("level", level)
                .AddOptionalParameter("job_id", jobId)
                .AddOptionalParameter("request_id", requestId) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareServerlessLogsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                start: start,
                end: end,
                appId: appId,
                revision: revision,
                runSource: runSource,
                traceback: traceback,
                search: search,
                level: level,
                jobId: jobId,
                requestId: requestId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessServerlessLogsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                string? __content = null;
                try
                {
                    __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);
                }
                catch (global::System.Exception)
                {
                }

                throw new global::Fal.ApiException(
                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(string), JsonSerializerContext) ??
                                       throw new global::Fal.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
    }
}