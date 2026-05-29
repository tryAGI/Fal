#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetOrganizationTeamsResponseErrorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.GetOrganizationTeamsResponseErrorType>
    {
        /// <inheritdoc />
        public override global::Fal.GetOrganizationTeamsResponseErrorType Read(
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
                        return global::Fal.GetOrganizationTeamsResponseErrorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.GetOrganizationTeamsResponseErrorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.GetOrganizationTeamsResponseErrorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.GetOrganizationTeamsResponseErrorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.GetOrganizationTeamsResponseErrorTypeExtensions.ToValueString(value));
        }
    }
}
