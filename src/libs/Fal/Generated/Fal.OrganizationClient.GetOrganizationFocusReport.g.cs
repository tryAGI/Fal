
#nullable enable

namespace Fal
{
    public partial class OrganizationClient
    {


        private static readonly global::Fal.EndPointSecurityRequirement s_GetOrganizationFocusReportSecurityRequirement0 =
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
        private static readonly global::Fal.EndPointSecurityRequirement[] s_GetOrganizationFocusReportSecurityRequirements =
            new global::Fal.EndPointSecurityRequirement[]
            {                s_GetOrganizationFocusReportSecurityRequirement0,
            };
        partial void PrepareGetOrganizationFocusReportArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Fal.GetOrganizationFocusReportSource source,
            ref string? billingMonth,
            ref string? chargeMonth,
            ref string? teamUsername,
            ref global::Fal.AnyOf<global::System.DateTime?, string>? start,
            ref global::Fal.AnyOf<global::System.DateTime?, string>? end,
            ref string? timezone,
            ref global::Fal.GetOrganizationFocusReportTimeframe? timeframe,
            ref global::Fal.GetOrganizationFocusReportBoundToTimeframe? boundToTimeframe);
        partial void PrepareGetOrganizationFocusReportRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Fal.GetOrganizationFocusReportSource source,
            string? billingMonth,
            string? chargeMonth,
            string? teamUsername,
            global::Fal.AnyOf<global::System.DateTime?, string>? start,
            global::Fal.AnyOf<global::System.DateTime?, string>? end,
            string? timezone,
            global::Fal.GetOrganizationFocusReportTimeframe? timeframe,
            global::Fal.GetOrganizationFocusReportBoundToTimeframe? boundToTimeframe);
        partial void ProcessGetOrganizationFocusReportResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetOrganizationFocusReportResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Organization FOCUS Report<br/>
        /// Returns a FOCUS compliant billing report as a CSV download, spanning every team<br/>
        /// in your organization. Each invoiced billing customer is reported as a<br/>
        /// `BillingAccount`. Under shared (pooled) billing — one billing customer covering<br/>
        /// multiple teams — each row is additionally attributed to the calling team via the<br/>
        /// `SubAccountId` / `SubAccountName` columns. `SubAccountId` is that team's own<br/>
        /// billing customer ID, so both account columns share one identifier namespace.<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with FOCUS reports and organizations enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// Must be called with an admin API key on the organization's root team.<br/>
        /// Supports two data sources:<br/>
        /// - **estimate**: Real-time usage estimates for a date range. Under pooled billing every row is attributed to the calling team.<br/>
        /// - **invoice**: Finalized invoice data for a billing month. Under pooled billing, per-team `SubAccount` attribution is available on endpoint (Model API) lines that carry a caller; app and compute lines carry no caller and have no SubAccount.<br/>
        /// Use `team_username` to restrict the report to a single team. Under shared<br/>
        /// (pooled) billing this is rejected for `source=invoice` — the invoice is issued<br/>
        /// to one billing customer shared across teams and cannot be split per team; use<br/>
        /// `source=estimate` for per-team figures.<br/>
        /// **Invoice reports** default to the most recently available billing month.<br/>
        /// **Usage estimates** default to the last 24 hours, with a maximum 90-day lookback.<br/>
        ///     
        /// </summary>
        /// <param name="source">
        /// Report source. 'invoice' returns finalized invoice data for a billing month. 'estimate' returns real-time usage estimates for a date range.<br/>
        /// Example: estimate
        /// </param>
        /// <param name="billingMonth">
        /// Invoice billing month (YYYY-MM). The month the invoice was issued (e.g. '2025-02' for January charges). Used with source=invoice. Defaults to most recent available billing month.<br/>
        /// Example: 2025-02
        /// </param>
        /// <param name="chargeMonth">
        /// Charge month (YYYY-MM) — selects line items by the period charges were incurred, capturing them even when split across invoices issued in different months. Alternative to billing_month. Used with source=invoice.<br/>
        /// Example: 2025-01
        /// </param>
        /// <param name="teamUsername">
        /// Restrict the report to a single team (workspace nickname) in the organization. Omit to report across all teams.<br/>
        /// Example: acme-ml-team
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="timezone">
        /// Timezone for date aggregation and boundaries. All timestamps in responses are in UTC, but this controls how dates are bucketed.<br/>
        /// Default Value: UTC<br/>
        /// Example: UTC
        /// </param>
        /// <param name="timeframe">
        /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
        /// Example: day
        /// </param>
        /// <param name="boundToTimeframe">
        /// Whether to adjust start/end dates to align with timeframe boundaries and use exclusive end. Defaults to true. When true, dates are aligned to the start of the timeframe period (e.g., start of day) and end is made exclusive (e.g., start of next day). When false, uses exact dates provided.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> GetOrganizationFocusReportAsync(
            global::Fal.GetOrganizationFocusReportSource source,
            string? billingMonth = default,
            string? chargeMonth = default,
            string? teamUsername = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::Fal.GetOrganizationFocusReportTimeframe? timeframe = default,
            global::Fal.GetOrganizationFocusReportBoundToTimeframe? boundToTimeframe = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetOrganizationFocusReportAsResponseAsync(
                source: source,
                billingMonth: billingMonth,
                chargeMonth: chargeMonth,
                teamUsername: teamUsername,
                start: start,
                end: end,
                timezone: timezone,
                timeframe: timeframe,
                boundToTimeframe: boundToTimeframe,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Organization FOCUS Report<br/>
        /// Returns a FOCUS compliant billing report as a CSV download, spanning every team<br/>
        /// in your organization. Each invoiced billing customer is reported as a<br/>
        /// `BillingAccount`. Under shared (pooled) billing — one billing customer covering<br/>
        /// multiple teams — each row is additionally attributed to the calling team via the<br/>
        /// `SubAccountId` / `SubAccountName` columns. `SubAccountId` is that team's own<br/>
        /// billing customer ID, so both account columns share one identifier namespace.<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with FOCUS reports and organizations enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// Must be called with an admin API key on the organization's root team.<br/>
        /// Supports two data sources:<br/>
        /// - **estimate**: Real-time usage estimates for a date range. Under pooled billing every row is attributed to the calling team.<br/>
        /// - **invoice**: Finalized invoice data for a billing month. Under pooled billing, per-team `SubAccount` attribution is available on endpoint (Model API) lines that carry a caller; app and compute lines carry no caller and have no SubAccount.<br/>
        /// Use `team_username` to restrict the report to a single team. Under shared<br/>
        /// (pooled) billing this is rejected for `source=invoice` — the invoice is issued<br/>
        /// to one billing customer shared across teams and cannot be split per team; use<br/>
        /// `source=estimate` for per-team figures.<br/>
        /// **Invoice reports** default to the most recently available billing month.<br/>
        /// **Usage estimates** default to the last 24 hours, with a maximum 90-day lookback.<br/>
        ///     
        /// </summary>
        /// <param name="source">
        /// Report source. 'invoice' returns finalized invoice data for a billing month. 'estimate' returns real-time usage estimates for a date range.<br/>
        /// Example: estimate
        /// </param>
        /// <param name="billingMonth">
        /// Invoice billing month (YYYY-MM). The month the invoice was issued (e.g. '2025-02' for January charges). Used with source=invoice. Defaults to most recent available billing month.<br/>
        /// Example: 2025-02
        /// </param>
        /// <param name="chargeMonth">
        /// Charge month (YYYY-MM) — selects line items by the period charges were incurred, capturing them even when split across invoices issued in different months. Alternative to billing_month. Used with source=invoice.<br/>
        /// Example: 2025-01
        /// </param>
        /// <param name="teamUsername">
        /// Restrict the report to a single team (workspace nickname) in the organization. Omit to report across all teams.<br/>
        /// Example: acme-ml-team
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="timezone">
        /// Timezone for date aggregation and boundaries. All timestamps in responses are in UTC, but this controls how dates are bucketed.<br/>
        /// Default Value: UTC<br/>
        /// Example: UTC
        /// </param>
        /// <param name="timeframe">
        /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
        /// Example: day
        /// </param>
        /// <param name="boundToTimeframe">
        /// Whether to adjust start/end dates to align with timeframe boundaries and use exclusive end. Defaults to true. When true, dates are aligned to the start of the timeframe period (e.g., start of day) and end is made exclusive (e.g., start of next day). When false, uses exact dates provided.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Fal.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Fal.AutoSDKHttpResponse<string>> GetOrganizationFocusReportAsResponseAsync(
            global::Fal.GetOrganizationFocusReportSource source,
            string? billingMonth = default,
            string? chargeMonth = default,
            string? teamUsername = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? start = default,
            global::Fal.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::Fal.GetOrganizationFocusReportTimeframe? timeframe = default,
            global::Fal.GetOrganizationFocusReportBoundToTimeframe? boundToTimeframe = default,
            global::Fal.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetOrganizationFocusReportArguments(
                httpClient: HttpClient,
                source: ref source,
                billingMonth: ref billingMonth,
                chargeMonth: ref chargeMonth,
                teamUsername: ref teamUsername,
                start: ref start,
                end: ref end,
                timezone: ref timezone,
                timeframe: ref timeframe,
                boundToTimeframe: ref boundToTimeframe);


            var __authorizations = global::Fal.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetOrganizationFocusReportSecurityRequirements,
                operationName: "GetOrganizationFocusReportAsync");

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
                                path: "/organization/focus",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("source", source.ToValueString())
                                .AddOptionalParameter("billing_month", billingMonth)
                                .AddOptionalParameter("charge_month", chargeMonth)
                                .AddOptionalParameter("team_username", teamUsername)
                                .AddOptionalParameter("start", start?.ToString())
                                .AddOptionalParameter("end", end?.ToString())
                                .AddOptionalParameter("timezone", timezone)
                                .AddOptionalParameter("timeframe", timeframe?.ToValueString())
                                .AddOptionalParameter("bound_to_timeframe", boundToTimeframe?.ToValueString())
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
                PrepareGetOrganizationFocusReportRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    source: source!,
                    billingMonth: billingMonth,
                    chargeMonth: chargeMonth,
                    teamUsername: teamUsername,
                    start: start,
                    end: end,
                    timezone: timezone,
                    timeframe: timeframe,
                    boundToTimeframe: boundToTimeframe);

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
                                operationId: "GetOrganizationFocusReport",
                                methodName: "GetOrganizationFocusReportAsync",
                                pathTemplate: "\"/organization/focus\"",
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
                                operationId: "GetOrganizationFocusReport",
                                methodName: "GetOrganizationFocusReportAsync",
                                pathTemplate: "\"/organization/focus\"",
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
                                operationId: "GetOrganizationFocusReport",
                                methodName: "GetOrganizationFocusReportAsync",
                                pathTemplate: "\"/organization/focus\"",
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
                ProcessGetOrganizationFocusReportResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Fal.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Fal.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetOrganizationFocusReport",
                                methodName: "GetOrganizationFocusReportAsync",
                                pathTemplate: "\"/organization/focus\"",
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
                                operationId: "GetOrganizationFocusReport",
                                methodName: "GetOrganizationFocusReportAsync",
                                pathTemplate: "\"/organization/focus\"",
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
                                global::Fal.GetOrganizationFocusReportResponse? __value_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_400 = global::Fal.GetOrganizationFocusReportResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_400 = global::Fal.GetOrganizationFocusReportResponse.FromJson(__content_400, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.GetOrganizationFocusReportResponse>.Create(
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
                                global::Fal.GetOrganizationFocusReportResponse2? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Fal.GetOrganizationFocusReportResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Fal.GetOrganizationFocusReportResponse2.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.GetOrganizationFocusReportResponse2>.Create(
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
                                global::Fal.GetOrganizationFocusReportResponse3? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Fal.GetOrganizationFocusReportResponse3.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Fal.GetOrganizationFocusReportResponse3.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.GetOrganizationFocusReportResponse3>.Create(
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
                                global::Fal.GetOrganizationFocusReportResponse4? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Fal.GetOrganizationFocusReportResponse4.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Fal.GetOrganizationFocusReportResponse4.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.GetOrganizationFocusReportResponse4>.Create(
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
                                global::Fal.GetOrganizationFocusReportResponse5? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Fal.GetOrganizationFocusReportResponse5.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Fal.GetOrganizationFocusReportResponse5.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.GetOrganizationFocusReportResponse5>.Create(
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
                                global::Fal.GetOrganizationFocusReportResponse6? __value_500 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_500 = global::Fal.GetOrganizationFocusReportResponse6.FromJson(__content_500, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_500 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_500 = global::Fal.GetOrganizationFocusReportResponse6.FromJson(__content_500, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_500 = __ex;
                                }


                                throw global::Fal.ApiException<global::Fal.GetOrganizationFocusReportResponse6>.Create(
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
                                ProcessGetOrganizationFocusReportResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return new global::Fal.AutoSDKHttpResponse<string>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Fal.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
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
                                    var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return new global::Fal.AutoSDKHttpResponse<string>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Fal.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
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