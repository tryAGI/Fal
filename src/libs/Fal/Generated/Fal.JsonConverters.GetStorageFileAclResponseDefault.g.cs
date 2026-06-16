#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetStorageFileAclResponseDefaultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.GetStorageFileAclResponseDefault>
    {
        /// <inheritdoc />
        public override global::Fal.GetStorageFileAclResponseDefault Read(
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
                        return global::Fal.GetStorageFileAclResponseDefaultExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.GetStorageFileAclResponseDefault)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.GetStorageFileAclResponseDefault);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.GetStorageFileAclResponseDefault value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.GetStorageFileAclResponseDefaultExtensions.ToValueString(value));
        }
    }
}
