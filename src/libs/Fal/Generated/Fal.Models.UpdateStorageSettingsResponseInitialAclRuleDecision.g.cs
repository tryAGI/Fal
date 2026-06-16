
#nullable enable

namespace Fal
{
    /// <summary>
    /// Access decision applied to this user<br/>
    /// Example: allow
    /// </summary>
    public enum UpdateStorageSettingsResponseInitialAclRuleDecision
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
    public static class UpdateStorageSettingsResponseInitialAclRuleDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStorageSettingsResponseInitialAclRuleDecision value)
        {
            return value switch
            {
                UpdateStorageSettingsResponseInitialAclRuleDecision.Allow => "allow",
                UpdateStorageSettingsResponseInitialAclRuleDecision.Forbid => "forbid",
                UpdateStorageSettingsResponseInitialAclRuleDecision.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStorageSettingsResponseInitialAclRuleDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UpdateStorageSettingsResponseInitialAclRuleDecision.Allow,
                "forbid" => UpdateStorageSettingsResponseInitialAclRuleDecision.Forbid,
                "hide" => UpdateStorageSettingsResponseInitialAclRuleDecision.Hide,
                _ => null,
            };
        }
    }
}