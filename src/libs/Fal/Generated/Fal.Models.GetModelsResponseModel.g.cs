
#nullable enable

namespace Fal
{
    /// <summary>
    /// Model information with optional metadata and expandable fields
    /// </summary>
    public sealed partial class GetModelsResponseModel
    {
        /// <summary>
        /// Stable identifier used to call the model (e.g., 'fal-ai/wan/v2.2-a14b/text-to-video', 'fal-ai/minimax/video-01/image-to-video', 'fal-ai/hunyuan3d-v21')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Model metadata (optional - may be absent for endpoints without registry entries)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Fal.GetModelsResponseModelMetadata? Metadata { get; set; }

        /// <summary>
        /// ISO8601 timestamp when the endpoint is removed and stops accepting requests (midnight America/Los_Angeles on its retirement day), or null when no retirement is scheduled. Still set after the removal.<br/>
        /// Example: 2026-12-01T08:00:00.000Z
        /// </summary>
        /// <example>2026-12-01T08:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("retires_at")]
        public string? RetiresAt { get; set; }

        /// <summary>
        /// Endpoint ID of the public model to migrate to before retires_at, or null when there is none<br/>
        /// Example: fal-ai/flux/dev
        /// </summary>
        /// <example>fal-ai/flux/dev</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacement")]
        public string? Replacement { get; set; }

        /// <summary>
        /// OpenAPI 3.1 specification or error (present when expand=openapi-3.0 is requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openapi")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>))]
        public global::Fal.AnyOf<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>? Openapi { get; set; }

        /// <summary>
        /// Enterprise readiness status (present when expand=enterprise_status is requested)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enterprise_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.AnyOfJsonConverter<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>))]
        public global::Fal.AnyOf<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>? EnterpriseStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModel" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// Stable identifier used to call the model (e.g., 'fal-ai/wan/v2.2-a14b/text-to-video', 'fal-ai/minimax/video-01/image-to-video', 'fal-ai/hunyuan3d-v21')
        /// </param>
        /// <param name="metadata">
        /// Model metadata (optional - may be absent for endpoints without registry entries)
        /// </param>
        /// <param name="retiresAt">
        /// ISO8601 timestamp when the endpoint is removed and stops accepting requests (midnight America/Los_Angeles on its retirement day), or null when no retirement is scheduled. Still set after the removal.<br/>
        /// Example: 2026-12-01T08:00:00.000Z
        /// </param>
        /// <param name="replacement">
        /// Endpoint ID of the public model to migrate to before retires_at, or null when there is none<br/>
        /// Example: fal-ai/flux/dev
        /// </param>
        /// <param name="openapi">
        /// OpenAPI 3.1 specification or error (present when expand=openapi-3.0 is requested)
        /// </param>
        /// <param name="enterpriseStatus">
        /// Enterprise readiness status (present when expand=enterprise_status is requested)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelsResponseModel(
            string endpointId,
            global::Fal.GetModelsResponseModelMetadata? metadata,
            string? retiresAt,
            string? replacement,
            global::Fal.AnyOf<global::Fal.GetModelsResponseModelOpenapiVariant1, global::Fal.GetModelsResponseModelOpenapiVariant2>? openapi,
            global::Fal.AnyOf<global::Fal.GetModelsResponseModelEnterpriseStatusEnum?, global::Fal.GetModelsResponseModelEnterpriseStatusEnum2>? enterpriseStatus)
        {
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Metadata = metadata;
            this.RetiresAt = retiresAt;
            this.Replacement = replacement;
            this.Openapi = openapi;
            this.EnterpriseStatus = enterpriseStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelsResponseModel" /> class.
        /// </summary>
        public GetModelsResponseModel()
        {
        }

    }
}