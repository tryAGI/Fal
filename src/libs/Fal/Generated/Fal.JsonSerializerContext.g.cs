
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
            typeof(global::Fal.JsonConverters.EstimatePricingRequestVariant1EstimateTypeJsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingRequestVariant1EstimateTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingRequestVariant2EstimateTypeJsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingRequestVariant2EstimateTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsHistoryRequestItemConditionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsHistoryRequestItemConditionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsStreamRequestItemConditionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsStreamRequestItemConditionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceRequestInstanceTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceRequestInstanceTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceRequestSectorJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceRequestSectorNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsStatusJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsStatusNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageBoundToTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageBoundToTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsBoundToTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsBoundToTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointStatusJsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointStatusNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointSortByJsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointSortByNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsBoundToTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsBoundToTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsHistoryRunSourceJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsHistoryRunSourceNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsStreamRunSourceJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsStreamRunSourceNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointStatusJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointStatusNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointSortByJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointSortByNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportSourceJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportSourceNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportBoundToTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportBoundToTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseModelMetadataStatusJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseModelMetadataStatusNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseModelMetadataLicenseTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseModelMetadataLicenseTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseModelMetadataKindJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseModelMetadataKindNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseModelEnterpriseStatusEnumJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseModelEnterpriseStatusEnumNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetModelsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetPricingResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetPricingResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetPricingResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetPricingResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetPricingResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetPricingResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetPricingResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetPricingResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingResponseEstimateTypeJsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingResponseEstimateTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.EstimatePricingResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetUsageResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAnalyticsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetBillingEventsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetBillingEventsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetBillingEventsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetBillingEventsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetBillingEventsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetBillingEventsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetBillingEventsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetBillingEventsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetBillingEventsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetBillingEventsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListWorkflowsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListWorkflowsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListWorkflowsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListWorkflowsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListWorkflowsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListWorkflowsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListWorkflowsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListWorkflowsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetWorkflowResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRootResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRootResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRootResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRootResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRootResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRootResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseInstanceInstanceTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseInstanceInstanceTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseInstanceRegionJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseInstanceRegionNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseInstanceSectorJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseInstanceSectorNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseInstanceStatusJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseInstanceStatusNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListComputeInstancesResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseInstanceTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseInstanceTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseRegionJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseRegionNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseSectorJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseSectorNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseStatusJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseStatusNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseInstanceTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseInstanceTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseRegionJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseRegionNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseSectorJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseSectorNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseStatusJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseStatusNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetComputeInstanceResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListApiKeysResponseKeyScopeJsonConverter),

            typeof(global::Fal.JsonConverters.ListApiKeysResponseKeyScopeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListApiKeysResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListApiKeysResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListApiKeysResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListApiKeysResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListApiKeysResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListApiKeysResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListApiKeysResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListApiKeysResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateApiKeyResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateApiKeyResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateApiKeyResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateApiKeyResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateApiKeyResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateApiKeyResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateApiKeyResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateApiKeyResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateApiKeyResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateApiKeyResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteApiKeyResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteApiKeyResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteApiKeyResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteApiKeyResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteApiKeyResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteApiKeyResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteApiKeyResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteApiKeyResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAccountBillingResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAccountBillingResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAccountBillingResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAccountBillingResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAccountBillingResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAccountBillingResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAccountBillingResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAccountBillingResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAccountBillingResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAccountBillingResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetFocusReportResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelAccessControlsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelAccessControlsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetMetaResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetMetaResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetMetaResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetMetaResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.OneOfJsonConverter<global::Fal.EstimatePricingRequestVariant1, global::Fal.EstimatePricingRequestVariant2>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>),

            typeof(global::Fal.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.EstimatePricingRequestVariant1, global::Fal.EstimatePricingRequestVariant2>), TypeInfoPropertyName = "OneOfEstimatePricingRequestVariant1EstimatePricingRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant1EstimateType), TypeInfoPropertyName = "EstimatePricingRequestVariant1EstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Fal.EstimatePricingRequestVariant1Endpoints2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant1Endpoints2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant2EstimateType), TypeInfoPropertyName = "EstimatePricingRequestVariant2EstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Fal.EstimatePricingRequestVariant2Endpoints2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant2Endpoints2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessLogsHistoryRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRequestItemConditionType), TypeInfoPropertyName = "ServerlessLogsHistoryRequestItemConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessLogsStreamRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamRequestItemConditionType), TypeInfoPropertyName = "ServerlessLogsStreamRequestItemConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceRequestInstanceType), TypeInfoPropertyName = "CreateComputeInstanceRequestInstanceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceRequestSector), TypeInfoPropertyName = "CreateComputeInstanceRequestSector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsStatus), TypeInfoPropertyName = "GetModelsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>), TypeInfoPropertyName = "AnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageTimeframe), TypeInfoPropertyName = "GetUsageTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageBoundToTimeframe), TypeInfoPropertyName = "GetUsageBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsTimeframe), TypeInfoPropertyName = "GetAnalyticsTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsBoundToTimeframe), TypeInfoPropertyName = "GetAnalyticsBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointStatus), TypeInfoPropertyName = "ListRequestsByEndpointStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointSortBy), TypeInfoPropertyName = "ListRequestsByEndpointSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsTimeframe), TypeInfoPropertyName = "ServerlessGetAnalyticsTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsBoundToTimeframe), TypeInfoPropertyName = "ServerlessGetAnalyticsBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRunSource), TypeInfoPropertyName = "ServerlessLogsHistoryRunSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamRunSource), TypeInfoPropertyName = "ServerlessLogsStreamRunSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointStatus), TypeInfoPropertyName = "ServerlessListRequestsByEndpointStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointSortBy), TypeInfoPropertyName = "ServerlessListRequestsByEndpointSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportSource), TypeInfoPropertyName = "GetFocusReportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportTimeframe), TypeInfoPropertyName = "GetFocusReportTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportBoundToTimeframe), TypeInfoPropertyName = "GetFocusReportBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetModelsResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelMetadataStatus), TypeInfoPropertyName = "GetModelsResponseModelMetadataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelMetadataLicenseType), TypeInfoPropertyName = "GetModelsResponseModelMetadataLicenseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelMetadataGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelMetadataKind), TypeInfoPropertyName = "GetModelsResponseModelMetadataKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>), TypeInfoPropertyName = "AnyOfGetModelsResponseModelOpenapiVariant1GetModelsResponseModelOpenapiVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelOpenapiVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelOpenapiVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelOpenapiVariant2Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>), TypeInfoPropertyName = "AnyOfGetModelsResponseModelEnterpriseStatusEnumGetModelsResponseModelEnterpriseStatusEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelEnterpriseStatusEnum), TypeInfoPropertyName = "GetModelsResponseModelEnterpriseStatusEnum2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelEnterpriseStatusEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelEnterpriseStatusEnumError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseErrorType), TypeInfoPropertyName = "GetModelsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseErrorType2), TypeInfoPropertyName = "GetModelsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseErrorType3), TypeInfoPropertyName = "GetModelsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseErrorType4), TypeInfoPropertyName = "GetModelsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetPricingResponsePrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponsePrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseErrorType), TypeInfoPropertyName = "GetPricingResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseErrorType2), TypeInfoPropertyName = "GetPricingResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseErrorType3), TypeInfoPropertyName = "GetPricingResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseErrorType4), TypeInfoPropertyName = "GetPricingResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseEstimateType), TypeInfoPropertyName = "EstimatePricingResponseEstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseErrorType), TypeInfoPropertyName = "EstimatePricingResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseErrorType2), TypeInfoPropertyName = "EstimatePricingResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseErrorType3), TypeInfoPropertyName = "EstimatePricingResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseErrorType4), TypeInfoPropertyName = "EstimatePricingResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetUsageResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseTimeSerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetUsageResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseTimeSerieResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetUsageResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseErrorType), TypeInfoPropertyName = "GetUsageResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseErrorType2), TypeInfoPropertyName = "GetUsageResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseErrorType3), TypeInfoPropertyName = "GetUsageResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseErrorType4), TypeInfoPropertyName = "GetUsageResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseErrorType5), TypeInfoPropertyName = "GetUsageResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAnalyticsResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseTimeSerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAnalyticsResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseTimeSerieResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAnalyticsResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType), TypeInfoPropertyName = "GetAnalyticsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType2), TypeInfoPropertyName = "GetAnalyticsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType3), TypeInfoPropertyName = "GetAnalyticsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType4), TypeInfoPropertyName = "GetAnalyticsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType5), TypeInfoPropertyName = "GetAnalyticsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType6), TypeInfoPropertyName = "GetAnalyticsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetBillingEventsResponseBillingEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseBillingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType), TypeInfoPropertyName = "GetBillingEventsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType2), TypeInfoPropertyName = "GetBillingEventsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType3), TypeInfoPropertyName = "GetBillingEventsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType4), TypeInfoPropertyName = "GetBillingEventsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType5), TypeInfoPropertyName = "GetBillingEventsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.DeleteRequestPayloadsResponseCdnDeleteResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseCdnDeleteResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType), TypeInfoPropertyName = "DeleteRequestPayloadsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType2), TypeInfoPropertyName = "DeleteRequestPayloadsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType3), TypeInfoPropertyName = "DeleteRequestPayloadsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType4), TypeInfoPropertyName = "DeleteRequestPayloadsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType5), TypeInfoPropertyName = "DeleteRequestPayloadsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType6), TypeInfoPropertyName = "DeleteRequestPayloadsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListRequestsByEndpointResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType), TypeInfoPropertyName = "ListRequestsByEndpointResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType2), TypeInfoPropertyName = "ListRequestsByEndpointResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType3), TypeInfoPropertyName = "ListRequestsByEndpointResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType4), TypeInfoPropertyName = "ListRequestsByEndpointResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType5), TypeInfoPropertyName = "ListRequestsByEndpointResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.SearchRequestsResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType), TypeInfoPropertyName = "SearchRequestsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType2), TypeInfoPropertyName = "SearchRequestsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType3), TypeInfoPropertyName = "SearchRequestsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType4), TypeInfoPropertyName = "SearchRequestsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListWorkflowsResponseWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseErrorType), TypeInfoPropertyName = "ListWorkflowsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseErrorType2), TypeInfoPropertyName = "ListWorkflowsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseErrorType3), TypeInfoPropertyName = "ListWorkflowsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseErrorType4), TypeInfoPropertyName = "ListWorkflowsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType), TypeInfoPropertyName = "GetWorkflowResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType2), TypeInfoPropertyName = "GetWorkflowResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType3), TypeInfoPropertyName = "GetWorkflowResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType4), TypeInfoPropertyName = "GetWorkflowResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType5), TypeInfoPropertyName = "GetWorkflowResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType6), TypeInfoPropertyName = "GetWorkflowResponseErrorType62")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType), TypeInfoPropertyName = "ServerlessUploadFromUrlResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType2), TypeInfoPropertyName = "ServerlessUploadFromUrlResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlResponseErrorType3), TypeInfoPropertyName = "ServerlessUploadFromUrlResponseErrorType32")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListComputeInstancesResponseInstance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceInstanceType), TypeInfoPropertyName = "ListComputeInstancesResponseInstanceInstanceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceRegion), TypeInfoPropertyName = "ListComputeInstancesResponseInstanceRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceSector), TypeInfoPropertyName = "ListComputeInstancesResponseInstanceSector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceStatus), TypeInfoPropertyName = "ListComputeInstancesResponseInstanceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType), TypeInfoPropertyName = "ListComputeInstancesResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType2), TypeInfoPropertyName = "ListComputeInstancesResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType3), TypeInfoPropertyName = "ListComputeInstancesResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType4), TypeInfoPropertyName = "ListComputeInstancesResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseInstanceType), TypeInfoPropertyName = "CreateComputeInstanceResponseInstanceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseRegion), TypeInfoPropertyName = "CreateComputeInstanceResponseRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseSector), TypeInfoPropertyName = "CreateComputeInstanceResponseSector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseStatus), TypeInfoPropertyName = "CreateComputeInstanceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseErrorType), TypeInfoPropertyName = "CreateComputeInstanceResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseErrorType2), TypeInfoPropertyName = "CreateComputeInstanceResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseErrorType3), TypeInfoPropertyName = "CreateComputeInstanceResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseErrorType4), TypeInfoPropertyName = "CreateComputeInstanceResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseErrorType5), TypeInfoPropertyName = "CreateComputeInstanceResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseInstanceType), TypeInfoPropertyName = "GetComputeInstanceResponseInstanceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseRegion), TypeInfoPropertyName = "GetComputeInstanceResponseRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseSector), TypeInfoPropertyName = "GetComputeInstanceResponseSector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseStatus), TypeInfoPropertyName = "GetComputeInstanceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseErrorType), TypeInfoPropertyName = "GetComputeInstanceResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseErrorType2), TypeInfoPropertyName = "GetComputeInstanceResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseErrorType3), TypeInfoPropertyName = "GetComputeInstanceResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseErrorType4), TypeInfoPropertyName = "GetComputeInstanceResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseErrorType5), TypeInfoPropertyName = "GetComputeInstanceResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseErrorType), TypeInfoPropertyName = "DeleteComputeInstanceResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseErrorType2), TypeInfoPropertyName = "DeleteComputeInstanceResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseErrorType3), TypeInfoPropertyName = "DeleteComputeInstanceResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseErrorType4), TypeInfoPropertyName = "DeleteComputeInstanceResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseErrorType5), TypeInfoPropertyName = "DeleteComputeInstanceResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListApiKeysResponseKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseKeyScope), TypeInfoPropertyName = "ListApiKeysResponseKeyScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseErrorType), TypeInfoPropertyName = "ListApiKeysResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseErrorType2), TypeInfoPropertyName = "ListApiKeysResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseErrorType3), TypeInfoPropertyName = "ListApiKeysResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseErrorType4), TypeInfoPropertyName = "ListApiKeysResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseErrorType), TypeInfoPropertyName = "CreateApiKeyResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseErrorType2), TypeInfoPropertyName = "CreateApiKeyResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseErrorType3), TypeInfoPropertyName = "CreateApiKeyResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseErrorType4), TypeInfoPropertyName = "CreateApiKeyResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseErrorType5), TypeInfoPropertyName = "CreateApiKeyResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseErrorType), TypeInfoPropertyName = "DeleteApiKeyResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseErrorType2), TypeInfoPropertyName = "DeleteApiKeyResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseErrorType3), TypeInfoPropertyName = "DeleteApiKeyResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseErrorType4), TypeInfoPropertyName = "DeleteApiKeyResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseCredits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseErrorType), TypeInfoPropertyName = "GetAccountBillingResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseErrorType2), TypeInfoPropertyName = "GetAccountBillingResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseErrorType3), TypeInfoPropertyName = "GetAccountBillingResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseErrorType4), TypeInfoPropertyName = "GetAccountBillingResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseErrorType5), TypeInfoPropertyName = "GetAccountBillingResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseErrorType), TypeInfoPropertyName = "GetFocusReportResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseErrorType2), TypeInfoPropertyName = "GetFocusReportResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseErrorType3), TypeInfoPropertyName = "GetFocusReportResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseErrorType4), TypeInfoPropertyName = "GetFocusReportResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseErrorType5), TypeInfoPropertyName = "GetFocusReportResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseErrorType), TypeInfoPropertyName = "GetModelAccessControlsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseErrorType2), TypeInfoPropertyName = "GetModelAccessControlsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseErrorType3), TypeInfoPropertyName = "GetModelAccessControlsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseErrorType4), TypeInfoPropertyName = "GetModelAccessControlsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponseErrorType), TypeInfoPropertyName = "GetMetaResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponseErrorType2), TypeInfoPropertyName = "GetMetaResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessLogsHistoryRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessLogsStreamRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetModelsResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetPricingResponsePrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetUsageResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetUsageResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetUsageResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAnalyticsResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAnalyticsResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAnalyticsResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetBillingEventsResponseBillingEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.DeleteRequestPayloadsResponseCdnDeleteResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListRequestsByEndpointResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.SearchRequestsResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListWorkflowsResponseWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetAnalyticsResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetAnalyticsResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetAnalyticsResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListRootResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListDirectoryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessLogsHistoryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListRequestsByEndpointResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListComputeInstancesResponseInstance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListApiKeysResponseKey>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}