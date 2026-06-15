
#nullable enable

namespace Fal
{
    /// <summary>
    /// Access decision applied to this user<br/>
    /// Example: allow
    /// </summary>
    public enum GetStorageFileAclResponseRuleDecision
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
    public static class GetStorageFileAclResponseRuleDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageFileAclResponseRuleDecision value)
        {
            return value switch
            {
                GetStorageFileAclResponseRuleDecision.Allow => "allow",
                GetStorageFileAclResponseRuleDecision.Forbid => "forbid",
                GetStorageFileAclResponseRuleDecision.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageFileAclResponseRuleDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetStorageFileAclResponseRuleDecision.Allow,
                "forbid" => GetStorageFileAclResponseRuleDecision.Forbid,
                "hide" => GetStorageFileAclResponseRuleDecision.Hide,
                _ => null,
            };
        }
    }
}