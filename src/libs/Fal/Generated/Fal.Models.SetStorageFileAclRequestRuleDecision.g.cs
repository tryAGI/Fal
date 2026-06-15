
#nullable enable

namespace Fal
{
    /// <summary>
    /// Access decision applied to this user<br/>
    /// Example: allow
    /// </summary>
    public enum SetStorageFileAclRequestRuleDecision
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
    public static class SetStorageFileAclRequestRuleDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetStorageFileAclRequestRuleDecision value)
        {
            return value switch
            {
                SetStorageFileAclRequestRuleDecision.Allow => "allow",
                SetStorageFileAclRequestRuleDecision.Forbid => "forbid",
                SetStorageFileAclRequestRuleDecision.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetStorageFileAclRequestRuleDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => SetStorageFileAclRequestRuleDecision.Allow,
                "forbid" => SetStorageFileAclRequestRuleDecision.Forbid,
                "hide" => SetStorageFileAclRequestRuleDecision.Hide,
                _ => null,
            };
        }
    }
}