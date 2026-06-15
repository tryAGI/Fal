
#nullable enable

namespace Fal
{
    /// <summary>
    /// Fallback decision when no user-specific rule matches<br/>
    /// Example: allow
    /// </summary>
    public enum UpdateStorageSettingsRequestInitialAclDefault
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
    public static class UpdateStorageSettingsRequestInitialAclDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStorageSettingsRequestInitialAclDefault value)
        {
            return value switch
            {
                UpdateStorageSettingsRequestInitialAclDefault.Allow => "allow",
                UpdateStorageSettingsRequestInitialAclDefault.Forbid => "forbid",
                UpdateStorageSettingsRequestInitialAclDefault.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStorageSettingsRequestInitialAclDefault? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UpdateStorageSettingsRequestInitialAclDefault.Allow,
                "forbid" => UpdateStorageSettingsRequestInitialAclDefault.Forbid,
                "hide" => UpdateStorageSettingsRequestInitialAclDefault.Hide,
                _ => null,
            };
        }
    }
}