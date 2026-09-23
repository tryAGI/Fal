
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>), TypeInfoPropertyName = "AnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType), TypeInfoPropertyName = "ServerlessGetAnalyticsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType2), TypeInfoPropertyName = "ServerlessGetAnalyticsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType3), TypeInfoPropertyName = "ServerlessGetAnalyticsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType4), TypeInfoPropertyName = "ServerlessGetAnalyticsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType5), TypeInfoPropertyName = "ServerlessGetAnalyticsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType6), TypeInfoPropertyName = "ServerlessGetAnalyticsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListAppsResponseApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseAppAuthMode), TypeInfoPropertyName = "ServerlessListAppsResponseAppAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType), TypeInfoPropertyName = "ServerlessListAppsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType2), TypeInfoPropertyName = "ServerlessListAppsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType3), TypeInfoPropertyName = "ServerlessListAppsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType4), TypeInfoPropertyName = "ServerlessListAppsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType5), TypeInfoPropertyName = "ServerlessListAppsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType), TypeInfoPropertyName = "ServerlessGetAppQueueInfoResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType2), TypeInfoPropertyName = "ServerlessGetAppQueueInfoResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType3), TypeInfoPropertyName = "ServerlessGetAppQueueInfoResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType4), TypeInfoPropertyName = "ServerlessGetAppQueueInfoResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType5), TypeInfoPropertyName = "ServerlessGetAppQueueInfoResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType), TypeInfoPropertyName = "ServerlessFlushAppQueueResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType2), TypeInfoPropertyName = "ServerlessFlushAppQueueResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType3), TypeInfoPropertyName = "ServerlessFlushAppQueueResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType4), TypeInfoPropertyName = "ServerlessFlushAppQueueResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType5), TypeInfoPropertyName = "ServerlessFlushAppQueueResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType6), TypeInfoPropertyName = "ServerlessFlushAppQueueResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseTimeframe), TypeInfoPropertyName = "ServerlessGetRunnerHistoryResponseTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseAggregation), TypeInfoPropertyName = "ServerlessGetRunnerHistoryResponseAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessGetRunnerHistoryResponseHistoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType), TypeInfoPropertyName = "ServerlessGetRunnerHistoryResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType2), TypeInfoPropertyName = "ServerlessGetRunnerHistoryResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType3), TypeInfoPropertyName = "ServerlessGetRunnerHistoryResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType4), TypeInfoPropertyName = "ServerlessGetRunnerHistoryResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType5), TypeInfoPropertyName = "ServerlessGetRunnerHistoryResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType6), TypeInfoPropertyName = "ServerlessGetRunnerHistoryResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListAppEventsResponseEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseEventCategory), TypeInfoPropertyName = "ServerlessListAppEventsResponseEventCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseEventPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseEventPayloadActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType), TypeInfoPropertyName = "ServerlessListAppEventsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType2), TypeInfoPropertyName = "ServerlessListAppEventsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType3), TypeInfoPropertyName = "ServerlessListAppEventsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType4), TypeInfoPropertyName = "ServerlessListAppEventsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType5), TypeInfoPropertyName = "ServerlessListAppEventsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType6), TypeInfoPropertyName = "ServerlessListAppEventsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListAppRevisionsResponseRevision>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseRevision))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseRevisionStatus), TypeInfoPropertyName = "ServerlessListAppRevisionsResponseRevisionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType), TypeInfoPropertyName = "ServerlessListAppRevisionsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType2), TypeInfoPropertyName = "ServerlessListAppRevisionsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType3), TypeInfoPropertyName = "ServerlessListAppRevisionsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType4), TypeInfoPropertyName = "ServerlessListAppRevisionsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType5), TypeInfoPropertyName = "ServerlessListAppRevisionsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType6), TypeInfoPropertyName = "ServerlessListAppRevisionsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListRootResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseErrorType), TypeInfoPropertyName = "ServerlessListRootResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseErrorType2), TypeInfoPropertyName = "ServerlessListRootResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseErrorType3), TypeInfoPropertyName = "ServerlessListRootResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListDirectoryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseErrorType), TypeInfoPropertyName = "ServerlessListDirectoryResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseErrorType2), TypeInfoPropertyName = "ServerlessListDirectoryResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseErrorType3), TypeInfoPropertyName = "ServerlessListDirectoryResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseErrorType4), TypeInfoPropertyName = "ServerlessListDirectoryResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType), TypeInfoPropertyName = "ServerlessDownloadFileResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType2), TypeInfoPropertyName = "ServerlessDownloadFileResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType3), TypeInfoPropertyName = "ServerlessDownloadFileResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType4), TypeInfoPropertyName = "ServerlessDownloadFileResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType5), TypeInfoPropertyName = "ServerlessDownloadFileResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType), TypeInfoPropertyName = "ServerlessUploadFromUrlResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType2), TypeInfoPropertyName = "ServerlessUploadFromUrlResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType3), TypeInfoPropertyName = "ServerlessUploadFromUrlResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType4), TypeInfoPropertyName = "ServerlessUploadFromUrlResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType), TypeInfoPropertyName = "ServerlessUploadLocalFileResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType2), TypeInfoPropertyName = "ServerlessUploadLocalFileResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType3), TypeInfoPropertyName = "ServerlessUploadLocalFileResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType4), TypeInfoPropertyName = "ServerlessUploadLocalFileResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseErrorType), TypeInfoPropertyName = "ServerlessGetMetricsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseErrorType2), TypeInfoPropertyName = "ServerlessGetMetricsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseErrorType3), TypeInfoPropertyName = "ServerlessGetMetricsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessLogsHistoryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseErrorType), TypeInfoPropertyName = "ServerlessLogsHistoryResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseErrorType2), TypeInfoPropertyName = "ServerlessLogsHistoryResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseErrorType3), TypeInfoPropertyName = "ServerlessLogsHistoryResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseErrorType), TypeInfoPropertyName = "ServerlessLogsStreamResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseErrorType2), TypeInfoPropertyName = "ServerlessLogsStreamResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseErrorType3), TypeInfoPropertyName = "ServerlessLogsStreamResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessListRequestsByEndpointResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType), TypeInfoPropertyName = "ServerlessListRequestsByEndpointResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType2), TypeInfoPropertyName = "ServerlessListRequestsByEndpointResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType3), TypeInfoPropertyName = "ServerlessListRequestsByEndpointResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType4), TypeInfoPropertyName = "ServerlessListRequestsByEndpointResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType5), TypeInfoPropertyName = "ServerlessListRequestsByEndpointResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType6), TypeInfoPropertyName = "ServerlessListRequestsByEndpointResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessGetUsageResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseTimeSerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessGetUsageResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseTimeSerieResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessGetUsageResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType), TypeInfoPropertyName = "ServerlessGetUsageResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType2), TypeInfoPropertyName = "ServerlessGetUsageResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType3), TypeInfoPropertyName = "ServerlessGetUsageResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType4), TypeInfoPropertyName = "ServerlessGetUsageResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType5), TypeInfoPropertyName = "ServerlessGetUsageResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType6), TypeInfoPropertyName = "ServerlessGetUsageResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRequestItemConditionType?), TypeInfoPropertyName = "NullableServerlessLogsHistoryRequestItemConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamRequestItemConditionType?), TypeInfoPropertyName = "NullableServerlessLogsStreamRequestItemConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>?), TypeInfoPropertyName = "NullableAnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageTimeframe?), TypeInfoPropertyName = "NullableServerlessGetUsageTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageBoundToTimeframe?), TypeInfoPropertyName = "NullableServerlessGetUsageBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType?), TypeInfoPropertyName = "NullableServerlessGetAnalyticsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessGetAnalyticsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessGetAnalyticsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessGetAnalyticsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType5?), TypeInfoPropertyName = "NullableServerlessGetAnalyticsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType6?), TypeInfoPropertyName = "NullableServerlessGetAnalyticsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseAppAuthMode?), TypeInfoPropertyName = "NullableServerlessListAppsResponseAppAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListAppsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessListAppsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessListAppsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessListAppsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppsResponseErrorType5?), TypeInfoPropertyName = "NullableServerlessListAppsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType?), TypeInfoPropertyName = "NullableServerlessGetAppQueueInfoResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessGetAppQueueInfoResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessGetAppQueueInfoResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessGetAppQueueInfoResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType5?), TypeInfoPropertyName = "NullableServerlessGetAppQueueInfoResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType?), TypeInfoPropertyName = "NullableServerlessFlushAppQueueResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessFlushAppQueueResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessFlushAppQueueResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessFlushAppQueueResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType5?), TypeInfoPropertyName = "NullableServerlessFlushAppQueueResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType6?), TypeInfoPropertyName = "NullableServerlessFlushAppQueueResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseTimeframe?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryResponseTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseAggregation?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryResponseAggregation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType5?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType6?), TypeInfoPropertyName = "NullableServerlessGetRunnerHistoryResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseEventCategory?), TypeInfoPropertyName = "NullableServerlessListAppEventsResponseEventCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListAppEventsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessListAppEventsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessListAppEventsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessListAppEventsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType5?), TypeInfoPropertyName = "NullableServerlessListAppEventsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppEventsResponseErrorType6?), TypeInfoPropertyName = "NullableServerlessListAppEventsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseRevisionStatus?), TypeInfoPropertyName = "NullableServerlessListAppRevisionsResponseRevisionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListAppRevisionsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessListAppRevisionsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessListAppRevisionsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessListAppRevisionsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType5?), TypeInfoPropertyName = "NullableServerlessListAppRevisionsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType6?), TypeInfoPropertyName = "NullableServerlessListAppRevisionsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListRootResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessListRootResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRootResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessListRootResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListDirectoryResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessListDirectoryResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessListDirectoryResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListDirectoryResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessListDirectoryResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType?), TypeInfoPropertyName = "NullableServerlessDownloadFileResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessDownloadFileResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessDownloadFileResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessDownloadFileResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessDownloadFileResponseErrorType5?), TypeInfoPropertyName = "NullableServerlessDownloadFileResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType?), TypeInfoPropertyName = "NullableServerlessUploadFromUrlResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessUploadFromUrlResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessUploadFromUrlResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessUploadFromUrlResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType?), TypeInfoPropertyName = "NullableServerlessUploadLocalFileResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessUploadLocalFileResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessUploadLocalFileResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessUploadLocalFileResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseErrorType?), TypeInfoPropertyName = "NullableServerlessGetMetricsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessGetMetricsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetMetricsResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessGetMetricsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseErrorType?), TypeInfoPropertyName = "NullableServerlessLogsHistoryResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessLogsHistoryResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessLogsHistoryResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseErrorType?), TypeInfoPropertyName = "NullableServerlessLogsStreamResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessLogsStreamResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessLogsStreamResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType?), TypeInfoPropertyName = "NullableServerlessListRequestsByEndpointResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessListRequestsByEndpointResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessListRequestsByEndpointResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessListRequestsByEndpointResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType5?), TypeInfoPropertyName = "NullableServerlessListRequestsByEndpointResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType6?), TypeInfoPropertyName = "NullableServerlessListRequestsByEndpointResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType?), TypeInfoPropertyName = "NullableServerlessGetUsageResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType2?), TypeInfoPropertyName = "NullableServerlessGetUsageResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType3?), TypeInfoPropertyName = "NullableServerlessGetUsageResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType4?), TypeInfoPropertyName = "NullableServerlessGetUsageResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType5?), TypeInfoPropertyName = "NullableServerlessGetUsageResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetUsageResponseErrorType6?), TypeInfoPropertyName = "NullableServerlessGetUsageResponseErrorType62")]
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

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageTimeframe)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageTimeframe?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageBoundToTimeframe?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseAppAuthMode)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseAppAuthMode?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseTimeframe)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseTimeframe?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseAggregation)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseAggregation?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseEventCategory)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseEventCategory?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseRevisionStatus)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseRevisionStatus?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType6?);
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

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAnalyticsResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType6NullableJsonConverter();
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

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetAppQueueInfoResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessFlushAppQueueResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType6NullableJsonConverter();
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

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetRunnerHistoryResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetRunnerHistoryResponseErrorType6NullableJsonConverter();
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

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppEventsResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppEventsResponseErrorType6NullableJsonConverter();
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

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListAppRevisionsResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ServerlessListAppRevisionsResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessListRootResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRootResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessListRootResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRootResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessListRootResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRootResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRootResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListDirectoryResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessDownloadFileResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessUploadLocalFileResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetMetricsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsHistoryResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessLogsStreamResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessListRequestsByEndpointResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ServerlessGetUsageResponseErrorType6NullableJsonConverter();
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