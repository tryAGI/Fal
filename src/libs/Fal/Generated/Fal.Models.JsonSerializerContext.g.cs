
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsStatus), TypeInfoPropertyName = "GetModelsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>), TypeInfoPropertyName = "AnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseTimeSerieResultAuthMethodStructured))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetUsageResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseSummaryItemAuthMethodStructured))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseBillingEventAuthMethodStructured))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.EstimatePricingRequestVariant1, global::Fal.EstimatePricingRequestVariant2>?), TypeInfoPropertyName = "NullableOneOfEstimatePricingRequestVariant1EstimatePricingRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant1EstimateType?), TypeInfoPropertyName = "NullableEstimatePricingRequestVariant1EstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant2EstimateType?), TypeInfoPropertyName = "NullableEstimatePricingRequestVariant2EstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsStatus?), TypeInfoPropertyName = "NullableGetModelsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>?), TypeInfoPropertyName = "NullableAnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseErrorType?), TypeInfoPropertyName = "NullableGetModelsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseErrorType2?), TypeInfoPropertyName = "NullableGetModelsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseErrorType3?), TypeInfoPropertyName = "NullableGetModelsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsResponseErrorType4?), TypeInfoPropertyName = "NullableGetModelsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseErrorType?), TypeInfoPropertyName = "NullableGetPricingResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseErrorType2?), TypeInfoPropertyName = "NullableGetPricingResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseErrorType3?), TypeInfoPropertyName = "NullableGetPricingResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetPricingResponseErrorType4?), TypeInfoPropertyName = "NullableGetPricingResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseEstimateType?), TypeInfoPropertyName = "NullableEstimatePricingResponseEstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseErrorType?), TypeInfoPropertyName = "NullableEstimatePricingResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseErrorType2?), TypeInfoPropertyName = "NullableEstimatePricingResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseErrorType3?), TypeInfoPropertyName = "NullableEstimatePricingResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingResponseErrorType4?), TypeInfoPropertyName = "NullableEstimatePricingResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseErrorType?), TypeInfoPropertyName = "NullableGetUsageResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseErrorType2?), TypeInfoPropertyName = "NullableGetUsageResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseErrorType3?), TypeInfoPropertyName = "NullableGetUsageResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageResponseErrorType4?), TypeInfoPropertyName = "NullableGetUsageResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType?), TypeInfoPropertyName = "NullableGetAnalyticsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType2?), TypeInfoPropertyName = "NullableGetAnalyticsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType3?), TypeInfoPropertyName = "NullableGetAnalyticsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType4?), TypeInfoPropertyName = "NullableGetAnalyticsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType5?), TypeInfoPropertyName = "NullableGetAnalyticsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsResponseErrorType6?), TypeInfoPropertyName = "NullableGetAnalyticsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType?), TypeInfoPropertyName = "NullableGetBillingEventsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType2?), TypeInfoPropertyName = "NullableGetBillingEventsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType3?), TypeInfoPropertyName = "NullableGetBillingEventsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType4?), TypeInfoPropertyName = "NullableGetBillingEventsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetBillingEventsResponseErrorType5?), TypeInfoPropertyName = "NullableGetBillingEventsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType?), TypeInfoPropertyName = "NullableDeleteRequestPayloadsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType2?), TypeInfoPropertyName = "NullableDeleteRequestPayloadsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType3?), TypeInfoPropertyName = "NullableDeleteRequestPayloadsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType4?), TypeInfoPropertyName = "NullableDeleteRequestPayloadsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType5?), TypeInfoPropertyName = "NullableDeleteRequestPayloadsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteRequestPayloadsResponseErrorType6?), TypeInfoPropertyName = "NullableDeleteRequestPayloadsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType?), TypeInfoPropertyName = "NullableListRequestsByEndpointResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType2?), TypeInfoPropertyName = "NullableListRequestsByEndpointResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType3?), TypeInfoPropertyName = "NullableListRequestsByEndpointResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType4?), TypeInfoPropertyName = "NullableListRequestsByEndpointResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType5?), TypeInfoPropertyName = "NullableListRequestsByEndpointResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointResponseErrorType6?), TypeInfoPropertyName = "NullableListRequestsByEndpointResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType?), TypeInfoPropertyName = "NullableSearchRequestsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType2?), TypeInfoPropertyName = "NullableSearchRequestsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType3?), TypeInfoPropertyName = "NullableSearchRequestsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType4?), TypeInfoPropertyName = "NullableSearchRequestsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SearchRequestsResponseErrorType5?), TypeInfoPropertyName = "NullableSearchRequestsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.List<string>>))]
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
    internal sealed partial class ModelsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


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
                    typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant1EstimateType)

                    || typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant1EstimateType?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant2EstimateType)

                    || typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant2EstimateType?)

                    || typeToConvert == typeof(global::Fal.GetModelsStatus)

                    || typeToConvert == typeof(global::Fal.GetModelsStatus?)

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

                    || typeToConvert == typeof(global::Fal.GetModelsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetModelsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetPricingResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetPricingResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetPricingResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetPricingResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetPricingResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetPricingResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetPricingResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetPricingResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseEstimateType)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseEstimateType?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetUsageResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetUsageResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetUsageResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetUsageResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetUsageResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetUsageResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetUsageResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetUsageResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType5?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant1EstimateType))
                {
                    return new global::Fal.JsonConverters.EstimatePricingRequestVariant1EstimateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant1EstimateType?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingRequestVariant1EstimateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant2EstimateType))
                {
                    return new global::Fal.JsonConverters.EstimatePricingRequestVariant2EstimateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingRequestVariant2EstimateType?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingRequestVariant2EstimateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsStatus))
                {
                    return new global::Fal.JsonConverters.GetModelsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsStatus?))
                {
                    return new global::Fal.JsonConverters.GetModelsStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Fal.GetModelsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetModelsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetPricingResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetPricingResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetPricingResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetPricingResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetPricingResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetPricingResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetPricingResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetPricingResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetPricingResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetPricingResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetPricingResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetPricingResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetPricingResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetPricingResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetPricingResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetPricingResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseEstimateType))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseEstimateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseEstimateType?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseEstimateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.EstimatePricingResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.EstimatePricingResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetUsageResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetUsageResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetUsageResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetUsageResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetUsageResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetUsageResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetUsageResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetUsageResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetUsageResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAnalyticsResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetAnalyticsResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetBillingEventsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetBillingEventsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteRequestPayloadsResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.DeleteRequestPayloadsResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListRequestsByEndpointResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ListRequestsByEndpointResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.SearchRequestsResponseErrorType5NullableJsonConverter();
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