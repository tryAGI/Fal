
#nullable enable

namespace Fal
{
    /// <summary>
    /// Coarse scope of a legacy API key. Deprecated: superseded by mode, preset and permissions, and omitted for keys that carry granular permissions.<br/>
    /// Example: API
    /// </summary>
    public enum ListApiKeysResponseKeyScope
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        /// superseded by mode, preset and permissions, and omitted for keys that carry granular permissions.
        /// </summary>
        Api,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListApiKeysResponseKeyScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListApiKeysResponseKeyScope value)
        {
            return value switch
            {
                ListApiKeysResponseKeyScope.Admin => "ADMIN",
                ListApiKeysResponseKeyScope.Api => "API",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListApiKeysResponseKeyScope? ToEnum(string value)
        {
            return value switch
            {
                "ADMIN" => ListApiKeysResponseKeyScope.Admin,
                "API" => ListApiKeysResponseKeyScope.Api,
                _ => null,
            };
        }
    }
}