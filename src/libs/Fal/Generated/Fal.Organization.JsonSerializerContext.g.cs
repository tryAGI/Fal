
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>), TypeInfoPropertyName = "AnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportSource), TypeInfoPropertyName = "GetOrganizationFocusReportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportTimeframe), TypeInfoPropertyName = "GetOrganizationFocusReportTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportBoundToTimeframe), TypeInfoPropertyName = "GetOrganizationFocusReportBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageTimeframe), TypeInfoPropertyName = "GetOrganizationUsageTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageBoundToTimeframe), TypeInfoPropertyName = "GetOrganizationUsageBoundToTimeframe2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>?), TypeInfoPropertyName = "NullableAnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportSource?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportTimeframe?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationFocusReportBoundToTimeframe?), TypeInfoPropertyName = "NullableGetOrganizationFocusReportBoundToTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageTimeframe?), TypeInfoPropertyName = "NullableGetOrganizationUsageTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetOrganizationUsageBoundToTimeframe?), TypeInfoPropertyName = "NullableGetOrganizationUsageBoundToTimeframe2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationBillingEventsResponseBillingEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationTeamsResponseTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationUsageResponseTimeSerie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationUsageResponseTimeSerieResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetOrganizationUsageResponseSummaryItem>))]
    internal sealed partial class OrganizationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrganizationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static OrganizationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private OrganizationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Fal.GetOrganizationFocusReportSource)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportSource?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportTimeframe)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.GetOrganizationFocusReportBoundToTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageTimeframe)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageBoundToTimeframe?)

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

                    || typeToConvert == typeof(global::Fal.GetOrganizationUsageResponseErrorType6?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new OrganizationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}