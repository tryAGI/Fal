
#nullable enable

namespace Fal
{
    /// <summary>
    /// Fallback decision when no user-specific rule matches<br/>
    /// Example: allow
    /// </summary>
    public enum GetStorageSettingsResponseInitialAclDefault
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
    public static class GetStorageSettingsResponseInitialAclDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetStorageSettingsResponseInitialAclDefault value)
        {
            return value switch
            {
                GetStorageSettingsResponseInitialAclDefault.Allow => "allow",
                GetStorageSettingsResponseInitialAclDefault.Forbid => "forbid",
                GetStorageSettingsResponseInitialAclDefault.Hide => "hide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetStorageSettingsResponseInitialAclDefault? ToEnum(string value)
        {
            return value switch
            {
                "allow" => GetStorageSettingsResponseInitialAclDefault.Allow,
                "forbid" => GetStorageSettingsResponseInitialAclDefault.Forbid,
                "hide" => GetStorageSettingsResponseInitialAclDefault.Hide,
                _ => null,
            };
        }
    }
}