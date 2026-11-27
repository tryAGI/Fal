
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.EstimatePricingRequestVariant1, global::Fal.EstimatePricingRequestVariant2, global::Fal.EstimatePricingRequestVariant3>), TypeInfoPropertyName = "AnyOfEstimatePricingRequestVariant1EstimatePricingRequestVariant2EstimatePricingRequestVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.EstimatePricingRequestVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant2EstimateType), TypeInfoPropertyName = "EstimatePricingRequestVariant2EstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Fal.EstimatePricingRequestVariant2Endpoints2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant2Endpoints2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant3EstimateType), TypeInfoPropertyName = "EstimatePricingRequestVariant3EstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Fal.EstimatePricingRequestVariant3Endpoints2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant3Endpoints2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsStatus), TypeInfoPropertyName = "GetModelsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsSort), TypeInfoPropertyName = "GetModelsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>), TypeInfoPropertyName = "AnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageTimeframe), TypeInfoPropertyName = "GetUsageTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageBoundToTimeframe), TypeInfoPropertyName = "GetUsageBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageSource), TypeInfoPropertyName = "GetUsageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsTimeframe), TypeInfoPropertyName = "GetAnalyticsTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsBoundToTimeframe), TypeInfoPropertyName = "GetAnalyticsBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsSource), TypeInfoPropertyName = "GetBillingEventsSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointStatus), TypeInfoPropertyName = "ListRequestsByEndpointStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointSortBy), TypeInfoPropertyName = "ListRequestsByEndpointSortBy2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseOrdering))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseOrderingSort), TypeInfoPropertyName = "GetModelsResponseOrderingSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseErrorType), TypeInfoPropertyName = "GetModelsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetPricingResponsePrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponsePrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseErrorType), TypeInfoPropertyName = "GetPricingResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponse5))]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.EstimatePricingResponseVariant1, global::Fal.EstimatePricingResponseVariant2>), TypeInfoPropertyName = "AnyOfEstimatePricingResponseVariant1EstimatePricingResponseVariant22")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1Status), TypeInfoPropertyName = "EstimatePricingResponseVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1Confidence), TypeInfoPropertyName = "EstimatePricingResponseVariant1Confidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemStatus), TypeInfoPropertyName = "EstimatePricingResponseVariant1ItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1ItemWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemWarning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemErrorType), TypeInfoPropertyName = "EstimatePricingResponseVariant1ItemErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1ItemErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemErrorError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, double?>), TypeInfoPropertyName = "AnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponentBillingUnit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponentConfidence), TypeInfoPropertyName = "EstimatePricingResponseVariant1ItemPerRequestComponentConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence), TypeInfoPropertyName = "EstimatePricingResponseVariant1ItemPerRequestConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestKnownConfidence), TypeInfoPropertyName = "EstimatePricingResponseVariant1ItemPerRequestKnownConfidence2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant2))]
    #pragma warning restore CS0618
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant2EstimateType), TypeInfoPropertyName = "EstimatePricingResponseVariant2EstimateType2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseErrorType), TypeInfoPropertyName = "EstimatePricingResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetUsageResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseTimeSerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetUsageResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseTimeSerieResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseTimeSerieResultAuthMethodStructured))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetUsageResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseSummaryItemAuthMethodStructured))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseErrorType), TypeInfoPropertyName = "GetUsageResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAnalyticsResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseTimeSerie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAnalyticsResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseTimeSerieResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAnalyticsResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType), TypeInfoPropertyName = "GetAnalyticsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetBillingEventsResponseBillingEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseBillingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseBillingEventAuthMethodStructured))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType), TypeInfoPropertyName = "GetBillingEventsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.DeleteRequestPayloadsResponseCdnDeleteResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseCdnDeleteResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType), TypeInfoPropertyName = "DeleteRequestPayloadsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.ListRequestsByEndpointResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType), TypeInfoPropertyName = "ListRequestsByEndpointResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.SearchRequestsResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType), TypeInfoPropertyName = "SearchRequestsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.EstimatePricingRequestVariant1, global::Fal.EstimatePricingRequestVariant2, global::Fal.EstimatePricingRequestVariant3>?), TypeInfoPropertyName = "NullableAnyOfEstimatePricingRequestVariant1EstimatePricingRequestVariant2EstimatePricingRequestVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant2EstimateType?), TypeInfoPropertyName = "NullableEstimatePricingRequestVariant2EstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant3EstimateType?), TypeInfoPropertyName = "NullableEstimatePricingRequestVariant3EstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsStatus?), TypeInfoPropertyName = "NullableGetModelsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsSort?), TypeInfoPropertyName = "NullableGetModelsSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>?), TypeInfoPropertyName = "NullableAnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageTimeframe?), TypeInfoPropertyName = "NullableGetUsageTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageBoundToTimeframe?), TypeInfoPropertyName = "NullableGetUsageBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageSource?), TypeInfoPropertyName = "NullableGetUsageSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsTimeframe?), TypeInfoPropertyName = "NullableGetAnalyticsTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsBoundToTimeframe?), TypeInfoPropertyName = "NullableGetAnalyticsBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsSource?), TypeInfoPropertyName = "NullableGetBillingEventsSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointStatus?), TypeInfoPropertyName = "NullableListRequestsByEndpointStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointSortBy?), TypeInfoPropertyName = "NullableListRequestsByEndpointSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelMetadataStatus?), TypeInfoPropertyName = "NullableGetModelsResponseModelMetadataStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelMetadataLicenseType?), TypeInfoPropertyName = "NullableGetModelsResponseModelMetadataLicenseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelMetadataKind?), TypeInfoPropertyName = "NullableGetModelsResponseModelMetadataKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>?), TypeInfoPropertyName = "NullableAnyOfGetModelsResponseModelOpenapiVariant1GetModelsResponseModelOpenapiVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>?), TypeInfoPropertyName = "NullableAnyOfGetModelsResponseModelEnterpriseStatusEnumGetModelsResponseModelEnterpriseStatusEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseModelEnterpriseStatusEnum?), TypeInfoPropertyName = "NullableGetModelsResponseModelEnterpriseStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseOrderingSort?), TypeInfoPropertyName = "NullableGetModelsResponseOrderingSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseErrorType?), TypeInfoPropertyName = "NullableGetModelsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseErrorType?), TypeInfoPropertyName = "NullableGetPricingResponseErrorType2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.EstimatePricingResponseVariant1, global::Fal.EstimatePricingResponseVariant2>?), TypeInfoPropertyName = "NullableAnyOfEstimatePricingResponseVariant1EstimatePricingResponseVariant22")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1Status?), TypeInfoPropertyName = "NullableEstimatePricingResponseVariant1Status2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1Confidence?), TypeInfoPropertyName = "NullableEstimatePricingResponseVariant1Confidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemStatus?), TypeInfoPropertyName = "NullableEstimatePricingResponseVariant1ItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemErrorType?), TypeInfoPropertyName = "NullableEstimatePricingResponseVariant1ItemErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, double?>?), TypeInfoPropertyName = "NullableAnyOfStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponentConfidence?), TypeInfoPropertyName = "NullableEstimatePricingResponseVariant1ItemPerRequestComponentConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence?), TypeInfoPropertyName = "NullableEstimatePricingResponseVariant1ItemPerRequestConfidence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestKnownConfidence?), TypeInfoPropertyName = "NullableEstimatePricingResponseVariant1ItemPerRequestKnownConfidence2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseVariant2EstimateType?), TypeInfoPropertyName = "NullableEstimatePricingResponseVariant2EstimateType2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseErrorType?), TypeInfoPropertyName = "NullableEstimatePricingResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseErrorType?), TypeInfoPropertyName = "NullableGetUsageResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType?), TypeInfoPropertyName = "NullableGetAnalyticsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType?), TypeInfoPropertyName = "NullableGetBillingEventsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType?), TypeInfoPropertyName = "NullableDeleteRequestPayloadsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType?), TypeInfoPropertyName = "NullableListRequestsByEndpointResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType?), TypeInfoPropertyName = "NullableSearchRequestsResponseErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.EstimatePricingRequestVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetModelsResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetPricingResponsePrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.EstimatePricingResponseVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.EstimatePricingResponseVariant1ItemWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.EstimatePricingResponseVariant1ItemErrorError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.AnyOf<string, double?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
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
    internal sealed partial class ModelsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ModelsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ModelsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.EstimatePricingRequestVariant1, global::Fal.EstimatePricingRequestVariant2, global::Fal.EstimatePricingRequestVariant3>());
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
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>());
            #pragma warning disable CS0618 // Converter references a deprecated API model.
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.EstimatePricingResponseVariant1, global::Fal.EstimatePricingResponseVariant2>());
            #pragma warning restore CS0618
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<string, double?>());
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
                    typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant2EstimateType)

                    || typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant2EstimateType?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant3EstimateType)

                    || typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant3EstimateType?)

                    || typeToConvert == typeof(global::Fal.GetModelsStatus)

                    || typeToConvert == typeof(global::Fal.GetModelsStatus?)

                    || typeToConvert == typeof(global::Fal.GetModelsSort)

                    || typeToConvert == typeof(global::Fal.GetModelsSort?)

                    || typeToConvert == typeof(global::Fal.GetUsageTimeframe)

                    || typeToConvert == typeof(global::Fal.GetUsageTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetUsageBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.GetUsageBoundToTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetUsageSource)

                    || typeToConvert == typeof(global::Fal.GetUsageSource?)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsTimeframe)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsBoundToTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsSource)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsSource?)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointStatus)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointStatus?)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointSortBy)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointSortBy?)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataStatus)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataStatus?)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataLicenseType)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataLicenseType?)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataKind)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataKind?)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseModelEnterpriseStatusEnum)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseModelEnterpriseStatusEnum?)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseOrderingSort)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseOrderingSort?)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetPricingResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetPricingResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1Status)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1Status?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1Confidence)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1Confidence?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemStatus)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemStatus?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemErrorType)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemErrorType?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponentConfidence)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponentConfidence?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestKnownConfidence)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestKnownConfidence?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant2EstimateType)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant2EstimateType?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetUsageResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetUsageResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant2EstimateType))
                {
                    return new global::Fal.JsonConverters.EstimatePricingRequestVariant2EstimateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant2EstimateType?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingRequestVariant2EstimateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant3EstimateType))
                {
                    return new global::Fal.JsonConverters.EstimatePricingRequestVariant3EstimateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant3EstimateType?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingRequestVariant3EstimateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsStatus))
                {
                    return new global::Fal.JsonConverters.GetModelsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsStatus?))
                {
                    return new global::Fal.JsonConverters.GetModelsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsSort))
                {
                    return new global::Fal.JsonConverters.GetModelsSortJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsSort?))
                {
                    return new global::Fal.JsonConverters.GetModelsSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageTimeframe))
                {
                    return new global::Fal.JsonConverters.GetUsageTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageTimeframe?))
                {
                    return new global::Fal.JsonConverters.GetUsageTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageBoundToTimeframe))
                {
                    return new global::Fal.JsonConverters.GetUsageBoundToTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageBoundToTimeframe?))
                {
                    return new global::Fal.JsonConverters.GetUsageBoundToTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageSource))
                {
                    return new global::Fal.JsonConverters.GetUsageSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageSource?))
                {
                    return new global::Fal.JsonConverters.GetUsageSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsTimeframe))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsTimeframe?))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsBoundToTimeframe))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsBoundToTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsBoundToTimeframe?))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsBoundToTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsSource))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsSource?))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointStatus))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointStatus?))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointSortBy))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointSortBy?))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataStatus))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseModelMetadataStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataStatus?))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseModelMetadataStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataLicenseType))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseModelMetadataLicenseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataLicenseType?))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseModelMetadataLicenseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataKind))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseModelMetadataKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseModelMetadataKind?))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseModelMetadataKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseModelEnterpriseStatusEnum))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseModelEnterpriseStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseModelEnterpriseStatusEnum?))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseModelEnterpriseStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseOrderingSort))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseOrderingSortJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseOrderingSort?))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseOrderingSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetPricingResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetPricingResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetPricingResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetPricingResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1Status))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1StatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1Status?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1StatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1Confidence))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ConfidenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1Confidence?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ConfidenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemStatus))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemStatus?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemErrorType))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemErrorType?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponentConfidence))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemPerRequestComponentConfidenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestComponentConfidence?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemPerRequestComponentConfidenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemPerRequestConfidenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestConfidence?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemPerRequestConfidenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestKnownConfidence))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemPerRequestKnownConfidenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant1ItemPerRequestKnownConfidence?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemPerRequestKnownConfidenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant2EstimateType))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant2EstimateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseVariant2EstimateType?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseVariant2EstimateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetUsageResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetUsageResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorTypeNullableJsonConverter();
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
                    0 => new ModelsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}