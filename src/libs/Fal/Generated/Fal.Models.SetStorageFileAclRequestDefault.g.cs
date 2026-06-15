
#nullable enable

namespace Fal
{
    /// <summary>
    /// Fallback decision when no user-specific rule matches<br/>
    /// Example: allow
    /// </summary>
    public enum SetStorageFileAclRequestDefault
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
    public static class SetStorageFileAclRequestDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetStorageFileAclRequestDefault value)
        {
            return value switch
            {
                SetStorageFileAclRequestDefault.Allow => "allow",
                SetStorageFileAclRequestDefault.Forbid => "forbid",
                SetStorageFileAclRequestDefault.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetStorageFileAclRequestDefault? ToEnum(string value)
        {
            return value switch
            {
                "allow" => SetStorageFileAclRequestDefault.Allow,
                "forbid" => SetStorageFileAclRequestDefault.Forbid,
                "hide" => SetStorageFileAclRequestDefault.Hide,
                _ => null,
            };
        }
    }
}