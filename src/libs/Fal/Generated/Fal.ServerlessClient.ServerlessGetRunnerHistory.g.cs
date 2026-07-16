
#nullable enable

namespace Fal
{
    public partial class ServerlessClient
    {


        private static readonly global::Fal.EndPointSecurityRequirement s_ServerlessGetRunnerHistorySecurityRequirement0 =
            new global::Fal.EndPointSecurityRequirement
            {
                Authorizations = new global::Fal.EndPointAuthorizationRequirement[]
                {                    new global::Fal.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Fal.EndPointSecurityRequirement[] s_ServerlessGetRunnerHistorySecurityRequirements =
            new global::Fal.EndPointSecurityRequirement[]
            {                s_ServerlessGetRunnerHistorySecurityRequirement0,
            };
        partial void PrepareServerlessGetRunnerHistoryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string name,
            ref global::Fal.AnyOf<global::System.DateTime?, string>? start,
            ref global::Fal.AnyOf<global::System.DateTime?, string>? end,
            ref global::Fal.ServerlessGetRunnerHistoryTimeframe? timeframe,
            ref global::Fal.ServerlessGetRunnerHistoryAggregation? aggregation);
        partial void PrepareServerlessGetRunnerHistoryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string name,
            global::Fal.AnyOf<global::System.DateTime?, string>? start,
            global::Fal.AnyOf<global::System.DateTime?, string>? end,
            global::Fal.ServerlessGetRunnerHistoryTimeframe? timeframe,
            global::Fal.ServerlessGetRunnerHistoryAggregation? aggregation);
        partial void ProcessServerlessGetRunnerHistoryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessServerlessGetRunnerHistoryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Runner State History<br/>
        /// Returns historical runner counts by state (running, idle, pending, draining)<br/>
        /// for an application, bucketed over time.<br/>
        /// **Use cases:**<br/>
        /// - Capacity/utilization analysis: compare idle vs running over days or weeks<br/>
        ///   to see how much reserved capacity goes unused (use `aggregation=avg`)<br/>
        /// - Incident forensics: correlate error spikes with runner drops or drain<br/>
        ///   events around the incident window (use `aggregation=max`)<br/>
        /// **Time range:** up to 90 days of history. Defaults to the last 24 hours when<br/>
        /// `start`/`end` are omitted. Bucket size is auto-detected from the range<br/>
        /// unless `timeframe` is specified.<br/>
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
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="timeframe">
        /// Bucket size for the time series (auto-detected from the date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
        /// Example: day
        /// </param>
        /// <param name="aggregation">
        /// How runner counts are aggregated within each bucket: 'max' shows peak concurrency (capacity analysis), 'avg' shows mean concurrency (utilization analysis).<br/>
        /// Default Value: max<br/>
        /// Example: max
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Fal.ServerlessGetRunnerHistoryResponse> ServerlessGetRunnerHistoryAsync(
            string owner,
            string name,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.ServerlessGetRunnerHistoryTimeframe? timeframe = default,
            global::Fal.ServerlessGetRunnerHistoryAggregation? aggregation = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ServerlessGetRunnerHistoryAsResponseAsync(
                owner: owner,
                name: name,
                start: start,
                end: end,
                timeframe: timeframe,
                aggregation: aggregation,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Runner State History<br/>
        /// Returns historical runner counts by state (running, idle, pending, draining)<br/>
        /// for an application, bucketed over time.<br/>
        /// **Use cases:**<br/>
        /// - Capacity/utilization analysis: compare idle vs running over days or weeks<br/>
        ///   to see how much reserved capacity goes unused (use `aggregation=avg`)<br/>
        /// - Incident forensics: correlate error spikes with runner drops or drain<br/>
        ///   events around the incident window (use `aggregation=max`)<br/>
        /// **Time range:** up to 90 days of history. Defaults to the last 24 hours when<br/>
        /// `start`/`end` are omitted. Bucket size is auto-detected from the range<br/>
        /// unless `timeframe` is specified.<br/>
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
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="timeframe">
        /// Bucket size for the time series (auto-detected from the date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
        /// Example: day
        /// </param>
        /// <param name="aggregation">
        /// How runner counts are aggregated within each bucket: 'max' shows peak concurrency (capacity analysis), 'avg' shows mean concurrency (utilization analysis).<br/>
        /// Default Value: max<br/>
        /// Example: max
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<global::Fal.ServerlessGetRunnerHistoryResponse>> ServerlessGetRunnerHistoryAsResponseAsync(
            string owner,
            string name,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            global::Fal.ServerlessGetRunnerHistoryTimeframe? timeframe = default,
            global::Fal.ServerlessGetRunnerHistoryAggregation? aggregation = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareServerlessGetRunnerHistoryArguments(
                httpClient: HttpClient,
                owner: ref owner,
                name: ref name,
                start: ref start,
                end: ref end,
                timeframe: ref timeframe,
                aggregation: ref aggregation);


            var __authorizations = global::Fal.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ServerlessGetRunnerHistorySecurityRequirements,
                operationName: "ServerlessGetRunnerHistoryAsync");

            using var __timeoutCancellationTokenSource = global::Fal.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Fal.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Fal.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Fal.PathBuilder(
                                path: $"/serverless/apps/{owner}/{name}/runners/history",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("start", start?.ToString())
                                .AddOptionalParameter("end", end?.ToString())
                                .AddOptionalParameter("timeframe", timeframe?.ToValueString())
                                .AddOptionalParameter("aggregation", aggregation?.ToValueString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Fal.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Fal.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareServerlessGetRunnerHistoryRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    owner: owner!,
                    name: name!,
                    start: start,
                    end: end,
                    timeframe: timeframe,
                    aggregation: aggregation);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Fal.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Fal.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ServerlessGetRunnerHistory",
                                methodName: "ServerlessGetRunnerHistoryAsync",
                                pathTemplate: "$\"/serverless/apps/{owner}/{name}/runners/history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Fal.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Fal.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Fal.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ServerlessGetRunnerHistory",
                                methodName: "ServerlessGetRunnerHistoryAsync",
                                pathTemplate: "$\"/serverless/apps/{owner}/{name}/runners/history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Fal.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Fal.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Fal.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Fal.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Fal.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ServerlessGetRunnerHistory",
                                methodName: "ServerlessGetRunnerHistoryAsync",
                                pathTemplate: "$\"/serverless/apps/{owner}/{name}/runners/history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Fal.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessServerlessGetRunnerHistoryResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Fal.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Fal.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ServerlessGetRunnerHistory",
                                methodName: "ServerlessGetRunnerHistoryAsync",
                                pathTemplate: "$\"/serverless/apps/{owner}/{name}/runners/history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Fal.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Fal.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ServerlessGetRunnerHistory",
                                methodName: "ServerlessGetRunnerHistoryAsync",
                                pathTemplate: "$\"/serverless/apps/{owner}/{name}/runners/history\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Invalid request parameters
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                global::Fal.ServerlessGetRunnerHistoryResponse2? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Fal.ServerlessGetRunnerHistoryResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Fal.ServerlessGetRunnerHistoryResponse2.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.ServerlessGetRunnerHistoryResponse2>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseObject: __value_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Authentication required
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Fal.ServerlessGetRunnerHistoryResponse3? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Fal.ServerlessGetRunnerHistoryResponse3.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Fal.ServerlessGetRunnerHistoryResponse3.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.ServerlessGetRunnerHistoryResponse3>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Access denied
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::Fal.ServerlessGetRunnerHistoryResponse4? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Fal.ServerlessGetRunnerHistoryResponse4.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Fal.ServerlessGetRunnerHistoryResponse4.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.ServerlessGetRunnerHistoryResponse4>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Resource not found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::Fal.ServerlessGetRunnerHistoryResponse5? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Fal.ServerlessGetRunnerHistoryResponse5.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Fal.ServerlessGetRunnerHistoryResponse5.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.ServerlessGetRunnerHistoryResponse5>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Rate limit exceeded
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Fal.ServerlessGetRunnerHistoryResponse6? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Fal.ServerlessGetRunnerHistoryResponse6.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Fal.ServerlessGetRunnerHistoryResponse6.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.ServerlessGetRunnerHistoryResponse6>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Internal server error
                            if ((int)__response.StatusCode == 500)
                            {
                                string? __content_500 = null;
                                global::System.Exception? __exception_500 = null;
                                global::Fal.ServerlessGetRunnerHistoryResponse7? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Fal.ServerlessGetRunnerHistoryResponse7.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Fal.ServerlessGetRunnerHistoryResponse7.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.ServerlessGetRunnerHistoryResponse7>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_500,
                                    responseBody: __content_500,
                                    responseObject: __value_500,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessServerlessGetRunnerHistoryResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Fal.ServerlessGetRunnerHistoryResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Fal.AutoSDKHttpResponse<global::Fal.ServerlessGetRunnerHistoryResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Fal.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Fal.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Fal.ServerlessGetRunnerHistoryResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Fal.AutoSDKHttpResponse<global::Fal.ServerlessGetRunnerHistoryResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Fal.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Fal.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}