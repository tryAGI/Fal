
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.CreateApiKeyRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableAnyOfStringIListString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.ListApiKeysResponseKey>))]
    internal sealed partial class KeysSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KeysSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static KeysSourceGenerationContext Default { get; } = new(DefaultOptions);

        private KeysSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Fal.ListApiKeysResponseKeyScope)

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

                    || typeToConvert == typeof(global::Fal.DeleteApiKeyResponseErrorType4?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new KeysSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}