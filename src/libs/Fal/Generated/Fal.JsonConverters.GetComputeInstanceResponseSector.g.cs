#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetComputeInstanceResponseSectorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.GetComputeInstanceResponseSector>
    {
        /// <inheritdoc />
        public override global::Fal.GetComputeInstanceResponseSector Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Fal.GetComputeInstanceResponseSectorExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.GetComputeInstanceResponseSector)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.GetComputeInstanceResponseSector);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.GetComputeInstanceResponseSector value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.GetComputeInstanceResponseSectorExtensions.ToValueString(value));
        }
    }
}
