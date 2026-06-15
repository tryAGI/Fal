#nullable enable

namespace Fal.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateStorageSettingsRequestInitialAclRuleDecisionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision>
    {
        /// <inheritdoc />
        public override global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision Read(
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
                        return global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecisionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecisionExtensions.ToValueString(value));
        }
    }
}
