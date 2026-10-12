
#nullable enable

namespace Fal
{
    /// <summary>
    /// How the key's permissions are expressed: a named preset, a custom permission list, or a legacy scope.<br/>
    /// Example: preset
    /// </summary>
    public enum ListApiKeysResponseKeyMode
    {
        /// <summary>
        /// a named preset, a custom permission list, or a legacy scope.
        /// </summary>
        Custom,
        /// <summary>
        /// a named preset, a custom permission list, or a legacy scope.
        /// </summary>
        Legacy,
        /// <summary>
        /// a named preset, a custom permission list, or a legacy scope.
        /// </summary>
        Preset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListApiKeysResponseKeyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListApiKeysResponseKeyMode value)
        {
            return value switch
            {
                ListApiKeysResponseKeyMode.Custom => "custom",
                ListApiKeysResponseKeyMode.Legacy => "legacy",
                ListApiKeysResponseKeyMode.Preset => "preset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListApiKeysResponseKeyMode? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ListApiKeysResponseKeyMode.Custom,
                "legacy" => ListApiKeysResponseKeyMode.Legacy,
                "preset" => ListApiKeysResponseKeyMode.Preset,
                _ => null,
            };
        }
    }
}