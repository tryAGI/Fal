
#nullable enable

namespace Fal
{
    /// <summary>
    /// Fallback decision when no user-specific rule matches<br/>
    /// Example: allow
    /// </summary>
    public enum GetStorageFileAclResponseDefault
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
    public static class GetStorageFileAclResponseDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageFileAclResponseDefault value)
        {
            return value switch
            {
                GetStorageFileAclResponseDefault.Allow => "allow",
                GetStorageFileAclResponseDefault.Forbid => "forbid",
                GetStorageFileAclResponseDefault.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageFileAclResponseDefault? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetStorageFileAclResponseDefault.Allow,
                "forbid" => GetStorageFileAclResponseDefault.Forbid,
                "hide" => GetStorageFileAclResponseDefault.Hide,
                _ => null,
            };
        }
    }
}