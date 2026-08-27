
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_8df3f0ff85c28fa0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_4af0049b8319fe25")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>?), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_fc90b6f0c4769996")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_898695ff2bd5345d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowRequestContents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowRequestContentsSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequestDefault), TypeInfoPropertyName = "SetStorageFileAclRequestDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.SetStorageFileAclRequestRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequestRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequestRuleDecision), TypeInfoPropertyName = "SetStorageFileAclRequestRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAcl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault), TypeInfoPropertyName = "UpdateStorageSettingsRequestInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.UpdateStorageSettingsRequestInitialAclRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision), TypeInfoPropertyName = "UpdateStorageSettingsRequestInitialAclRuleDecision2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportSource), TypeInfoPropertyName = "GetFocusReportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportExpand), TypeInfoPropertyName = "GetFocusReportExpand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportTimeframe), TypeInfoPropertyName = "GetFocusReportTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportBoundToTimeframe), TypeInfoPropertyName = "GetFocusReportBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportSource), TypeInfoPropertyName = "GetOrganizationFocusReportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportTimeframe), TypeInfoPropertyName = "GetOrganizationFocusReportTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportBoundToTimeframe), TypeInfoPropertyName = "GetOrganizationFocusReportBoundToTimeframe2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseWorkflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseErrorType), TypeInfoPropertyName = "CreateWorkflowResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseErrorType2), TypeInfoPropertyName = "CreateWorkflowResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseErrorType3), TypeInfoPropertyName = "CreateWorkflowResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseErrorType4), TypeInfoPropertyName = "CreateWorkflowResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseErrorType5), TypeInfoPropertyName = "CreateWorkflowResponseErrorType52")]
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_8df3f0ff85c28fa0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_4af0049b8319fe25")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>?), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_fc90b6f0c4769996")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_898695ff2bd5345d")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyType), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseHierarchyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemType), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseHierarchyChildrenItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAssetCollectionHierarchyResponseAncestor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseAncestor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseAncestorType), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseAncestorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType2), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType3), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType4), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType5), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType6), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType7), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType8), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType9), TypeInfoPropertyName = "GetAssetCollectionHierarchyResponseErrorType92")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseCollectionType), TypeInfoPropertyName = "MoveAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType), TypeInfoPropertyName = "MoveAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType2), TypeInfoPropertyName = "MoveAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType3), TypeInfoPropertyName = "MoveAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType4), TypeInfoPropertyName = "MoveAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType5), TypeInfoPropertyName = "MoveAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType6), TypeInfoPropertyName = "MoveAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType7), TypeInfoPropertyName = "MoveAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType8), TypeInfoPropertyName = "MoveAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType9), TypeInfoPropertyName = "MoveAssetCollectionResponseErrorType92")]
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_8df3f0ff85c28fa0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_4af0049b8319fe25")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>?), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_fc90b6f0c4769996")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_898695ff2bd5345d")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Kind), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Type), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant2Kind), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant3Kind), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4Kind), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4EntityType), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4EntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAssetLineageResponseLineageEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageEdge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageEdgeKind), TypeInfoPropertyName = "GetAssetLineageResponseLineageEdgeKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.GetAssetLineageResponseLineageEdgeRole?, object, object>), TypeInfoPropertyName = "AnyOfGetAssetLineageResponseLineageEdgeRoleObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageEdgeRole), TypeInfoPropertyName = "GetAssetLineageResponseLineageEdgeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetAssetLineageResponseLineageEdgeEntitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageEdgeEntitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageEdgeEntitieEntityType), TypeInfoPropertyName = "GetAssetLineageResponseLineageEdgeEntitieEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType), TypeInfoPropertyName = "GetAssetLineageResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType2), TypeInfoPropertyName = "GetAssetLineageResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType3), TypeInfoPropertyName = "GetAssetLineageResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType4), TypeInfoPropertyName = "GetAssetLineageResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType5), TypeInfoPropertyName = "GetAssetLineageResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType6), TypeInfoPropertyName = "GetAssetLineageResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseError7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType7), TypeInfoPropertyName = "GetAssetLineageResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponse9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseError8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType8), TypeInfoPropertyName = "GetAssetLineageResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponse10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseError9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType9), TypeInfoPropertyName = "GetAssetLineageResponseErrorType92")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseDefault), TypeInfoPropertyName = "GetStorageFileAclResponseDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetStorageFileAclResponseRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseRuleDecision), TypeInfoPropertyName = "GetStorageFileAclResponseRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType2), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType3), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType4), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType5), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType6), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseDefault), TypeInfoPropertyName = "SetStorageFileAclResponseDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.SetStorageFileAclResponseRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseRuleDecision), TypeInfoPropertyName = "SetStorageFileAclResponseRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType2), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType3), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType4), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType5), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType6), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType2), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType3), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType4), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType5), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType6), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAcl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault), TypeInfoPropertyName = "GetStorageSettingsResponseInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetStorageSettingsResponseInitialAclRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAclRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision), TypeInfoPropertyName = "GetStorageSettingsResponseInitialAclRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType), TypeInfoPropertyName = "GetStorageSettingsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType2), TypeInfoPropertyName = "GetStorageSettingsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType3), TypeInfoPropertyName = "GetStorageSettingsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType4), TypeInfoPropertyName = "GetStorageSettingsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAcl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault), TypeInfoPropertyName = "UpdateStorageSettingsResponseInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.UpdateStorageSettingsResponseInitialAclRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision), TypeInfoPropertyName = "UpdateStorageSettingsResponseInitialAclRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType), TypeInfoPropertyName = "UpdateStorageSettingsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType2), TypeInfoPropertyName = "UpdateStorageSettingsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType3), TypeInfoPropertyName = "UpdateStorageSettingsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType4), TypeInfoPropertyName = "UpdateStorageSettingsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType5), TypeInfoPropertyName = "UpdateStorageSettingsResponseErrorType52")]
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_8df3f0ff85c28fa0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_4af0049b8319fe25")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>?), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_fc90b6f0c4769996")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_898695ff2bd5345d")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetOrganizationBillingEventsResponseBillingEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseBillingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseBillingEventAuthMethodStructured))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType), TypeInfoPropertyName = "GetOrganizationBillingEventsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType2), TypeInfoPropertyName = "GetOrganizationBillingEventsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType3), TypeInfoPropertyName = "GetOrganizationBillingEventsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType4), TypeInfoPropertyName = "GetOrganizationBillingEventsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType5), TypeInfoPropertyName = "GetOrganizationBillingEventsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType6), TypeInfoPropertyName = "GetOrganizationBillingEventsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType), TypeInfoPropertyName = "GetOrganizationFocusReportResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType2), TypeInfoPropertyName = "GetOrganizationFocusReportResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType3), TypeInfoPropertyName = "GetOrganizationFocusReportResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType4), TypeInfoPropertyName = "GetOrganizationFocusReportResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType5), TypeInfoPropertyName = "GetOrganizationFocusReportResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType6), TypeInfoPropertyName = "GetOrganizationFocusReportResponseErrorType62")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseTimeSerieResultProduct), TypeInfoPropertyName = "GetOrganizationUsageResponseTimeSerieResultProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseTimeSerieResultAuthMethodStructured))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetOrganizationUsageResponseSummaryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseSummaryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseSummaryItemProduct), TypeInfoPropertyName = "GetOrganizationUsageResponseSummaryItemProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseSummaryItemAuthMethodStructured))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType), TypeInfoPropertyName = "GetOrganizationUsageResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType2), TypeInfoPropertyName = "GetOrganizationUsageResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseError3))]
    internal sealed partial class SourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_8df3f0ff85c28fa0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_4af0049b8319fe25")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>?), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_fc90b6f0c4769996")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_898695ff2bd5345d")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.EstimatePricingRequestVariant1, global::Fal.EstimatePricingRequestVariant2>?), TypeInfoPropertyName = "NullableOneOfEstimatePricingRequestVariant1EstimatePricingRequestVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant1EstimateType?), TypeInfoPropertyName = "NullableEstimatePricingRequestVariant1EstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.EstimatePricingRequestVariant2EstimateType?), TypeInfoPropertyName = "NullableEstimatePricingRequestVariant2EstimateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetRequestType?), TypeInfoPropertyName = "NullableUploadAssetRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequestDefault?), TypeInfoPropertyName = "NullableSetStorageFileAclRequestDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequestRuleDecision?), TypeInfoPropertyName = "NullableSetStorageFileAclRequestRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault?), TypeInfoPropertyName = "NullableUpdateStorageSettingsRequestInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision?), TypeInfoPropertyName = "NullableUpdateStorageSettingsRequestInitialAclRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsHistoryRequestItemConditionType?), TypeInfoPropertyName = "NullableServerlessLogsHistoryRequestItemConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ServerlessLogsStreamRequestItemConditionType?), TypeInfoPropertyName = "NullableServerlessLogsStreamRequestItemConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceRequestInstanceType?), TypeInfoPropertyName = "NullableCreateComputeInstanceRequestInstanceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceRequestSector?), TypeInfoPropertyName = "NullableCreateComputeInstanceRequestSector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelsStatus?), TypeInfoPropertyName = "NullableGetModelsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>?), TypeInfoPropertyName = "NullableAnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageTimeframe?), TypeInfoPropertyName = "NullableGetUsageTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetUsageBoundToTimeframe?), TypeInfoPropertyName = "NullableGetUsageBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsTimeframe?), TypeInfoPropertyName = "NullableGetAnalyticsTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAnalyticsBoundToTimeframe?), TypeInfoPropertyName = "NullableGetAnalyticsBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointStatus?), TypeInfoPropertyName = "NullableListRequestsByEndpointStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListRequestsByEndpointSortBy?), TypeInfoPropertyName = "NullableListRequestsByEndpointSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsMediaTypeItem?), TypeInfoPropertyName = "NullableListAssetsMediaTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsSourceItem?), TypeInfoPropertyName = "NullableListAssetsSourceItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsSection?), TypeInfoPropertyName = "NullableListAssetsSection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsTagMode?), TypeInfoPropertyName = "NullableListAssetsTagMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsMediaTypeItem?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsMediaTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsSourceItem?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsSourceItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsSection?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsSection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsTagMode?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsTagMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportSource?), TypeInfoPropertyName = "NullableGetFocusReportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportExpand?), TypeInfoPropertyName = "NullableGetFocusReportExpand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportTimeframe?), TypeInfoPropertyName = "NullableGetFocusReportTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportBoundToTimeframe?), TypeInfoPropertyName = "NullableGetFocusReportBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportSource?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportTimeframe?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportBoundToTimeframe?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageTimeframe?), TypeInfoPropertyName = "NullableGetOrganizationUsageTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageBoundToTimeframe?), TypeInfoPropertyName = "NullableGetOrganizationUsageBoundToTimeframe2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseErrorType?), TypeInfoPropertyName = "NullableListWorkflowsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseErrorType2?), TypeInfoPropertyName = "NullableListWorkflowsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseErrorType3?), TypeInfoPropertyName = "NullableListWorkflowsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListWorkflowsResponseErrorType4?), TypeInfoPropertyName = "NullableListWorkflowsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseErrorType?), TypeInfoPropertyName = "NullableCreateWorkflowResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseErrorType2?), TypeInfoPropertyName = "NullableCreateWorkflowResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseErrorType3?), TypeInfoPropertyName = "NullableCreateWorkflowResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseErrorType4?), TypeInfoPropertyName = "NullableCreateWorkflowResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowResponseErrorType5?), TypeInfoPropertyName = "NullableCreateWorkflowResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType?), TypeInfoPropertyName = "NullableGetWorkflowResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType2?), TypeInfoPropertyName = "NullableGetWorkflowResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType3?), TypeInfoPropertyName = "NullableGetWorkflowResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType4?), TypeInfoPropertyName = "NullableGetWorkflowResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType5?), TypeInfoPropertyName = "NullableGetWorkflowResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetWorkflowResponseErrorType6?), TypeInfoPropertyName = "NullableGetWorkflowResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseAssetType?), TypeInfoPropertyName = "NullableListAssetsResponseAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType?), TypeInfoPropertyName = "NullableListAssetsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType2?), TypeInfoPropertyName = "NullableListAssetsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType3?), TypeInfoPropertyName = "NullableListAssetsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType4?), TypeInfoPropertyName = "NullableListAssetsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType5?), TypeInfoPropertyName = "NullableListAssetsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType6?), TypeInfoPropertyName = "NullableListAssetsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType7?), TypeInfoPropertyName = "NullableListAssetsResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType8?), TypeInfoPropertyName = "NullableListAssetsResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetsResponseErrorType9?), TypeInfoPropertyName = "NullableListAssetsResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseCollectionType?), TypeInfoPropertyName = "NullableListAssetCollectionsResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType?), TypeInfoPropertyName = "NullableListAssetCollectionsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType2?), TypeInfoPropertyName = "NullableListAssetCollectionsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType3?), TypeInfoPropertyName = "NullableListAssetCollectionsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType4?), TypeInfoPropertyName = "NullableListAssetCollectionsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType5?), TypeInfoPropertyName = "NullableListAssetCollectionsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType6?), TypeInfoPropertyName = "NullableListAssetCollectionsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType7?), TypeInfoPropertyName = "NullableListAssetCollectionsResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType8?), TypeInfoPropertyName = "NullableListAssetCollectionsResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionsResponseErrorType9?), TypeInfoPropertyName = "NullableListAssetCollectionsResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseCollectionType?), TypeInfoPropertyName = "NullableCreateAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType?), TypeInfoPropertyName = "NullableCreateAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType2?), TypeInfoPropertyName = "NullableCreateAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType3?), TypeInfoPropertyName = "NullableCreateAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType4?), TypeInfoPropertyName = "NullableCreateAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType5?), TypeInfoPropertyName = "NullableCreateAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType6?), TypeInfoPropertyName = "NullableCreateAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType7?), TypeInfoPropertyName = "NullableCreateAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType8?), TypeInfoPropertyName = "NullableCreateAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCollectionResponseErrorType9?), TypeInfoPropertyName = "NullableCreateAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseCollectionType?), TypeInfoPropertyName = "NullableGetAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType?), TypeInfoPropertyName = "NullableGetAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType2?), TypeInfoPropertyName = "NullableGetAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType3?), TypeInfoPropertyName = "NullableGetAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType4?), TypeInfoPropertyName = "NullableGetAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType5?), TypeInfoPropertyName = "NullableGetAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType6?), TypeInfoPropertyName = "NullableGetAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType7?), TypeInfoPropertyName = "NullableGetAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType8?), TypeInfoPropertyName = "NullableGetAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionResponseErrorType9?), TypeInfoPropertyName = "NullableGetAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseCollectionType?), TypeInfoPropertyName = "NullableUpdateAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType?), TypeInfoPropertyName = "NullableUpdateAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType2?), TypeInfoPropertyName = "NullableUpdateAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType3?), TypeInfoPropertyName = "NullableUpdateAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType4?), TypeInfoPropertyName = "NullableUpdateAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType5?), TypeInfoPropertyName = "NullableUpdateAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType6?), TypeInfoPropertyName = "NullableUpdateAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType7?), TypeInfoPropertyName = "NullableUpdateAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType8?), TypeInfoPropertyName = "NullableUpdateAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCollectionResponseErrorType9?), TypeInfoPropertyName = "NullableUpdateAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType?), TypeInfoPropertyName = "NullableDeleteAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType2?), TypeInfoPropertyName = "NullableDeleteAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType3?), TypeInfoPropertyName = "NullableDeleteAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType4?), TypeInfoPropertyName = "NullableDeleteAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType5?), TypeInfoPropertyName = "NullableDeleteAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType6?), TypeInfoPropertyName = "NullableDeleteAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType7?), TypeInfoPropertyName = "NullableDeleteAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType8?), TypeInfoPropertyName = "NullableDeleteAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCollectionResponseErrorType9?), TypeInfoPropertyName = "NullableDeleteAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyType?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseHierarchyType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemType?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseHierarchyChildrenItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseAncestorType?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseAncestorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType2?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType3?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType4?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType5?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType6?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType7?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType8?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType9?), TypeInfoPropertyName = "NullableGetAssetCollectionHierarchyResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseCollectionType?), TypeInfoPropertyName = "NullableFavoriteAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType?), TypeInfoPropertyName = "NullableFavoriteAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType2?), TypeInfoPropertyName = "NullableFavoriteAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType3?), TypeInfoPropertyName = "NullableFavoriteAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType4?), TypeInfoPropertyName = "NullableFavoriteAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType5?), TypeInfoPropertyName = "NullableFavoriteAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType6?), TypeInfoPropertyName = "NullableFavoriteAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType7?), TypeInfoPropertyName = "NullableFavoriteAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType8?), TypeInfoPropertyName = "NullableFavoriteAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCollectionResponseErrorType9?), TypeInfoPropertyName = "NullableFavoriteAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseCollectionType?), TypeInfoPropertyName = "NullableUnfavoriteAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType?), TypeInfoPropertyName = "NullableUnfavoriteAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType2?), TypeInfoPropertyName = "NullableUnfavoriteAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType3?), TypeInfoPropertyName = "NullableUnfavoriteAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType4?), TypeInfoPropertyName = "NullableUnfavoriteAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType5?), TypeInfoPropertyName = "NullableUnfavoriteAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType6?), TypeInfoPropertyName = "NullableUnfavoriteAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType7?), TypeInfoPropertyName = "NullableUnfavoriteAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType8?), TypeInfoPropertyName = "NullableUnfavoriteAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType9?), TypeInfoPropertyName = "NullableUnfavoriteAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseCollectionType?), TypeInfoPropertyName = "NullableMoveAssetCollectionResponseCollectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType?), TypeInfoPropertyName = "NullableMoveAssetCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType2?), TypeInfoPropertyName = "NullableMoveAssetCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType3?), TypeInfoPropertyName = "NullableMoveAssetCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType4?), TypeInfoPropertyName = "NullableMoveAssetCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType5?), TypeInfoPropertyName = "NullableMoveAssetCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType6?), TypeInfoPropertyName = "NullableMoveAssetCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType7?), TypeInfoPropertyName = "NullableMoveAssetCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType8?), TypeInfoPropertyName = "NullableMoveAssetCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.MoveAssetCollectionResponseErrorType9?), TypeInfoPropertyName = "NullableMoveAssetCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseAssetType?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsResponseAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType2?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType3?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType4?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType5?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType6?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType7?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType8?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType9?), TypeInfoPropertyName = "NullableListAssetCollectionAssetsResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType?), TypeInfoPropertyName = "NullableAddAssetToCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType2?), TypeInfoPropertyName = "NullableAddAssetToCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType3?), TypeInfoPropertyName = "NullableAddAssetToCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType4?), TypeInfoPropertyName = "NullableAddAssetToCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType5?), TypeInfoPropertyName = "NullableAddAssetToCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType6?), TypeInfoPropertyName = "NullableAddAssetToCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType7?), TypeInfoPropertyName = "NullableAddAssetToCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType8?), TypeInfoPropertyName = "NullableAddAssetToCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AddAssetToCollectionResponseErrorType9?), TypeInfoPropertyName = "NullableAddAssetToCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType?), TypeInfoPropertyName = "NullableRemoveAssetFromCollectionResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType2?), TypeInfoPropertyName = "NullableRemoveAssetFromCollectionResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType3?), TypeInfoPropertyName = "NullableRemoveAssetFromCollectionResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType4?), TypeInfoPropertyName = "NullableRemoveAssetFromCollectionResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType5?), TypeInfoPropertyName = "NullableRemoveAssetFromCollectionResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType6?), TypeInfoPropertyName = "NullableRemoveAssetFromCollectionResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType7?), TypeInfoPropertyName = "NullableRemoveAssetFromCollectionResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType8?), TypeInfoPropertyName = "NullableRemoveAssetFromCollectionResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType9?), TypeInfoPropertyName = "NullableRemoveAssetFromCollectionResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseCharacterType?), TypeInfoPropertyName = "NullableListAssetCharactersResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType?), TypeInfoPropertyName = "NullableListAssetCharactersResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType2?), TypeInfoPropertyName = "NullableListAssetCharactersResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType3?), TypeInfoPropertyName = "NullableListAssetCharactersResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType4?), TypeInfoPropertyName = "NullableListAssetCharactersResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType5?), TypeInfoPropertyName = "NullableListAssetCharactersResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType6?), TypeInfoPropertyName = "NullableListAssetCharactersResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType7?), TypeInfoPropertyName = "NullableListAssetCharactersResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType8?), TypeInfoPropertyName = "NullableListAssetCharactersResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetCharactersResponseErrorType9?), TypeInfoPropertyName = "NullableListAssetCharactersResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseCharacterType?), TypeInfoPropertyName = "NullableCreateAssetCharacterResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType?), TypeInfoPropertyName = "NullableCreateAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType2?), TypeInfoPropertyName = "NullableCreateAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType3?), TypeInfoPropertyName = "NullableCreateAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType4?), TypeInfoPropertyName = "NullableCreateAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType5?), TypeInfoPropertyName = "NullableCreateAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType6?), TypeInfoPropertyName = "NullableCreateAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType7?), TypeInfoPropertyName = "NullableCreateAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType8?), TypeInfoPropertyName = "NullableCreateAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetCharacterResponseErrorType9?), TypeInfoPropertyName = "NullableCreateAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseCharacterType?), TypeInfoPropertyName = "NullableUpdateAssetCharacterResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType?), TypeInfoPropertyName = "NullableUpdateAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType2?), TypeInfoPropertyName = "NullableUpdateAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType3?), TypeInfoPropertyName = "NullableUpdateAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType4?), TypeInfoPropertyName = "NullableUpdateAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType5?), TypeInfoPropertyName = "NullableUpdateAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType6?), TypeInfoPropertyName = "NullableUpdateAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType7?), TypeInfoPropertyName = "NullableUpdateAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType8?), TypeInfoPropertyName = "NullableUpdateAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetCharacterResponseErrorType9?), TypeInfoPropertyName = "NullableUpdateAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseCharacterType?), TypeInfoPropertyName = "NullableGetAssetCharacterResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType?), TypeInfoPropertyName = "NullableGetAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType2?), TypeInfoPropertyName = "NullableGetAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType3?), TypeInfoPropertyName = "NullableGetAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType4?), TypeInfoPropertyName = "NullableGetAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType5?), TypeInfoPropertyName = "NullableGetAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType6?), TypeInfoPropertyName = "NullableGetAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType7?), TypeInfoPropertyName = "NullableGetAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType8?), TypeInfoPropertyName = "NullableGetAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetCharacterResponseErrorType9?), TypeInfoPropertyName = "NullableGetAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType?), TypeInfoPropertyName = "NullableDeleteAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType2?), TypeInfoPropertyName = "NullableDeleteAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType3?), TypeInfoPropertyName = "NullableDeleteAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType4?), TypeInfoPropertyName = "NullableDeleteAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType5?), TypeInfoPropertyName = "NullableDeleteAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType6?), TypeInfoPropertyName = "NullableDeleteAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType7?), TypeInfoPropertyName = "NullableDeleteAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType8?), TypeInfoPropertyName = "NullableDeleteAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetCharacterResponseErrorType9?), TypeInfoPropertyName = "NullableDeleteAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseCharacterType?), TypeInfoPropertyName = "NullableFavoriteAssetCharacterResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType?), TypeInfoPropertyName = "NullableFavoriteAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType2?), TypeInfoPropertyName = "NullableFavoriteAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType3?), TypeInfoPropertyName = "NullableFavoriteAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType4?), TypeInfoPropertyName = "NullableFavoriteAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType5?), TypeInfoPropertyName = "NullableFavoriteAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType6?), TypeInfoPropertyName = "NullableFavoriteAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType7?), TypeInfoPropertyName = "NullableFavoriteAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType8?), TypeInfoPropertyName = "NullableFavoriteAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetCharacterResponseErrorType9?), TypeInfoPropertyName = "NullableFavoriteAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseCharacterType?), TypeInfoPropertyName = "NullableUnfavoriteAssetCharacterResponseCharacterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType?), TypeInfoPropertyName = "NullableUnfavoriteAssetCharacterResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType2?), TypeInfoPropertyName = "NullableUnfavoriteAssetCharacterResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType3?), TypeInfoPropertyName = "NullableUnfavoriteAssetCharacterResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType4?), TypeInfoPropertyName = "NullableUnfavoriteAssetCharacterResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType5?), TypeInfoPropertyName = "NullableUnfavoriteAssetCharacterResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType6?), TypeInfoPropertyName = "NullableUnfavoriteAssetCharacterResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType7?), TypeInfoPropertyName = "NullableUnfavoriteAssetCharacterResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType8?), TypeInfoPropertyName = "NullableUnfavoriteAssetCharacterResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType9?), TypeInfoPropertyName = "NullableUnfavoriteAssetCharacterResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType?), TypeInfoPropertyName = "NullableListAssetTagsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType2?), TypeInfoPropertyName = "NullableListAssetTagsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType3?), TypeInfoPropertyName = "NullableListAssetTagsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType4?), TypeInfoPropertyName = "NullableListAssetTagsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType5?), TypeInfoPropertyName = "NullableListAssetTagsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType6?), TypeInfoPropertyName = "NullableListAssetTagsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType7?), TypeInfoPropertyName = "NullableListAssetTagsResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType8?), TypeInfoPropertyName = "NullableListAssetTagsResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsResponseErrorType9?), TypeInfoPropertyName = "NullableListAssetTagsResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType?), TypeInfoPropertyName = "NullableCreateAssetTagResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType2?), TypeInfoPropertyName = "NullableCreateAssetTagResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType3?), TypeInfoPropertyName = "NullableCreateAssetTagResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType4?), TypeInfoPropertyName = "NullableCreateAssetTagResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType5?), TypeInfoPropertyName = "NullableCreateAssetTagResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType6?), TypeInfoPropertyName = "NullableCreateAssetTagResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType7?), TypeInfoPropertyName = "NullableCreateAssetTagResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType8?), TypeInfoPropertyName = "NullableCreateAssetTagResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateAssetTagResponseErrorType9?), TypeInfoPropertyName = "NullableCreateAssetTagResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType?), TypeInfoPropertyName = "NullableSetAssetTagsForAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType2?), TypeInfoPropertyName = "NullableSetAssetTagsForAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType3?), TypeInfoPropertyName = "NullableSetAssetTagsForAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType4?), TypeInfoPropertyName = "NullableSetAssetTagsForAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType5?), TypeInfoPropertyName = "NullableSetAssetTagsForAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType6?), TypeInfoPropertyName = "NullableSetAssetTagsForAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType7?), TypeInfoPropertyName = "NullableSetAssetTagsForAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType8?), TypeInfoPropertyName = "NullableSetAssetTagsForAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetAssetTagsForAssetResponseErrorType9?), TypeInfoPropertyName = "NullableSetAssetTagsForAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType?), TypeInfoPropertyName = "NullableUpdateAssetTagResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType2?), TypeInfoPropertyName = "NullableUpdateAssetTagResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType3?), TypeInfoPropertyName = "NullableUpdateAssetTagResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType4?), TypeInfoPropertyName = "NullableUpdateAssetTagResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType5?), TypeInfoPropertyName = "NullableUpdateAssetTagResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType6?), TypeInfoPropertyName = "NullableUpdateAssetTagResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType7?), TypeInfoPropertyName = "NullableUpdateAssetTagResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType8?), TypeInfoPropertyName = "NullableUpdateAssetTagResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateAssetTagResponseErrorType9?), TypeInfoPropertyName = "NullableUpdateAssetTagResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType?), TypeInfoPropertyName = "NullableDeleteAssetTagResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType2?), TypeInfoPropertyName = "NullableDeleteAssetTagResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType3?), TypeInfoPropertyName = "NullableDeleteAssetTagResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType4?), TypeInfoPropertyName = "NullableDeleteAssetTagResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType5?), TypeInfoPropertyName = "NullableDeleteAssetTagResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType6?), TypeInfoPropertyName = "NullableDeleteAssetTagResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType7?), TypeInfoPropertyName = "NullableDeleteAssetTagResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType8?), TypeInfoPropertyName = "NullableDeleteAssetTagResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteAssetTagResponseErrorType9?), TypeInfoPropertyName = "NullableDeleteAssetTagResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseAssetType?), TypeInfoPropertyName = "NullableUploadAssetResponseAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType?), TypeInfoPropertyName = "NullableUploadAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType2?), TypeInfoPropertyName = "NullableUploadAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType3?), TypeInfoPropertyName = "NullableUploadAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType4?), TypeInfoPropertyName = "NullableUploadAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType5?), TypeInfoPropertyName = "NullableUploadAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType6?), TypeInfoPropertyName = "NullableUploadAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType7?), TypeInfoPropertyName = "NullableUploadAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType8?), TypeInfoPropertyName = "NullableUploadAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UploadAssetResponseErrorType9?), TypeInfoPropertyName = "NullableUploadAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseAssetType?), TypeInfoPropertyName = "NullableGetAssetResponseAssetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType?), TypeInfoPropertyName = "NullableGetAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType2?), TypeInfoPropertyName = "NullableGetAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType3?), TypeInfoPropertyName = "NullableGetAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType4?), TypeInfoPropertyName = "NullableGetAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType5?), TypeInfoPropertyName = "NullableGetAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType6?), TypeInfoPropertyName = "NullableGetAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType7?), TypeInfoPropertyName = "NullableGetAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType8?), TypeInfoPropertyName = "NullableGetAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetResponseErrorType9?), TypeInfoPropertyName = "NullableGetAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Kind?), TypeInfoPropertyName = "NullableGetAssetLineageResponseLineageNodeVariant1Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Type?), TypeInfoPropertyName = "NullableGetAssetLineageResponseLineageNodeVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant2Kind?), TypeInfoPropertyName = "NullableGetAssetLineageResponseLineageNodeVariant2Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant3Kind?), TypeInfoPropertyName = "NullableGetAssetLineageResponseLineageNodeVariant3Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4Kind?), TypeInfoPropertyName = "NullableGetAssetLineageResponseLineageNodeVariant4Kind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4EntityType?), TypeInfoPropertyName = "NullableGetAssetLineageResponseLineageNodeVariant4EntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageEdgeKind?), TypeInfoPropertyName = "NullableGetAssetLineageResponseLineageEdgeKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.GetAssetLineageResponseLineageEdgeRole?, object, object>?), TypeInfoPropertyName = "NullableAnyOfGetAssetLineageResponseLineageEdgeRoleObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageEdgeRole?), TypeInfoPropertyName = "NullableGetAssetLineageResponseLineageEdgeRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseLineageEdgeEntitieEntityType?), TypeInfoPropertyName = "NullableGetAssetLineageResponseLineageEdgeEntitieEntityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType?), TypeInfoPropertyName = "NullableGetAssetLineageResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType2?), TypeInfoPropertyName = "NullableGetAssetLineageResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType3?), TypeInfoPropertyName = "NullableGetAssetLineageResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType4?), TypeInfoPropertyName = "NullableGetAssetLineageResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType5?), TypeInfoPropertyName = "NullableGetAssetLineageResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType6?), TypeInfoPropertyName = "NullableGetAssetLineageResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType7?), TypeInfoPropertyName = "NullableGetAssetLineageResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType8?), TypeInfoPropertyName = "NullableGetAssetLineageResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAssetLineageResponseErrorType9?), TypeInfoPropertyName = "NullableGetAssetLineageResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType?), TypeInfoPropertyName = "NullableFavoriteAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType2?), TypeInfoPropertyName = "NullableFavoriteAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType3?), TypeInfoPropertyName = "NullableFavoriteAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType4?), TypeInfoPropertyName = "NullableFavoriteAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType5?), TypeInfoPropertyName = "NullableFavoriteAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType6?), TypeInfoPropertyName = "NullableFavoriteAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType7?), TypeInfoPropertyName = "NullableFavoriteAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType8?), TypeInfoPropertyName = "NullableFavoriteAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.FavoriteAssetResponseErrorType9?), TypeInfoPropertyName = "NullableFavoriteAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType?), TypeInfoPropertyName = "NullableUnfavoriteAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType2?), TypeInfoPropertyName = "NullableUnfavoriteAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType3?), TypeInfoPropertyName = "NullableUnfavoriteAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType4?), TypeInfoPropertyName = "NullableUnfavoriteAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType5?), TypeInfoPropertyName = "NullableUnfavoriteAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType6?), TypeInfoPropertyName = "NullableUnfavoriteAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType7?), TypeInfoPropertyName = "NullableUnfavoriteAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType8?), TypeInfoPropertyName = "NullableUnfavoriteAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnfavoriteAssetResponseErrorType9?), TypeInfoPropertyName = "NullableUnfavoriteAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType?), TypeInfoPropertyName = "NullableListAssetTagsForAssetResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType2?), TypeInfoPropertyName = "NullableListAssetTagsForAssetResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType3?), TypeInfoPropertyName = "NullableListAssetTagsForAssetResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType4?), TypeInfoPropertyName = "NullableListAssetTagsForAssetResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType5?), TypeInfoPropertyName = "NullableListAssetTagsForAssetResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType6?), TypeInfoPropertyName = "NullableListAssetTagsForAssetResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType7?), TypeInfoPropertyName = "NullableListAssetTagsForAssetResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType8?), TypeInfoPropertyName = "NullableListAssetTagsForAssetResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListAssetTagsForAssetResponseErrorType9?), TypeInfoPropertyName = "NullableListAssetTagsForAssetResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType?), TypeInfoPropertyName = "NullableAssignAssetTagResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType2?), TypeInfoPropertyName = "NullableAssignAssetTagResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType3?), TypeInfoPropertyName = "NullableAssignAssetTagResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType4?), TypeInfoPropertyName = "NullableAssignAssetTagResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType5?), TypeInfoPropertyName = "NullableAssignAssetTagResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType6?), TypeInfoPropertyName = "NullableAssignAssetTagResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType7?), TypeInfoPropertyName = "NullableAssignAssetTagResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType8?), TypeInfoPropertyName = "NullableAssignAssetTagResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AssignAssetTagResponseErrorType9?), TypeInfoPropertyName = "NullableAssignAssetTagResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType?), TypeInfoPropertyName = "NullableUnassignAssetTagResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType2?), TypeInfoPropertyName = "NullableUnassignAssetTagResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType3?), TypeInfoPropertyName = "NullableUnassignAssetTagResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType4?), TypeInfoPropertyName = "NullableUnassignAssetTagResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType5?), TypeInfoPropertyName = "NullableUnassignAssetTagResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType6?), TypeInfoPropertyName = "NullableUnassignAssetTagResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType7?), TypeInfoPropertyName = "NullableUnassignAssetTagResponseErrorType72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType8?), TypeInfoPropertyName = "NullableUnassignAssetTagResponseErrorType82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UnassignAssetTagResponseErrorType9?), TypeInfoPropertyName = "NullableUnassignAssetTagResponseErrorType92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseDefault?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseRuleDecision?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType2?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType3?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType4?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType5?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType6?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseDefault?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseRuleDecision?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType2?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType3?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType4?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType5?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType6?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType2?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType3?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType4?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType5?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType6?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseInitialAclRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType2?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType3?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseErrorType32")]
    internal sealed partial class SourceGenerationContextChunk4 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_8df3f0ff85c28fa0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_4af0049b8319fe25")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>?), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_fc90b6f0c4769996")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.OneOf<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>>), TypeInfoPropertyName = "GetAssetLineageResponseLineageNodeVariant4_898695ff2bd5345d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType4?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseInitialAclRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType2?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType3?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType4?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType5?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseErrorType52")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceInstanceType?), TypeInfoPropertyName = "NullableListComputeInstancesResponseInstanceInstanceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceRegion?), TypeInfoPropertyName = "NullableListComputeInstancesResponseInstanceRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceSector?), TypeInfoPropertyName = "NullableListComputeInstancesResponseInstanceSector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceStatus?), TypeInfoPropertyName = "NullableListComputeInstancesResponseInstanceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType?), TypeInfoPropertyName = "NullableListComputeInstancesResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType2?), TypeInfoPropertyName = "NullableListComputeInstancesResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType3?), TypeInfoPropertyName = "NullableListComputeInstancesResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType4?), TypeInfoPropertyName = "NullableListComputeInstancesResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseInstanceType?), TypeInfoPropertyName = "NullableCreateComputeInstanceResponseInstanceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseRegion?), TypeInfoPropertyName = "NullableCreateComputeInstanceResponseRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseSector?), TypeInfoPropertyName = "NullableCreateComputeInstanceResponseSector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseStatus?), TypeInfoPropertyName = "NullableCreateComputeInstanceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseErrorType?), TypeInfoPropertyName = "NullableCreateComputeInstanceResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseErrorType2?), TypeInfoPropertyName = "NullableCreateComputeInstanceResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseErrorType3?), TypeInfoPropertyName = "NullableCreateComputeInstanceResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseErrorType4?), TypeInfoPropertyName = "NullableCreateComputeInstanceResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateComputeInstanceResponseErrorType5?), TypeInfoPropertyName = "NullableCreateComputeInstanceResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseInstanceType?), TypeInfoPropertyName = "NullableGetComputeInstanceResponseInstanceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseRegion?), TypeInfoPropertyName = "NullableGetComputeInstanceResponseRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseSector?), TypeInfoPropertyName = "NullableGetComputeInstanceResponseSector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseStatus?), TypeInfoPropertyName = "NullableGetComputeInstanceResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseErrorType?), TypeInfoPropertyName = "NullableGetComputeInstanceResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseErrorType2?), TypeInfoPropertyName = "NullableGetComputeInstanceResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseErrorType3?), TypeInfoPropertyName = "NullableGetComputeInstanceResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseErrorType4?), TypeInfoPropertyName = "NullableGetComputeInstanceResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetComputeInstanceResponseErrorType5?), TypeInfoPropertyName = "NullableGetComputeInstanceResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseErrorType?), TypeInfoPropertyName = "NullableDeleteComputeInstanceResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseErrorType2?), TypeInfoPropertyName = "NullableDeleteComputeInstanceResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseErrorType3?), TypeInfoPropertyName = "NullableDeleteComputeInstanceResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseErrorType4?), TypeInfoPropertyName = "NullableDeleteComputeInstanceResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteComputeInstanceResponseErrorType5?), TypeInfoPropertyName = "NullableDeleteComputeInstanceResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseKeyScope?), TypeInfoPropertyName = "NullableListApiKeysResponseKeyScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseErrorType?), TypeInfoPropertyName = "NullableListApiKeysResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseErrorType2?), TypeInfoPropertyName = "NullableListApiKeysResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseErrorType3?), TypeInfoPropertyName = "NullableListApiKeysResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListApiKeysResponseErrorType4?), TypeInfoPropertyName = "NullableListApiKeysResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseErrorType?), TypeInfoPropertyName = "NullableCreateApiKeyResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseErrorType2?), TypeInfoPropertyName = "NullableCreateApiKeyResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseErrorType3?), TypeInfoPropertyName = "NullableCreateApiKeyResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseErrorType4?), TypeInfoPropertyName = "NullableCreateApiKeyResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyResponseErrorType5?), TypeInfoPropertyName = "NullableCreateApiKeyResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseErrorType?), TypeInfoPropertyName = "NullableDeleteApiKeyResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseErrorType2?), TypeInfoPropertyName = "NullableDeleteApiKeyResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseErrorType3?), TypeInfoPropertyName = "NullableDeleteApiKeyResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.DeleteApiKeyResponseErrorType4?), TypeInfoPropertyName = "NullableDeleteApiKeyResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseErrorType?), TypeInfoPropertyName = "NullableGetAccountBillingResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseErrorType2?), TypeInfoPropertyName = "NullableGetAccountBillingResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseErrorType3?), TypeInfoPropertyName = "NullableGetAccountBillingResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseErrorType4?), TypeInfoPropertyName = "NullableGetAccountBillingResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetAccountBillingResponseErrorType5?), TypeInfoPropertyName = "NullableGetAccountBillingResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseErrorType?), TypeInfoPropertyName = "NullableGetFocusReportResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseErrorType2?), TypeInfoPropertyName = "NullableGetFocusReportResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseErrorType3?), TypeInfoPropertyName = "NullableGetFocusReportResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseErrorType4?), TypeInfoPropertyName = "NullableGetFocusReportResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportResponseErrorType5?), TypeInfoPropertyName = "NullableGetFocusReportResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseErrorType?), TypeInfoPropertyName = "NullableGetModelAccessControlsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseErrorType2?), TypeInfoPropertyName = "NullableGetModelAccessControlsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseErrorType3?), TypeInfoPropertyName = "NullableGetModelAccessControlsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetModelAccessControlsResponseErrorType4?), TypeInfoPropertyName = "NullableGetModelAccessControlsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType?), TypeInfoPropertyName = "NullableGetOrganizationBillingEventsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType2?), TypeInfoPropertyName = "NullableGetOrganizationBillingEventsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType3?), TypeInfoPropertyName = "NullableGetOrganizationBillingEventsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType4?), TypeInfoPropertyName = "NullableGetOrganizationBillingEventsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType5?), TypeInfoPropertyName = "NullableGetOrganizationBillingEventsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType6?), TypeInfoPropertyName = "NullableGetOrganizationBillingEventsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType2?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType3?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType4?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType5?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportResponseErrorType6?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType?), TypeInfoPropertyName = "NullableGetOrganizationTeamsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType2?), TypeInfoPropertyName = "NullableGetOrganizationTeamsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType3?), TypeInfoPropertyName = "NullableGetOrganizationTeamsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType4?), TypeInfoPropertyName = "NullableGetOrganizationTeamsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType5?), TypeInfoPropertyName = "NullableGetOrganizationTeamsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationTeamsResponseErrorType6?), TypeInfoPropertyName = "NullableGetOrganizationTeamsResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseTimeSerieResultProduct?), TypeInfoPropertyName = "NullableGetOrganizationUsageResponseTimeSerieResultProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseSummaryItemProduct?), TypeInfoPropertyName = "NullableGetOrganizationUsageResponseSummaryItemProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType?), TypeInfoPropertyName = "NullableGetOrganizationUsageResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType2?), TypeInfoPropertyName = "NullableGetOrganizationUsageResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType3?), TypeInfoPropertyName = "NullableGetOrganizationUsageResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType4?), TypeInfoPropertyName = "NullableGetOrganizationUsageResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType5?), TypeInfoPropertyName = "NullableGetOrganizationUsageResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageResponseErrorType6?), TypeInfoPropertyName = "NullableGetOrganizationUsageResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponseErrorType?), TypeInfoPropertyName = "NullableGetMetaResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetMetaResponseErrorType2?), TypeInfoPropertyName = "NullableGetMetaResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.SetStorageFileAclRequestRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.UpdateStorageSettingsRequestInitialAclRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessLogsHistoryRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessLogsStreamRequestItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetsMediaTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetsSourceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetCollectionAssetsMediaTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetCollectionAssetsSourceItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::Fal.ServerlessListAppEventsCategory2?, global::System.Collections.Generic.List<global::Fal.ServerlessListAppEventsCategoryItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ServerlessListAppEventsCategoryItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAssetCollectionHierarchyResponseAncestor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetCollectionAssetsResponseAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetCollectionAssetsResponseAssetTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetCharactersResponseCharacter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetTagsResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.SetAssetTagsForAssetResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.UploadAssetResponseAssetTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAssetResponseAssetTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAssetLineageResponseLineageEdge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetAssetLineageResponseLineageEdgeEntitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListAssetTagsForAssetResponseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetStorageFileAclResponseRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.SetStorageFileAclResponseRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetStorageSettingsResponseInitialAclRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.UpdateStorageSettingsResponseInitialAclRule>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListComputeInstancesResponseInstance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListApiKeysResponseKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationBillingEventsResponseBillingEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationTeamsResponseTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationUsageResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationUsageResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationUsageResponseSummaryItem>))]
    internal sealed partial class SourceGenerationContextChunk5 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

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
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>());
            options.Converters.Add(new global::Fal.JsonConverters.OneOfJsonConverter<global::Fal.GetAssetLineageResponseLineageNodeVariant1, global::Fal.GetAssetLineageResponseLineageNodeVariant2, global::Fal.GetAssetLineageResponseLineageNodeVariant3, global::Fal.GetAssetLineageResponseLineageNodeVariant4>());
            options.Converters.Add(new global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetAssetLineageResponseLineageEdgeRole?, object, object>());
            options.Converters.Add(new global::Fal.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

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

                    || typeToConvert == typeof(global::Fal.UploadAssetRequestType)

                    || typeToConvert == typeof(global::Fal.UploadAssetRequestType?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclRequestDefault)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclRequestDefault?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclRequestRuleDecision)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclRequestRuleDecision?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryRequestItemConditionType)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsHistoryRequestItemConditionType?)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamRequestItemConditionType)

                    || typeToConvert == typeof(global::Fal.ServerlessLogsStreamRequestItemConditionType?)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceRequestInstanceType)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceRequestInstanceType?)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceRequestSector)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceRequestSector?)

                    || typeToConvert == typeof(global::Fal.GetModelsStatus)

                    || typeToConvert == typeof(global::Fal.GetModelsStatus?)

                    || typeToConvert == typeof(global::Fal.GetUsageTimeframe)

                    || typeToConvert == typeof(global::Fal.GetUsageTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetUsageBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.GetUsageBoundToTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsTimeframe)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.GetAnalyticsBoundToTimeframe?)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointStatus)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointStatus?)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointSortBy)

                    || typeToConvert == typeof(global::Fal.ListRequestsByEndpointSortBy?)

                    || typeToConvert == typeof(global::Fal.ListAssetsMediaTypeItem)

                    || typeToConvert == typeof(global::Fal.ListAssetsMediaTypeItem?)

                    || typeToConvert == typeof(global::Fal.ListAssetsSourceItem)

                    || typeToConvert == typeof(global::Fal.ListAssetsSourceItem?)

                    || typeToConvert == typeof(global::Fal.ListAssetsSection)

                    || typeToConvert == typeof(global::Fal.ListAssetsSection?)

                    || typeToConvert == typeof(global::Fal.ListAssetsTagMode)

                    || typeToConvert == typeof(global::Fal.ListAssetsTagMode?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsMediaTypeItem)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsMediaTypeItem?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsSourceItem)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsSourceItem?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsSection)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsSection?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsTagMode)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsTagMode?)

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

                    || typeToConvert == typeof(global::Fal.GetFocusReportSource)

                    || typeToConvert == typeof(global::Fal.GetFocusReportSource?)

                    || typeToConvert == typeof(global::Fal.GetFocusReportExpand)

                    || typeToConvert == typeof(global::Fal.GetFocusReportExpand?)

                    || typeToConvert == typeof(global::Fal.GetFocusReportTimeframe)

                    || typeToConvert == typeof(global::Fal.GetFocusReportTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetFocusReportBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.GetFocusReportBoundToTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportSource)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportSource?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportTimeframe)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportBoundToTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageTimeframe)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageBoundToTimeframe?)

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

                    || typeToConvert == typeof(global::Fal.SearchRequestsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType)

                    || typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseAssetType)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseAssetType?)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseCollectionType)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseCollectionType?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseCollectionType)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseCollectionType?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseCollectionType)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseCollectionType?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseCollectionType)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseCollectionType?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyType)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyType?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemType)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemType?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseAncestorType)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseAncestorType?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseCollectionType)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseCollectionType?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseCollectionType)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseCollectionType?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseCollectionType)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseCollectionType?)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseAssetType)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseAssetType?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseCharacterType)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseCharacterType?)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseCharacterType)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseCharacterType?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseCharacterType)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseCharacterType?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseCharacterType)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseCharacterType?)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseCharacterType)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseCharacterType?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseCharacterType)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseCharacterType?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseAssetType)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseAssetType?)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseAssetType)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseAssetType?)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.GetAssetResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Kind)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Kind?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Type)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Type?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant2Kind)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant2Kind?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant3Kind)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant3Kind?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4Kind)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4Kind?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4EntityType)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4EntityType?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeKind)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeKind?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeRole)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeRole?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeEntitieEntityType)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeEntitieEntityType?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType7)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType7?)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType8)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType8?)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType9)

                    || typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType9?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseDefault)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseDefault?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseRuleDecision)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseRuleDecision?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseDefault)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseDefault?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseRuleDecision)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseRuleDecision?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType5?)

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

                    || typeToConvert == typeof(global::Fal.ServerlessGetUsageResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceInstanceType)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceInstanceType?)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceRegion)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceRegion?)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceSector)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceSector?)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceStatus)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceStatus?)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseInstanceType)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseInstanceType?)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseRegion)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseRegion?)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseSector)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseSector?)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseStatus)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseStatus?)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseInstanceType)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseInstanceType?)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseRegion)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseRegion?)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseSector)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseSector?)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseStatus)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseStatus?)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType)

                    || typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.ListApiKeysResponseKeyScope)

                    || typeToConvert == typeof(global::Fal.ListApiKeysResponseKeyScope?)

                    || typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType)

                    || typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType)

                    || typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType)

                    || typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseTimeSerieResultProduct)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseTimeSerieResultProduct?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseSummaryItemProduct)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseSummaryItemProduct?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetMetaResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetMetaResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetMetaResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetMetaResponseErrorType2?);
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

                if (typeToConvert == typeof(global::Fal.UploadAssetRequestType))
                {
                    return new global::Fal.JsonConverters.UploadAssetRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetRequestType?))
                {
                    return new global::Fal.JsonConverters.UploadAssetRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclRequestDefault))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclRequestDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclRequestDefault?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclRequestDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclRequestRuleDecision))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclRequestRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclRequestRuleDecision?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclRequestRuleDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsRequestInitialAclDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsRequestInitialAclDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsRequestInitialAclRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsRequestInitialAclRuleDecisionNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceRequestInstanceType))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceRequestInstanceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceRequestInstanceType?))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceRequestInstanceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceRequestSector))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceRequestSectorJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceRequestSector?))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceRequestSectorNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Fal.ListAssetsMediaTypeItem))
                {
                    return new global::Fal.JsonConverters.ListAssetsMediaTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsMediaTypeItem?))
                {
                    return new global::Fal.JsonConverters.ListAssetsMediaTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsSourceItem))
                {
                    return new global::Fal.JsonConverters.ListAssetsSourceItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsSourceItem?))
                {
                    return new global::Fal.JsonConverters.ListAssetsSourceItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsSection))
                {
                    return new global::Fal.JsonConverters.ListAssetsSectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsSection?))
                {
                    return new global::Fal.JsonConverters.ListAssetsSectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsTagMode))
                {
                    return new global::Fal.JsonConverters.ListAssetsTagModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsTagMode?))
                {
                    return new global::Fal.JsonConverters.ListAssetsTagModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsMediaTypeItem))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsMediaTypeItem?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsMediaTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsSourceItem))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsSourceItem?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsSourceItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsSection))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsSectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsSection?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsSectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsTagMode))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsTagMode?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsTagModeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Fal.GetFocusReportSource))
                {
                    return new global::Fal.JsonConverters.GetFocusReportSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportSource?))
                {
                    return new global::Fal.JsonConverters.GetFocusReportSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportExpand))
                {
                    return new global::Fal.JsonConverters.GetFocusReportExpandJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportExpand?))
                {
                    return new global::Fal.JsonConverters.GetFocusReportExpandNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportTimeframe))
                {
                    return new global::Fal.JsonConverters.GetFocusReportTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportTimeframe?))
                {
                    return new global::Fal.JsonConverters.GetFocusReportTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportBoundToTimeframe))
                {
                    return new global::Fal.JsonConverters.GetFocusReportBoundToTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportBoundToTimeframe?))
                {
                    return new global::Fal.JsonConverters.GetFocusReportBoundToTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportSource))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportSource?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportTimeframe))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportTimeframe?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportBoundToTimeframe))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportBoundToTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportBoundToTimeframe?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportBoundToTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageTimeframe))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageTimeframe?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageTimeframeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageBoundToTimeframe))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageBoundToTimeframe?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageBoundToTimeframeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ListWorkflowsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ListWorkflowsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ListWorkflowsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ListWorkflowsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ListWorkflowsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ListWorkflowsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ListWorkflowsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ListWorkflowsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType))
                {
                    return new global::Fal.JsonConverters.CreateWorkflowResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.CreateWorkflowResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.CreateWorkflowResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.CreateWorkflowResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.CreateWorkflowResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.CreateWorkflowResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.CreateWorkflowResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.CreateWorkflowResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.CreateWorkflowResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateWorkflowResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.CreateWorkflowResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetWorkflowResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseAssetType))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseAssetType?))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetsResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.ListAssetsResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseCollectionType))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseCollectionType?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseCollectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionsResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionsResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseCollectionType))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseCollectionType?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseCollectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCollectionResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCollectionResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseCollectionType))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseCollectionType?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseCollectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseCollectionType))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseCollectionType?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseCollectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCollectionResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCollectionResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCollectionResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCollectionResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyType))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseHierarchyTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyType?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseHierarchyTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemType))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseHierarchyChildrenItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemType?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseHierarchyChildrenItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemType?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemType?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemType?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseHierarchyChildrenItemChildrenItemChildrenItemChildrenItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseAncestorType))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseAncestorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseAncestorType?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseAncestorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCollectionHierarchyResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.GetAssetCollectionHierarchyResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseCollectionType))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseCollectionType?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCollectionResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCollectionResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseCollectionType))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseCollectionType?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseCollectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCollectionResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCollectionResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseCollectionType))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseCollectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseCollectionType?))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseCollectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.MoveAssetCollectionResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.MoveAssetCollectionResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseAssetType))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseAssetType?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCollectionAssetsResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.ListAssetCollectionAssetsResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AddAssetToCollectionResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.AddAssetToCollectionResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.RemoveAssetFromCollectionResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.RemoveAssetFromCollectionResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseCharacterType))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseCharacterType?))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseCharacterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetCharactersResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.ListAssetCharactersResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseCharacterType))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseCharacterType?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseCharacterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetCharacterResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.CreateAssetCharacterResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseCharacterType))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseCharacterType?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseCharacterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetCharacterResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetCharacterResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseCharacterType))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseCharacterType?))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseCharacterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetCharacterResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.GetAssetCharacterResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetCharacterResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetCharacterResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseCharacterType))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseCharacterType?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetCharacterResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetCharacterResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseCharacterType))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseCharacterType?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseCharacterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetCharacterResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetCharacterResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateAssetTagResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.CreateAssetTagResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetAssetTagsForAssetResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.SetAssetTagsForAssetResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateAssetTagResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.UpdateAssetTagResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteAssetTagResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.DeleteAssetTagResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseAssetType))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseAssetType?))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UploadAssetResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.UploadAssetResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseAssetType))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseAssetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseAssetType?))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseAssetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.GetAssetResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Kind))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant1KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Kind?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant1KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Type))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant1Type?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant2Kind))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant2KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant2Kind?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant2KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant3Kind))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant3KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant3Kind?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant3KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4Kind))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant4KindJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4Kind?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant4KindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4EntityType))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant4EntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageNodeVariant4EntityType?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageNodeVariant4EntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeKind))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageEdgeKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeKind?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageEdgeKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeRole))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageEdgeRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeRole?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageEdgeRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeEntitieEntityType))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageEdgeEntitieEntityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseLineageEdgeEntitieEntityType?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseLineageEdgeEntitieEntityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAssetLineageResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.GetAssetLineageResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.FavoriteAssetResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.FavoriteAssetResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnfavoriteAssetResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.UnfavoriteAssetResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListAssetTagsForAssetResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.ListAssetTagsForAssetResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.AssignAssetTagResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.AssignAssetTagResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType7))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType7?))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType8))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType8?))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType9))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UnassignAssetTagResponseErrorType9?))
                {
                    return new global::Fal.JsonConverters.UnassignAssetTagResponseErrorType9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseDefault))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseDefault?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseRuleDecision))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseRuleDecision?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseRuleDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseDefault))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseDefault?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseRuleDecision))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseRuleDecision?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseRuleDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseInitialAclDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseInitialAclDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseInitialAclRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseInitialAclRuleDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseInitialAclDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseInitialAclDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseInitialAclRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseInitialAclRuleDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType5NullableJsonConverter();
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

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceInstanceType))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceInstanceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceInstanceType?))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceInstanceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceRegion))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceRegion?))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceSector))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceSectorJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceSector?))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceSectorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceStatus))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceStatus?))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseInstanceStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListComputeInstancesResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ListComputeInstancesResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseInstanceType))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseInstanceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseInstanceType?))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseInstanceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseRegion))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseRegion?))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseSector))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseSectorJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseSector?))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseSectorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseStatus))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseStatus?))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateComputeInstanceResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.CreateComputeInstanceResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseInstanceType))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseInstanceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseInstanceType?))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseInstanceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseRegion))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseRegion?))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseSector))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseSectorJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseSector?))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseSectorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseStatus))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseStatus?))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetComputeInstanceResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetComputeInstanceResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType))
                {
                    return new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.DeleteComputeInstanceResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListApiKeysResponseKeyScope))
                {
                    return new global::Fal.JsonConverters.ListApiKeysResponseKeyScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListApiKeysResponseKeyScope?))
                {
                    return new global::Fal.JsonConverters.ListApiKeysResponseKeyScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType))
                {
                    return new global::Fal.JsonConverters.ListApiKeysResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.ListApiKeysResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.ListApiKeysResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.ListApiKeysResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.ListApiKeysResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.ListApiKeysResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.ListApiKeysResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.ListApiKeysResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.ListApiKeysResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType))
                {
                    return new global::Fal.JsonConverters.CreateApiKeyResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.CreateApiKeyResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.CreateApiKeyResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.CreateApiKeyResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.CreateApiKeyResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.CreateApiKeyResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.CreateApiKeyResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.CreateApiKeyResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.CreateApiKeyResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.CreateApiKeyResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.CreateApiKeyResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType))
                {
                    return new global::Fal.JsonConverters.DeleteApiKeyResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.DeleteApiKeyResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.DeleteApiKeyResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetAccountBillingResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetAccountBillingResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetAccountBillingResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetAccountBillingResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetAccountBillingResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetAccountBillingResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetAccountBillingResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetAccountBillingResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetAccountBillingResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetAccountBillingResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetAccountBillingResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetFocusReportResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetFocusReportResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetFocusReportResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetFocusReportResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetFocusReportResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetFocusReportResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetFocusReportResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetFocusReportResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetFocusReportResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetFocusReportResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetFocusReportResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetModelAccessControlsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationBillingEventsResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationBillingEventsResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationFocusReportResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationFocusReportResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationTeamsResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationTeamsResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseTimeSerieResultProduct))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseTimeSerieResultProductJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseTimeSerieResultProduct?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseTimeSerieResultProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseSummaryItemProduct))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseSummaryItemProductJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseSummaryItemProduct?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseSummaryItemProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetOrganizationUsageResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetMetaResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetMetaResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetMetaResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetMetaResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetMetaResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetMetaResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetMetaResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetMetaResponseErrorType2NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[6];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new SourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),

                    4 => new SourceGenerationContextChunk4(new global::System.Text.Json.JsonSerializerOptions()),

                    5 => new SourceGenerationContextChunk5(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}