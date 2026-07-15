
#nullable enable

namespace Fal
{
    /// <summary>
    /// Endpoint authentication mode<br/>
    /// Example: private
    /// </summary>
    public enum ServerlessListAppsResponseAppAuthMode
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessListAppsResponseAppAuthModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessListAppsResponseAppAuthMode value)
        {
            return value switch
            {
                ServerlessListAppsResponseAppAuthMode.Private => "private",
                ServerlessListAppsResponseAppAuthMode.Public => "public",
                ServerlessListAppsResponseAppAuthMode.Shared => "shared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessListAppsResponseAppAuthMode? ToEnum(string value)
        {
            return value switch
            {
                "private" => ServerlessListAppsResponseAppAuthMode.Private,
                "public" => ServerlessListAppsResponseAppAuthMode.Public,
                "shared" => ServerlessListAppsResponseAppAuthMode.Shared,
                _ => null,
            };
        }
    }
}