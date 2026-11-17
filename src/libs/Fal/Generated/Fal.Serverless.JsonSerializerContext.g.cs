
#nullable enable

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessLogsHistoryRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRequestItemConditionType), TypeInfoPropertyName = "ServerlessLogsHistoryRequestItemConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessLogsStreamRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamRequestItemConditionType), TypeInfoPropertyName = "ServerlessLogsStreamRequestItemConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>), TypeInfoPropertyName = "AnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsTimeframe), TypeInfoPropertyName = "ServerlessGetAnalyticsTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsBoundToTimeframe), TypeInfoPropertyName = "ServerlessGetAnalyticsBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryTimeframe), TypeInfoPropertyName = "ServerlessGetRunnerHistoryTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryAggregation), TypeInfoPropertyName = "ServerlessGetRunnerHistoryAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.ServerlessListAppEventsCategory2?, global::System.Collections.Generic.IList<global::Fal.ServerlessListAppEventsCategoryItem>>), TypeInfoPropertyName = "AnyOfServerlessListAppEventsCategory2IListServerlessListAppEventsCategoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsCategory2), TypeInfoPropertyName = "ServerlessListAppEventsCategory22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListAppEventsCategoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsCategoryItem), TypeInfoPropertyName = "ServerlessListAppEventsCategoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRunSource), TypeInfoPropertyName = "ServerlessLogsHistoryRunSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamRunSource), TypeInfoPropertyName = "ServerlessLogsStreamRunSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointStatus), TypeInfoPropertyName = "ServerlessListRequestsByEndpointStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointSortBy), TypeInfoPropertyName = "ServerlessListRequestsByEndpointSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerReplaceFirst), TypeInfoPropertyName = "ServerlessStopRunnerReplaceFirst2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageTimeframe), TypeInfoPropertyName = "ServerlessGetUsageTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageBoundToTimeframe), TypeInfoPropertyName = "ServerlessGetUsageBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessGetAnalyticsResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseTimeSerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessGetAnalyticsResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseTimeSerieResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessGetAnalyticsResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType), TypeInfoPropertyName = "ServerlessGetAnalyticsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListAppsResponseApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseAppAuthMode), TypeInfoPropertyName = "ServerlessListAppsResponseAppAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType), TypeInfoPropertyName = "ServerlessListAppsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType), TypeInfoPropertyName = "ServerlessGetAppQueueInfoResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType), TypeInfoPropertyName = "ServerlessFlushAppQueueResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseTimeframe), TypeInfoPropertyName = "ServerlessGetRunnerHistoryResponseTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseAggregation), TypeInfoPropertyName = "ServerlessGetRunnerHistoryResponseAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessGetRunnerHistoryResponseHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType), TypeInfoPropertyName = "ServerlessGetRunnerHistoryResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListAppEventsResponseEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseEventCategory), TypeInfoPropertyName = "ServerlessListAppEventsResponseEventCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseEventPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseEventPayloadActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType), TypeInfoPropertyName = "ServerlessListAppEventsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListAppRevisionsResponseRevision>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseRevision))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseRevisionStatus), TypeInfoPropertyName = "ServerlessListAppRevisionsResponseRevisionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType), TypeInfoPropertyName = "ServerlessListAppRevisionsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListRootResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseErrorType), TypeInfoPropertyName = "ServerlessListRootResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListDirectoryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseErrorType), TypeInfoPropertyName = "ServerlessListDirectoryResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType), TypeInfoPropertyName = "ServerlessDownloadFileResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType), TypeInfoPropertyName = "ServerlessUploadFromUrlResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType), TypeInfoPropertyName = "ServerlessUploadLocalFileResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseErrorType), TypeInfoPropertyName = "ServerlessGetMetricsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessLogsHistoryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseErrorType), TypeInfoPropertyName = "ServerlessLogsHistoryResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseErrorType), TypeInfoPropertyName = "ServerlessLogsStreamResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListRequestsByEndpointResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType), TypeInfoPropertyName = "ServerlessListRequestsByEndpointResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerResponseErrorType), TypeInfoPropertyName = "ServerlessStopRunnerResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessGetUsageResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseTimeSerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessGetUsageResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseTimeSerieResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessGetUsageResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType), TypeInfoPropertyName = "ServerlessGetUsageResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRequestItemConditionType?), TypeInfoPropertyName = "NullableServerlessLogsHistoryRequestItemConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamRequestItemConditionType?), TypeInfoPropertyName = "NullableServerlessLogsStreamRequestItemConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>?), TypeInfoPropertyName = "NullableAnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsTimeframe?), TypeInfoPropertyName = "NullableServerlessGetAnalyticsTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsBoundToTimeframe?), TypeInfoPropertyName = "NullableServerlessGetAnalyticsBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryTimeframe?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryAggregation?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.ServerlessListAppEventsCategory2?, global::System.Collections.Generic.IList<global::Fal.ServerlessListAppEventsCategoryItem>>?), TypeInfoPropertyName = "NullableAnyOfServerlessListAppEventsCategory2IListServerlessListAppEventsCategoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsCategory2?), TypeInfoPropertyName = "NullableServerlessListAppEventsCategory22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsCategoryItem?), TypeInfoPropertyName = "NullableServerlessListAppEventsCategoryItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRunSource?), TypeInfoPropertyName = "NullableServerlessLogsHistoryRunSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamRunSource?), TypeInfoPropertyName = "NullableServerlessLogsStreamRunSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointStatus?), TypeInfoPropertyName = "NullableServerlessListRequestsByEndpointStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointSortBy?), TypeInfoPropertyName = "NullableServerlessListRequestsByEndpointSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerReplaceFirst?), TypeInfoPropertyName = "NullableServerlessStopRunnerReplaceFirst2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageTimeframe?), TypeInfoPropertyName = "NullableServerlessGetUsageTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageBoundToTimeframe?), TypeInfoPropertyName = "NullableServerlessGetUsageBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType?), TypeInfoPropertyName = "NullableServerlessGetAnalyticsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseAppAuthMode?), TypeInfoPropertyName = "NullableServerlessListAppsResponseAppAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListAppsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType?), TypeInfoPropertyName = "NullableServerlessGetAppQueueInfoResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType?), TypeInfoPropertyName = "NullableServerlessFlushAppQueueResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseTimeframe?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryResponseTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseAggregation?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryResponseAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseEventCategory?), TypeInfoPropertyName = "NullableServerlessListAppEventsResponseEventCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListAppEventsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseRevisionStatus?), TypeInfoPropertyName = "NullableServerlessListAppRevisionsResponseRevisionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListAppRevisionsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListRootResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListDirectoryResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType?), TypeInfoPropertyName = "NullableServerlessDownloadFileResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType?), TypeInfoPropertyName = "NullableServerlessUploadFromUrlResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType?), TypeInfoPropertyName = "NullableServerlessUploadLocalFileResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseErrorType?), TypeInfoPropertyName = "NullableServerlessGetMetricsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseErrorType?), TypeInfoPropertyName = "NullableServerlessLogsHistoryResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseErrorType?), TypeInfoPropertyName = "NullableServerlessLogsStreamResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListRequestsByEndpointResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessStopRunnerResponseErrorType?), TypeInfoPropertyName = "NullableServerlessStopRunnerResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType?), TypeInfoPropertyName = "NullableServerlessGetUsageResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessLogsHistoryRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessLogsStreamRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.ServerlessListAppEventsCategory2?, global::System.Collections.Generic.List<global::Fal.ServerlessListAppEventsCategoryItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListAppEventsCategoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetAnalyticsResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetAnalyticsResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetAnalyticsResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListAppsResponseApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetRunnerHistoryResponseHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListAppEventsResponseEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListAppRevisionsResponseRevision>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListRootResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListDirectoryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessLogsHistoryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListRequestsByEndpointResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetUsageResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetUsageResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetUsageResponseSummaryItem>))]
    internal sealed partial class ServerlessSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServerlessSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ServerlessSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ServerlessSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.ServerlessListAppEventsCategory2?, global::System.Collections.Generic.IList<global::Fal.ServerlessListAppEventsCategoryItem>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Fal.ServerlessLogsHistoryRequestItemConditionType)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryRequestItemConditionType?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamRequestItemConditionType)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamRequestItemConditionType?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsTimeframe)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsTimeframe?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsBoundToTimeframe?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryTimeframe)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryTimeframe?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryAggregation)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryAggregation?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsCategory2)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsCategory2?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsCategoryItem)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsCategoryItem?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryRunSource)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryRunSource?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamRunSource)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamRunSource?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointStatus)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointStatus?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointSortBy)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointSortBy?)

                    || typeToConvert == typeof(global::Fal.ServerlessStopRunnerReplaceFirst)

                    || typeToConvert == typeof(global::Fal.ServerlessStopRunnerReplaceFirst?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageTimeframe)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageTimeframe?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageBoundToTimeframe?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseAppAuthMode)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseAppAuthMode?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseTimeframe)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseTimeframe?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseAggregation)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseAggregation?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseEventCategory)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseEventCategory?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseRevisionStatus)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseRevisionStatus?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessStopRunnerResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessStopRunnerResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryRequestItemConditionType))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryRequestItemConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryRequestItemConditionType?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryRequestItemConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamRequestItemConditionType))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamRequestItemConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamRequestItemConditionType?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamRequestItemConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsTimeframe))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsTimeframe?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsBoundToTimeframe))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsBoundToTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsBoundToTimeframe?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsBoundToTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryTimeframe))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryTimeframe?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryAggregation))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryAggregationJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryAggregation?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryAggregationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsCategory2))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsCategory2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsCategory2?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsCategory2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsCategoryItem))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsCategoryItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsCategoryItem?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsCategoryItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryRunSource))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryRunSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryRunSource?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryRunSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamRunSource))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamRunSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamRunSource?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamRunSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointStatus))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointStatus?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointSortBy))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointSortBy?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessStopRunnerReplaceFirst))
                {
                    return new global::Fal.JsonConverters.ServerlessStopRunnerReplaceFirstJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessStopRunnerReplaceFirst?))
                {
                    return new global::Fal.JsonConverters.ServerlessStopRunnerReplaceFirstNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageTimeframe))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageTimeframe?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageBoundToTimeframe))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageBoundToTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageBoundToTimeframe?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageBoundToTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseAppAuthMode))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseAppAuthModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseAppAuthMode?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseAppAuthModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseTimeframe))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseTimeframe?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseAggregation))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseAggregationJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseAggregation?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseAggregationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseEventCategory))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseEventCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseEventCategory?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseEventCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseRevisionStatus))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseRevisionStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseRevisionStatus?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseRevisionStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessListRootResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRootResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessStopRunnerResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessStopRunnerResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessStopRunnerResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessStopRunnerResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ServerlessSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}