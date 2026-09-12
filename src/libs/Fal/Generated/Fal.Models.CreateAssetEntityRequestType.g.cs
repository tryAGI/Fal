
#nullable enable

namespace Fal
{
    /// <summary>
    /// Smart entity type<br/>
    /// Example: character
    /// </summary>
    public enum CreateAssetEntityRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Character,
        /// <summary>
        ///
        /// </summary>
        Environment,
        /// <summary>
        ///
        /// </summary>
        Prop,
        /// <summary>
        ///
        /// </summary>
        Scene,
        /// <summary>
        ///
        /// </summary>
        Style,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssetEntityRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetEntityRequestType value)
        {
            return value switch
            {
                CreateAssetEntityRequestType.Character => "character",
                CreateAssetEntityRequestType.Environment => "environment",
                CreateAssetEntityRequestType.Prop => "prop",
                CreateAssetEntityRequestType.Scene => "scene",
                CreateAssetEntityRequestType.Style => "style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetEntityRequestType? ToEnum(string value)
        {
            return value switch
            {
                "character" => CreateAssetEntityRequestType.Character,
                "environment" => CreateAssetEntityRequestType.Environment,
                "prop" => CreateAssetEntityRequestType.Prop,
                "scene" => CreateAssetEntityRequestType.Scene,
                "style" => CreateAssetEntityRequestType.Style,
                _ => null,
            };
        }
    }
}