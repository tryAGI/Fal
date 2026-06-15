
#nullable enable

namespace Fal
{
    /// <summary>
    /// Access decision applied to this user<br/>
    /// Example: allow
    /// </summary>
    public enum GetStorageSettingsResponseInitialAclRuleDecision
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
    public static class GetStorageSettingsResponseInitialAclRuleDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageSettingsResponseInitialAclRuleDecision value)
        {
            return value switch
            {
                GetStorageSettingsResponseInitialAclRuleDecision.Allow => "allow",
                GetStorageSettingsResponseInitialAclRuleDecision.Forbid => "forbid",
                GetStorageSettingsResponseInitialAclRuleDecision.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageSettingsResponseInitialAclRuleDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetStorageSettingsResponseInitialAclRuleDecision.Allow,
                "forbid" => GetStorageSettingsResponseInitialAclRuleDecision.Forbid,
                "hide" => GetStorageSettingsResponseInitialAclRuleDecision.Hide,
                _ => null,
            };
        }
    }
}