#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetStorageFileAclResponseErrorType6NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.GetStorageFileAclResponseErrorType6?>
    {
        /// <inheritdoc />
        public override global::Fal.GetStorageFileAclResponseErrorType6? Read(
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
                        return global::Fal.GetStorageFileAclResponseErrorType6Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.GetStorageFileAclResponseErrorType6)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.GetStorageFileAclResponseErrorType6?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.GetStorageFileAclResponseErrorType6? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Fal.GetStorageFileAclResponseErrorType6Extensions.ToValueString(value.Value));
            }
        }
    }
}
