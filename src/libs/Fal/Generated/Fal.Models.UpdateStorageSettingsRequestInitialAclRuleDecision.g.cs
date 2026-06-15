
#nullable enable

namespace Fal
{
    /// <summary>
    /// Access decision applied to this user<br/>
    /// Example: allow
    /// </summary>
    public enum UpdateStorageSettingsRequestInitialAclRuleDecision
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Forbid,
        /// <summary>
        /// 
        /// </summary>
        Hide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateStorageSettingsRequestInitialAclRuleDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStorageSettingsRequestInitialAclRuleDecision value)
        {
            return value switch
            {
                UpdateStorageSettingsRequestInitialAclRuleDecision.Allow => "allow",
                UpdateStorageSettingsRequestInitialAclRuleDecision.Forbid => "forbid",
                UpdateStorageSettingsRequestInitialAclRuleDecision.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStorageSettingsRequestInitialAclRuleDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UpdateStorageSettingsRequestInitialAclRuleDecision.Allow,
                "forbid" => UpdateStorageSettingsRequestInitialAclRuleDecision.Forbid,
                "hide" => UpdateStorageSettingsRequestInitialAclRuleDecision.Hide,
                _ => null,
            };
        }
    }
}