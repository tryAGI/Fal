
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceInstanceType?), TypeInfoPropertyName = "NullableListComputeInstancesResponseInstanceInstanceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceRegion?), TypeInfoPropertyName = "NullableListComputeInstancesResponseInstanceRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceSector?), TypeInfoPropertyName = "NullableListComputeInstancesResponseInstanceSector2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseInstanceStatus?), TypeInfoPropertyName = "NullableListComputeInstancesResponseInstanceStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType?), TypeInfoPropertyName = "NullableListComputeInstancesResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType2?), TypeInfoPropertyName = "NullableListComputeInstancesResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType3?), TypeInfoPropertyName = "NullableListComputeInstancesResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.ListComputeInstancesResponseErrorType4?), TypeInfoPropertyName = "NullableListComputeInstancesResponseErrorType42")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListComputeInstancesResponseInstance>))]
    internal sealed partial class ComputeSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComputeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ComputeSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ComputeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Fal.ListComputeInstancesResponseInstanceInstanceType)

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

                    || typeToConvert == typeof(global::Fal.DeleteComputeInstanceResponseErrorType5?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new ComputeSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}