
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

            typeof(global::Fal.JsonConverters.UploadAssetRequestTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetRequestTypeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListAssetsMediaTypeItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsMediaTypeItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSourceItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSourceItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSectionJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSectionNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsTagModeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsTagModeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSectionJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSectionNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.GetOrganizationUsageTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType5NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListAssetsResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

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

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetRequestType), TypeInfoPropertyName = "UploadAssetRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadFromUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessUploadLocalFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ServerlessLogsHistoryRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRequestItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetsMediaTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsMediaTypeItem), TypeInfoPropertyName = "ListAssetsMediaTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetsSourceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsSourceItem), TypeInfoPropertyName = "ListAssetsSourceItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsSection), TypeInfoPropertyName = "ListAssetsSection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsTagMode), TypeInfoPropertyName = "ListAssetsTagMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetCollectionAssetsMediaTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsMediaTypeItem), TypeInfoPropertyName = "ListAssetCollectionAssetsMediaTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetCollectionAssetsSourceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsSourceItem), TypeInfoPropertyName = "ListAssetCollectionAssetsSourceItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsSection), TypeInfoPropertyName = "ListAssetCollectionAssetsSection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsTagMode), TypeInfoPropertyName = "ListAssetCollectionAssetsTagMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsTimeframe), TypeInfoPropertyName = "ServerlessGetAnalyticsTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessGetAnalyticsBoundToTimeframe), TypeInfoPropertyName = "ServerlessGetAnalyticsBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRunSource), TypeInfoPropertyName = "ServerlessLogsHistoryRunSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamRunSource), TypeInfoPropertyName = "ServerlessLogsStreamRunSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointStatus), TypeInfoPropertyName = "ServerlessListRequestsByEndpointStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessListRequestsByEndpointSortBy), TypeInfoPropertyName = "ServerlessListRequestsByEndpointSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportSource), TypeInfoPropertyName = "GetFocusReportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportTimeframe), TypeInfoPropertyName = "GetFocusReportTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportBoundToTimeframe), TypeInfoPropertyName = "GetFocusReportBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageTimeframe), TypeInfoPropertyName = "GetOrganizationUsageTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageBoundToTimeframe), TypeInfoPropertyName = "GetOrganizationUsageBoundToTimeframe2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType6), TypeInfoPropertyName = "ListRequestsByEndpointResponseErrorType62")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType5), TypeInfoPropertyName = "SearchRequestsResponseErrorType52")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetsResponseAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseAssetType), TypeInfoPropertyName = "ListAssetsResponseAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetsResponseAssetTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseAssetTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType), TypeInfoPropertyName = "ListAssetsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType2), TypeInfoPropertyName = "ListAssetsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType3), TypeInfoPropertyName = "ListAssetsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType4), TypeInfoPropertyName = "ListAssetsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType5), TypeInfoPropertyName = "ListAssetsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType6), TypeInfoPropertyName = "ListAssetsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType7), TypeInfoPropertyName = "ListAssetsResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType8), TypeInfoPropertyName = "ListAssetsResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType9), TypeInfoPropertyName = "ListAssetsResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetCollectionsResponseCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseCollectionType), TypeInfoPropertyName = "ListAssetCollectionsResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType), TypeInfoPropertyName = "ListAssetCollectionsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType2), TypeInfoPropertyName = "ListAssetCollectionsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType3), TypeInfoPropertyName = "ListAssetCollectionsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType4), TypeInfoPropertyName = "ListAssetCollectionsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType5), TypeInfoPropertyName = "ListAssetCollectionsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType6), TypeInfoPropertyName = "ListAssetCollectionsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType7), TypeInfoPropertyName = "ListAssetCollectionsResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType8), TypeInfoPropertyName = "ListAssetCollectionsResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType9), TypeInfoPropertyName = "ListAssetCollectionsResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseCollectionType), TypeInfoPropertyName = "CreateAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType), TypeInfoPropertyName = "CreateAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType2), TypeInfoPropertyName = "CreateAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType3), TypeInfoPropertyName = "CreateAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType4), TypeInfoPropertyName = "CreateAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType5), TypeInfoPropertyName = "CreateAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType6), TypeInfoPropertyName = "CreateAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType7), TypeInfoPropertyName = "CreateAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType8), TypeInfoPropertyName = "CreateAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType9), TypeInfoPropertyName = "CreateAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseCollectionType), TypeInfoPropertyName = "GetAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType), TypeInfoPropertyName = "GetAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType2), TypeInfoPropertyName = "GetAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType3), TypeInfoPropertyName = "GetAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType4), TypeInfoPropertyName = "GetAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType5), TypeInfoPropertyName = "GetAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType6), TypeInfoPropertyName = "GetAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType7), TypeInfoPropertyName = "GetAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType8), TypeInfoPropertyName = "GetAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType9), TypeInfoPropertyName = "GetAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseCollectionType), TypeInfoPropertyName = "UpdateAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType), TypeInfoPropertyName = "UpdateAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType2), TypeInfoPropertyName = "UpdateAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType3), TypeInfoPropertyName = "UpdateAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType4), TypeInfoPropertyName = "UpdateAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType5), TypeInfoPropertyName = "UpdateAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType6), TypeInfoPropertyName = "UpdateAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType7), TypeInfoPropertyName = "UpdateAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType8), TypeInfoPropertyName = "UpdateAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType9), TypeInfoPropertyName = "UpdateAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType), TypeInfoPropertyName = "DeleteAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType2), TypeInfoPropertyName = "DeleteAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType3), TypeInfoPropertyName = "DeleteAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType4), TypeInfoPropertyName = "DeleteAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType5), TypeInfoPropertyName = "DeleteAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType6), TypeInfoPropertyName = "DeleteAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType7), TypeInfoPropertyName = "DeleteAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType8), TypeInfoPropertyName = "DeleteAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType9), TypeInfoPropertyName = "DeleteAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseCollectionType), TypeInfoPropertyName = "FavoriteAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType), TypeInfoPropertyName = "FavoriteAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType2), TypeInfoPropertyName = "FavoriteAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType3), TypeInfoPropertyName = "FavoriteAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType4), TypeInfoPropertyName = "FavoriteAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType5), TypeInfoPropertyName = "FavoriteAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType6), TypeInfoPropertyName = "FavoriteAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType7), TypeInfoPropertyName = "FavoriteAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType8), TypeInfoPropertyName = "FavoriteAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponse10))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

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

            typeof(global::Fal.JsonConverters.UploadAssetRequestTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetRequestTypeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListAssetsMediaTypeItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsMediaTypeItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSourceItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSourceItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSectionJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSectionNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsTagModeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsTagModeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSectionJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSectionNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.GetOrganizationUsageTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType5NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListAssetsResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

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

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>),

            typeof(global::Fal.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType9), TypeInfoPropertyName = "FavoriteAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseCollectionType), TypeInfoPropertyName = "UnfavoriteAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType), TypeInfoPropertyName = "UnfavoriteAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType2), TypeInfoPropertyName = "UnfavoriteAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType3), TypeInfoPropertyName = "UnfavoriteAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType4), TypeInfoPropertyName = "UnfavoriteAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType5), TypeInfoPropertyName = "UnfavoriteAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType6), TypeInfoPropertyName = "UnfavoriteAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType7), TypeInfoPropertyName = "UnfavoriteAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType8), TypeInfoPropertyName = "UnfavoriteAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType9), TypeInfoPropertyName = "UnfavoriteAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetCollectionAssetsResponseAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseAssetType), TypeInfoPropertyName = "ListAssetCollectionAssetsResponseAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetCollectionAssetsResponseAssetTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseAssetTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType), TypeInfoPropertyName = "ListAssetCollectionAssetsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType2), TypeInfoPropertyName = "ListAssetCollectionAssetsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType3), TypeInfoPropertyName = "ListAssetCollectionAssetsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType4), TypeInfoPropertyName = "ListAssetCollectionAssetsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType5), TypeInfoPropertyName = "ListAssetCollectionAssetsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType6), TypeInfoPropertyName = "ListAssetCollectionAssetsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType7), TypeInfoPropertyName = "ListAssetCollectionAssetsResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType8), TypeInfoPropertyName = "ListAssetCollectionAssetsResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType9), TypeInfoPropertyName = "ListAssetCollectionAssetsResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType), TypeInfoPropertyName = "AddAssetToCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType2), TypeInfoPropertyName = "AddAssetToCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType3), TypeInfoPropertyName = "AddAssetToCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType4), TypeInfoPropertyName = "AddAssetToCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType5), TypeInfoPropertyName = "AddAssetToCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType6), TypeInfoPropertyName = "AddAssetToCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType7), TypeInfoPropertyName = "AddAssetToCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType8), TypeInfoPropertyName = "AddAssetToCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType9), TypeInfoPropertyName = "AddAssetToCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType), TypeInfoPropertyName = "RemoveAssetFromCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType2), TypeInfoPropertyName = "RemoveAssetFromCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType3), TypeInfoPropertyName = "RemoveAssetFromCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType4), TypeInfoPropertyName = "RemoveAssetFromCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType5), TypeInfoPropertyName = "RemoveAssetFromCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType6), TypeInfoPropertyName = "RemoveAssetFromCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType7), TypeInfoPropertyName = "RemoveAssetFromCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType8), TypeInfoPropertyName = "RemoveAssetFromCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType9), TypeInfoPropertyName = "RemoveAssetFromCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetCharactersResponseCharacter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseCharacter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseCharacterType), TypeInfoPropertyName = "ListAssetCharactersResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType), TypeInfoPropertyName = "ListAssetCharactersResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType2), TypeInfoPropertyName = "ListAssetCharactersResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType3), TypeInfoPropertyName = "ListAssetCharactersResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType4), TypeInfoPropertyName = "ListAssetCharactersResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType5), TypeInfoPropertyName = "ListAssetCharactersResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType6), TypeInfoPropertyName = "ListAssetCharactersResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType7), TypeInfoPropertyName = "ListAssetCharactersResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType8), TypeInfoPropertyName = "ListAssetCharactersResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType9), TypeInfoPropertyName = "ListAssetCharactersResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseCharacter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseCharacterType), TypeInfoPropertyName = "CreateAssetCharacterResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType), TypeInfoPropertyName = "CreateAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType2), TypeInfoPropertyName = "CreateAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType3), TypeInfoPropertyName = "CreateAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType4), TypeInfoPropertyName = "CreateAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType5), TypeInfoPropertyName = "CreateAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType6), TypeInfoPropertyName = "CreateAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType7), TypeInfoPropertyName = "CreateAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType8), TypeInfoPropertyName = "CreateAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType9), TypeInfoPropertyName = "CreateAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseCharacter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseCharacterType), TypeInfoPropertyName = "UpdateAssetCharacterResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType), TypeInfoPropertyName = "UpdateAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType2), TypeInfoPropertyName = "UpdateAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType3), TypeInfoPropertyName = "UpdateAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType4), TypeInfoPropertyName = "UpdateAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType5), TypeInfoPropertyName = "UpdateAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType6), TypeInfoPropertyName = "UpdateAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType7), TypeInfoPropertyName = "UpdateAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType8), TypeInfoPropertyName = "UpdateAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType9), TypeInfoPropertyName = "UpdateAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseCharacter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseCharacterType), TypeInfoPropertyName = "GetAssetCharacterResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType), TypeInfoPropertyName = "GetAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType2), TypeInfoPropertyName = "GetAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType3), TypeInfoPropertyName = "GetAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType4), TypeInfoPropertyName = "GetAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType5), TypeInfoPropertyName = "GetAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType6), TypeInfoPropertyName = "GetAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType7), TypeInfoPropertyName = "GetAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType8), TypeInfoPropertyName = "GetAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType9), TypeInfoPropertyName = "GetAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType), TypeInfoPropertyName = "DeleteAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType2), TypeInfoPropertyName = "DeleteAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType3), TypeInfoPropertyName = "DeleteAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType4), TypeInfoPropertyName = "DeleteAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType5), TypeInfoPropertyName = "DeleteAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType6), TypeInfoPropertyName = "DeleteAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType7), TypeInfoPropertyName = "DeleteAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType8), TypeInfoPropertyName = "DeleteAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType9), TypeInfoPropertyName = "DeleteAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseCharacter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseCharacterType), TypeInfoPropertyName = "FavoriteAssetCharacterResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType), TypeInfoPropertyName = "FavoriteAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType2), TypeInfoPropertyName = "FavoriteAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType3), TypeInfoPropertyName = "FavoriteAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType4), TypeInfoPropertyName = "FavoriteAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType5), TypeInfoPropertyName = "FavoriteAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType6), TypeInfoPropertyName = "FavoriteAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType7), TypeInfoPropertyName = "FavoriteAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType8), TypeInfoPropertyName = "FavoriteAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType9), TypeInfoPropertyName = "FavoriteAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseCharacter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseCharacterType), TypeInfoPropertyName = "UnfavoriteAssetCharacterResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType), TypeInfoPropertyName = "UnfavoriteAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType2), TypeInfoPropertyName = "UnfavoriteAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType3), TypeInfoPropertyName = "UnfavoriteAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType4), TypeInfoPropertyName = "UnfavoriteAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType5), TypeInfoPropertyName = "UnfavoriteAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType6), TypeInfoPropertyName = "UnfavoriteAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType7), TypeInfoPropertyName = "UnfavoriteAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType8), TypeInfoPropertyName = "UnfavoriteAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType9), TypeInfoPropertyName = "UnfavoriteAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetTagsResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType), TypeInfoPropertyName = "ListAssetTagsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType2), TypeInfoPropertyName = "ListAssetTagsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType3), TypeInfoPropertyName = "ListAssetTagsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType4), TypeInfoPropertyName = "ListAssetTagsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType5), TypeInfoPropertyName = "ListAssetTagsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType6), TypeInfoPropertyName = "ListAssetTagsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType7), TypeInfoPropertyName = "ListAssetTagsResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType8), TypeInfoPropertyName = "ListAssetTagsResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType9), TypeInfoPropertyName = "ListAssetTagsResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType), TypeInfoPropertyName = "CreateAssetTagResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType2), TypeInfoPropertyName = "CreateAssetTagResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType3), TypeInfoPropertyName = "CreateAssetTagResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType4), TypeInfoPropertyName = "CreateAssetTagResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType5), TypeInfoPropertyName = "CreateAssetTagResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType6), TypeInfoPropertyName = "CreateAssetTagResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType7), TypeInfoPropertyName = "CreateAssetTagResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType8), TypeInfoPropertyName = "CreateAssetTagResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType9), TypeInfoPropertyName = "CreateAssetTagResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.SetAssetTagsForAssetResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType), TypeInfoPropertyName = "SetAssetTagsForAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType2), TypeInfoPropertyName = "SetAssetTagsForAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType3), TypeInfoPropertyName = "SetAssetTagsForAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType4), TypeInfoPropertyName = "SetAssetTagsForAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType5), TypeInfoPropertyName = "SetAssetTagsForAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType6), TypeInfoPropertyName = "SetAssetTagsForAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType7), TypeInfoPropertyName = "SetAssetTagsForAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType8), TypeInfoPropertyName = "SetAssetTagsForAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType9), TypeInfoPropertyName = "SetAssetTagsForAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType), TypeInfoPropertyName = "UpdateAssetTagResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType2), TypeInfoPropertyName = "UpdateAssetTagResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType3), TypeInfoPropertyName = "UpdateAssetTagResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType4), TypeInfoPropertyName = "UpdateAssetTagResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType5), TypeInfoPropertyName = "UpdateAssetTagResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType6), TypeInfoPropertyName = "UpdateAssetTagResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType7), TypeInfoPropertyName = "UpdateAssetTagResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType8), TypeInfoPropertyName = "UpdateAssetTagResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType9), TypeInfoPropertyName = "UpdateAssetTagResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType), TypeInfoPropertyName = "DeleteAssetTagResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType2), TypeInfoPropertyName = "DeleteAssetTagResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType3), TypeInfoPropertyName = "DeleteAssetTagResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType4), TypeInfoPropertyName = "DeleteAssetTagResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType5), TypeInfoPropertyName = "DeleteAssetTagResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType6), TypeInfoPropertyName = "DeleteAssetTagResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType7), TypeInfoPropertyName = "DeleteAssetTagResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType8), TypeInfoPropertyName = "DeleteAssetTagResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType9), TypeInfoPropertyName = "DeleteAssetTagResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseAssetType), TypeInfoPropertyName = "UploadAssetResponseAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.UploadAssetResponseAssetTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseAssetTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType), TypeInfoPropertyName = "UploadAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType2), TypeInfoPropertyName = "UploadAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType3), TypeInfoPropertyName = "UploadAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType4), TypeInfoPropertyName = "UploadAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType5), TypeInfoPropertyName = "UploadAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType6), TypeInfoPropertyName = "UploadAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType7), TypeInfoPropertyName = "UploadAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponse9))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

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

            typeof(global::Fal.JsonConverters.UploadAssetRequestTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetRequestTypeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListAssetsMediaTypeItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsMediaTypeItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSourceItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSourceItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSectionJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSectionNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsTagModeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsTagModeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSectionJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSectionNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.GetOrganizationUsageTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType5NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListAssetsResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

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

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>),

            typeof(global::Fal.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType8), TypeInfoPropertyName = "UploadAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType9), TypeInfoPropertyName = "UploadAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseAssetType), TypeInfoPropertyName = "GetAssetResponseAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAssetResponseAssetTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseAssetTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType), TypeInfoPropertyName = "GetAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType2), TypeInfoPropertyName = "GetAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType3), TypeInfoPropertyName = "GetAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType4), TypeInfoPropertyName = "GetAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType5), TypeInfoPropertyName = "GetAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType6), TypeInfoPropertyName = "GetAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType7), TypeInfoPropertyName = "GetAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType8), TypeInfoPropertyName = "GetAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType9), TypeInfoPropertyName = "GetAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType), TypeInfoPropertyName = "FavoriteAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType2), TypeInfoPropertyName = "FavoriteAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType3), TypeInfoPropertyName = "FavoriteAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType4), TypeInfoPropertyName = "FavoriteAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType5), TypeInfoPropertyName = "FavoriteAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType6), TypeInfoPropertyName = "FavoriteAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType7), TypeInfoPropertyName = "FavoriteAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType8), TypeInfoPropertyName = "FavoriteAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType9), TypeInfoPropertyName = "FavoriteAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType), TypeInfoPropertyName = "UnfavoriteAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType2), TypeInfoPropertyName = "UnfavoriteAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType3), TypeInfoPropertyName = "UnfavoriteAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType4), TypeInfoPropertyName = "UnfavoriteAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType5), TypeInfoPropertyName = "UnfavoriteAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType6), TypeInfoPropertyName = "UnfavoriteAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType7), TypeInfoPropertyName = "UnfavoriteAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType8), TypeInfoPropertyName = "UnfavoriteAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType9), TypeInfoPropertyName = "UnfavoriteAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListAssetTagsForAssetResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType), TypeInfoPropertyName = "ListAssetTagsForAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType2), TypeInfoPropertyName = "ListAssetTagsForAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType3), TypeInfoPropertyName = "ListAssetTagsForAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType4), TypeInfoPropertyName = "ListAssetTagsForAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType5), TypeInfoPropertyName = "ListAssetTagsForAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType6), TypeInfoPropertyName = "ListAssetTagsForAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType7), TypeInfoPropertyName = "ListAssetTagsForAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType8), TypeInfoPropertyName = "ListAssetTagsForAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType9), TypeInfoPropertyName = "ListAssetTagsForAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType), TypeInfoPropertyName = "AssignAssetTagResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType2), TypeInfoPropertyName = "AssignAssetTagResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType3), TypeInfoPropertyName = "AssignAssetTagResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType4), TypeInfoPropertyName = "AssignAssetTagResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType5), TypeInfoPropertyName = "AssignAssetTagResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType6), TypeInfoPropertyName = "AssignAssetTagResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType7), TypeInfoPropertyName = "AssignAssetTagResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType8), TypeInfoPropertyName = "AssignAssetTagResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType9), TypeInfoPropertyName = "AssignAssetTagResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType), TypeInfoPropertyName = "UnassignAssetTagResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType2), TypeInfoPropertyName = "UnassignAssetTagResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType3), TypeInfoPropertyName = "UnassignAssetTagResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType4), TypeInfoPropertyName = "UnassignAssetTagResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType5), TypeInfoPropertyName = "UnassignAssetTagResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType6), TypeInfoPropertyName = "UnassignAssetTagResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType7), TypeInfoPropertyName = "UnassignAssetTagResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType8), TypeInfoPropertyName = "UnassignAssetTagResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType9), TypeInfoPropertyName = "UnassignAssetTagResponseErrorType92")]
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
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

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

            typeof(global::Fal.JsonConverters.UploadAssetRequestTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetRequestTypeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListAssetsMediaTypeItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsMediaTypeItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSourceItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSourceItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSectionJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsSectionNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsTagModeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsTagModeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSectionJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsSectionNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.GetOrganizationUsageTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageTimeframeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeNullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.SearchRequestsResponseErrorType5NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.ListAssetsResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.CreateAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UploadAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseAssetTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseAssetTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.GetAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.FavoriteAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.AssignAssetTagResponseErrorType9NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8NullableJsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9JsonConverter),

            typeof(global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeNullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5NullableJsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6JsonConverter),

            typeof(global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6NullableJsonConverter),

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

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

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

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>),

            typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>),

            typeof(global::Fal.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseErrorType3), TypeInfoPropertyName = "GetModelAccessControlsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseErrorType4), TypeInfoPropertyName = "GetModelAccessControlsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetOrganizationTeamsResponseTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseTeam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType), TypeInfoPropertyName = "GetOrganizationTeamsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType2), TypeInfoPropertyName = "GetOrganizationTeamsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType3), TypeInfoPropertyName = "GetOrganizationTeamsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType4), TypeInfoPropertyName = "GetOrganizationTeamsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType5), TypeInfoPropertyName = "GetOrganizationTeamsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType6), TypeInfoPropertyName = "GetOrganizationTeamsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetOrganizationUsageResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseTimeSerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetOrganizationUsageResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseTimeSerieResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetOrganizationUsageResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType), TypeInfoPropertyName = "GetOrganizationUsageResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType2), TypeInfoPropertyName = "GetOrganizationUsageResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType3), TypeInfoPropertyName = "GetOrganizationUsageResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType4), TypeInfoPropertyName = "GetOrganizationUsageResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType5), TypeInfoPropertyName = "GetOrganizationUsageResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType6), TypeInfoPropertyName = "GetOrganizationUsageResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponseErrorType), TypeInfoPropertyName = "GetMetaResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponseErrorType2), TypeInfoPropertyName = "GetMetaResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessLogsHistoryRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessLogsStreamRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetsMediaTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetsSourceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetCollectionAssetsMediaTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetCollectionAssetsSourceItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetsResponseAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetsResponseAssetTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetCollectionsResponseCollection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetCollectionAssetsResponseAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetCollectionAssetsResponseAssetTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetCharactersResponseCharacter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetTagsResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.SetAssetTagsForAssetResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.UploadAssetResponseAssetTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAssetResponseAssetTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetTagsForAssetResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetAnalyticsResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetAnalyticsResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessGetAnalyticsResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListRootResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListDirectoryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessLogsHistoryResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListRequestsByEndpointResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListComputeInstancesResponseInstance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListApiKeysResponseKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationTeamsResponseTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationUsageResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationUsageResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationUsageResponseSummaryItem>))]
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default,

            SourceGenerationContextChunk2.Default,

            SourceGenerationContextChunk3.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingRequestVariant1EstimateTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingRequestVariant1EstimateTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingRequestVariant2EstimateTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingRequestVariant2EstimateTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetRequestTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetRequestTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsHistoryRequestItemConditionTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsHistoryRequestItemConditionTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsStreamRequestItemConditionTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsStreamRequestItemConditionTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceRequestInstanceTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceRequestInstanceTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceRequestSectorJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceRequestSectorNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsStatusJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsStatusNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageTimeframeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageTimeframeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageBoundToTimeframeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageBoundToTimeframeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsTimeframeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsTimeframeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsBoundToTimeframeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsBoundToTimeframeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointStatusJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointStatusNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointSortByJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointSortByNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsMediaTypeItemJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsMediaTypeItemNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsSourceItemJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsSourceItemNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsSectionJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsSectionNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsTagModeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsTagModeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsSectionJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsSectionNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsTimeframeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsTimeframeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsBoundToTimeframeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsBoundToTimeframeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsHistoryRunSourceJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsHistoryRunSourceNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsStreamRunSourceJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsStreamRunSourceNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointStatusJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointStatusNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointSortByJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointSortByNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportSourceJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportSourceNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportTimeframeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportTimeframeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportBoundToTimeframeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportBoundToTimeframeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageTimeframeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageTimeframeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseModelMetadataStatusJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseModelMetadataStatusNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseModelMetadataLicenseTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseModelMetadataLicenseTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseModelMetadataKindJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseModelMetadataKindNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseModelEnterpriseStatusEnumJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseModelEnterpriseStatusEnumNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetPricingResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetPricingResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetPricingResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetPricingResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetPricingResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetPricingResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetPricingResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetPricingResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingResponseEstimateTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingResponseEstimateTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.EstimatePricingResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetUsageResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAnalyticsResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetBillingEventsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetBillingEventsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetBillingEventsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetBillingEventsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetBillingEventsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetBillingEventsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetBillingEventsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetBillingEventsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetBillingEventsResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetBillingEventsResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SearchRequestsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SearchRequestsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SearchRequestsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SearchRequestsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SearchRequestsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SearchRequestsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SearchRequestsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SearchRequestsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SearchRequestsResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SearchRequestsResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListWorkflowsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListWorkflowsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListWorkflowsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListWorkflowsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListWorkflowsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListWorkflowsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListWorkflowsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListWorkflowsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetWorkflowResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseAssetTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseAssetTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetsResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateAssetTagResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseAssetTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseAssetTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UploadAssetResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseAssetTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseAssetTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAssetResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.FavoriteAssetResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.AssignAssetTagResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAnalyticsResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetAppQueueInfoResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessFlushAppQueueResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRootResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRootResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRootResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRootResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRootResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRootResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListDirectoryResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessDownloadFileResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadFromUrlResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessUploadLocalFileResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessGetMetricsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsHistoryResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessLogsStreamResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ServerlessListRequestsByEndpointResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceInstanceTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceInstanceTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceRegionJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceRegionNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceSectorJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceSectorNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceStatusJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceStatusNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseInstanceTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseInstanceTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseRegionJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseRegionNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseSectorJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseSectorNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseStatusJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseInstanceTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseInstanceTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseRegionJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseRegionNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseSectorJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseSectorNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseStatusJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListApiKeysResponseKeyScopeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListApiKeysResponseKeyScopeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListApiKeysResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListApiKeysResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListApiKeysResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListApiKeysResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListApiKeysResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListApiKeysResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListApiKeysResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.ListApiKeysResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateApiKeyResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateApiKeyResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateApiKeyResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateApiKeyResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateApiKeyResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateApiKeyResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateApiKeyResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateApiKeyResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateApiKeyResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.CreateApiKeyResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteApiKeyResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteApiKeyResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAccountBillingResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAccountBillingResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAccountBillingResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAccountBillingResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAccountBillingResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAccountBillingResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAccountBillingResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAccountBillingResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAccountBillingResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetAccountBillingResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetFocusReportResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetMetaResponseErrorTypeJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetMetaResponseErrorTypeNullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetMetaResponseErrorType2JsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.GetMetaResponseErrorType2NullableJsonConverter());
            options.Converters.Add(new global::Fal.JsonConverters.OneOfJsonConverter<global::Fal.EstimatePricingRequestVariant1, global::Fal.EstimatePricingRequestVariant2>());
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
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
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
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>());
            options.Converters.Add(new global::Fal.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}