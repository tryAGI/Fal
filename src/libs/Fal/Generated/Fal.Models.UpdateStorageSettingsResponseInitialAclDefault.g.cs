
#nullable enable

namespace Fal
{
    /// <summary>
    /// Fallback decision when no user-specific rule matches<br/>
    /// Example: allow
    /// </summary>
    public enum UpdateStorageSettingsResponseInitialAclDefault
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
    public static class UpdateStorageSettingsResponseInitialAclDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateStorageSettingsResponseInitialAclDefault value)
        {
            return value switch
            {
                UpdateStorageSettingsResponseInitialAclDefault.Allow => "allow",
                UpdateStorageSettingsResponseInitialAclDefault.Forbid => "forbid",
                UpdateStorageSettingsResponseInitialAclDefault.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateStorageSettingsResponseInitialAclDefault? ToEnum(string value)
        {
            return value switch
            {
                "allow" => UpdateStorageSettingsResponseInitialAclDefault.Allow,
                "forbid" => UpdateStorageSettingsResponseInitialAclDefault.Forbid,
                "hide" => UpdateStorageSettingsResponseInitialAclDefault.Hide,
                _ => null,
            };
        }
    }
}