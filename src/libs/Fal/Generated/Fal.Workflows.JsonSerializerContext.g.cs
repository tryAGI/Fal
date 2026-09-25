
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowRequestContents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateWorkflowRequestContentsSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListWorkflowsResponseWorkflow>))]
    internal sealed partial class WorkflowsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WorkflowsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WorkflowsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Fal.ListWorkflowsResponseErrorType)

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

                    || typeToConvert == typeof(global::Fal.GetWorkflowResponseErrorType6?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new WorkflowsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}