
#nullable enable

namespace Fal
{
    /// <summary>
    /// Fallback decision when no user-specific rule matches<br/>
    /// Example: allow
    /// </summary>
    public enum SetStorageFileAclResponseDefault
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
    public static class SetStorageFileAclResponseDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetStorageFileAclResponseDefault value)
        {
            return value switch
            {
                SetStorageFileAclResponseDefault.Allow => "allow",
                SetStorageFileAclResponseDefault.Forbid => "forbid",
                SetStorageFileAclResponseDefault.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetStorageFileAclResponseDefault? ToEnum(string value)
        {
            return value switch
            {
                "allow" => SetStorageFileAclResponseDefault.Allow,
                "forbid" => SetStorageFileAclResponseDefault.Forbid,
                "hide" => SetStorageFileAclResponseDefault.Hide,
                _ => null,
            };
        }
    }
}