
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>), TypeInfoPropertyName = "AnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportSource), TypeInfoPropertyName = "GetFocusReportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportExpand), TypeInfoPropertyName = "GetFocusReportExpand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportTimeframe), TypeInfoPropertyName = "GetFocusReportTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportBoundToTimeframe), TypeInfoPropertyName = "GetFocusReportBoundToTimeframe2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<global::System.DateTime?, string>?), TypeInfoPropertyName = "NullableAnyOfDateTimeString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportSource?), TypeInfoPropertyName = "NullableGetFocusReportSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportExpand?), TypeInfoPropertyName = "NullableGetFocusReportExpand2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportTimeframe?), TypeInfoPropertyName = "NullableGetFocusReportTimeframe2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetFocusReportBoundToTimeframe?), TypeInfoPropertyName = "NullableGetFocusReportBoundToTimeframe2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    internal sealed partial class AccountSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AccountSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AccountSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Fal.GetFocusReportSource)

                    || typeToConvert == typeof(global::Fal.GetFocusReportSource?)

                    || typeToConvert == typeof(global::Fal.GetFocusReportExpand)

                    || typeToConvert == typeof(global::Fal.GetFocusReportExpand?)

                    || typeToConvert == typeof(global::Fal.GetFocusReportTimeframe)

                    || typeToConvert == typeof(global::Fal.GetFocusReportTimeframe?)

                    || typeToConvert == typeof(global::Fal.GetFocusReportBoundToTimeframe)

                    || typeToConvert == typeof(global::Fal.GetFocusReportBoundToTimeframe?)

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

                    || typeToConvert == typeof(global::Fal.GetModelAccessControlsResponseErrorType4?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new AccountSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}