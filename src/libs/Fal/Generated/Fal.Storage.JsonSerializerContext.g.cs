
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequestDefault), TypeInfoPropertyName = "SetStorageFileAclRequestDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.SetStorageFileAclRequestRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequestRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequestRuleDecision), TypeInfoPropertyName = "SetStorageFileAclRequestRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAcl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault), TypeInfoPropertyName = "UpdateStorageSettingsRequestInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.UpdateStorageSettingsRequestInitialAclRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision), TypeInfoPropertyName = "UpdateStorageSettingsRequestInitialAclRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseDefault), TypeInfoPropertyName = "GetStorageFileAclResponseDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetStorageFileAclResponseRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseRuleDecision), TypeInfoPropertyName = "GetStorageFileAclResponseRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType2), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType3), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType4), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType5), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType6), TypeInfoPropertyName = "GetStorageFileAclResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseDefault), TypeInfoPropertyName = "SetStorageFileAclResponseDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.SetStorageFileAclResponseRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseRuleDecision), TypeInfoPropertyName = "SetStorageFileAclResponseRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType2), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType3), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType4), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType5), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType6), TypeInfoPropertyName = "SetStorageFileAclResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType2), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType3), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType4), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType5), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseError6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType6), TypeInfoPropertyName = "SignStorageFileUrlResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAcl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault), TypeInfoPropertyName = "GetStorageSettingsResponseInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.GetStorageSettingsResponseInitialAclRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAclRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision), TypeInfoPropertyName = "GetStorageSettingsResponseInitialAclRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType), TypeInfoPropertyName = "GetStorageSettingsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType2), TypeInfoPropertyName = "GetStorageSettingsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType3), TypeInfoPropertyName = "GetStorageSettingsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType4), TypeInfoPropertyName = "GetStorageSettingsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAcl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault), TypeInfoPropertyName = "UpdateStorageSettingsResponseInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Fal.UpdateStorageSettingsResponseInitialAclRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision), TypeInfoPropertyName = "UpdateStorageSettingsResponseInitialAclRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType), TypeInfoPropertyName = "UpdateStorageSettingsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseError2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType2), TypeInfoPropertyName = "UpdateStorageSettingsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseError3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType3), TypeInfoPropertyName = "UpdateStorageSettingsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseError4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType4), TypeInfoPropertyName = "UpdateStorageSettingsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseError5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType5), TypeInfoPropertyName = "UpdateStorageSettingsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequestDefault?), TypeInfoPropertyName = "NullableSetStorageFileAclRequestDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclRequestRuleDecision?), TypeInfoPropertyName = "NullableSetStorageFileAclRequestRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault?), TypeInfoPropertyName = "NullableUpdateStorageSettingsRequestInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision?), TypeInfoPropertyName = "NullableUpdateStorageSettingsRequestInitialAclRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseDefault?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseRuleDecision?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType2?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType3?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType4?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType5?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageFileAclResponseErrorType6?), TypeInfoPropertyName = "NullableGetStorageFileAclResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseDefault?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseRuleDecision?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType2?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType3?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType4?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType5?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SetStorageFileAclResponseErrorType6?), TypeInfoPropertyName = "NullableSetStorageFileAclResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType2?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType3?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType4?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType5?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.SignStorageFileUrlResponseErrorType6?), TypeInfoPropertyName = "NullableSignStorageFileUrlResponseErrorType62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseInitialAclRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType2?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType3?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.GetStorageSettingsResponseErrorType4?), TypeInfoPropertyName = "NullableGetStorageSettingsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseInitialAclDefault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseInitialAclRuleDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseErrorType2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType2?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseErrorType22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType3?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseErrorType32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType4?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseErrorType42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Fal.UpdateStorageSettingsResponseErrorType5?), TypeInfoPropertyName = "NullableUpdateStorageSettingsResponseErrorType52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.SetStorageFileAclRequestRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.UpdateStorageSettingsRequestInitialAclRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetStorageFileAclResponseRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.SetStorageFileAclResponseRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.GetStorageSettingsResponseInitialAclRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Fal.UpdateStorageSettingsResponseInitialAclRule>))]
    internal sealed partial class StorageSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StorageSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StorageSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StorageSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Fal.SetStorageFileAclRequestDefault)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclRequestDefault?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclRequestRuleDecision)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclRequestRuleDecision?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseDefault)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseDefault?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseRuleDecision)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseRuleDecision?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseDefault)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseDefault?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseRuleDecision)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseRuleDecision?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType5?)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType6)

                    || typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType6?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType2)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType2?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType3)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType3?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType4)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType4?)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType5)

                    || typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType5?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Fal.SetStorageFileAclRequestDefault))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclRequestDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclRequestDefault?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclRequestDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclRequestRuleDecision))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclRequestRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclRequestRuleDecision?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclRequestRuleDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsRequestInitialAclDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclDefault?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsRequestInitialAclDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsRequestInitialAclRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsRequestInitialAclRuleDecision?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsRequestInitialAclRuleDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseDefault))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseDefault?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseRuleDecision))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseRuleDecision?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseRuleDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageFileAclResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.GetStorageFileAclResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseDefault))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseDefault?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseRuleDecision))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseRuleDecision?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseRuleDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SetStorageFileAclResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.SetStorageFileAclResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType6))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType6JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.SignStorageFileUrlResponseErrorType6?))
                {
                    return new global::Fal.JsonConverters.SignStorageFileUrlResponseErrorType6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseInitialAclDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclDefault?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseInitialAclDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseInitialAclRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseInitialAclRuleDecision?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseInitialAclRuleDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.GetStorageSettingsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.GetStorageSettingsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseInitialAclDefaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclDefault?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseInitialAclDefaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseInitialAclRuleDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseInitialAclRuleDecision?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseInitialAclRuleDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType2))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType2JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType2?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType3))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType3JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType3?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType4))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType4JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType4?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType5))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType5JsonConverter();
                }

                if (typeToConvert == typeof(global::Fal.UpdateStorageSettingsResponseErrorType5?))
                {
                    return new global::Fal.JsonConverters.UpdateStorageSettingsResponseErrorType5NullableJsonConverter();
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
                    0 => new StorageSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}