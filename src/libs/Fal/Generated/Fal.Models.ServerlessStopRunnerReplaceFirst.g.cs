
#nullable enable

namespace Fal
{
    /// <summary>
    /// Whether to start a replacement runner before stopping this one. Defaults to false.<br/>
    /// Default Value: false<br/>
    /// Example: false
    /// </summary>
    public enum ServerlessStopRunnerReplaceFirst
    {
        /// <summary>
        ///
        /// </summary>
        False,
        /// <summary>
        ///
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessStopRunnerReplaceFirstExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessStopRunnerReplaceFirst value)
        {
            return value switch
            {
                ServerlessStopRunnerReplaceFirst.False => "false",
                ServerlessStopRunnerReplaceFirst.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessStopRunnerReplaceFirst? ToEnum(string value)
        {
            return value switch
            {
                "false" => ServerlessStopRunnerReplaceFirst.False,
                "true" => ServerlessStopRunnerReplaceFirst.True,
                _ => null,
            };
        }
    }
}