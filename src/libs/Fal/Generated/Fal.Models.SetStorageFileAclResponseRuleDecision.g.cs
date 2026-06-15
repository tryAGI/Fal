
#nullable enable

namespace Fal
{
    /// <summary>
    /// Access decision applied to this user<br/>
    /// Example: allow
    /// </summary>
    public enum SetStorageFileAclResponseRuleDecision
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
    public static class SetStorageFileAclResponseRuleDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetStorageFileAclResponseRuleDecision value)
        {
            return value switch
            {
                SetStorageFileAclResponseRuleDecision.Allow => "allow",
                SetStorageFileAclResponseRuleDecision.Forbid => "forbid",
                SetStorageFileAclResponseRuleDecision.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetStorageFileAclResponseRuleDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => SetStorageFileAclResponseRuleDecision.Allow,
                "forbid" => SetStorageFileAclResponseRuleDecision.Forbid,
                "hide" => SetStorageFileAclResponseRuleDecision.Hide,
                _ => null,
            };
        }
    }
}