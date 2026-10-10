
#nullable enable

namespace Fal
{
    /// <summary>
    /// Deprecated: always `API`. This API lists and manages only keys on the `API` preset or the legacy `API` scope; keys on other presets or custom policies are not listed.<br/>
    /// Example: API
    /// </summary>
    public enum ListApiKeysResponseKeyScope
    {
        /// <summary>
        /// always `API`. This API lists and manages only keys on the `API` preset or the legacy `API` scope; keys on other presets or custom policies are not listed.
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
                "API" => ListApiKeysResponseKeyScope.Api,
                _ => null,
            };
        }
    }
}