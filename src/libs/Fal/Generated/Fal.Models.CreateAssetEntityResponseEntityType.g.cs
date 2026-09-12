
#nullable enable

namespace Fal
{
    /// <summary>
    /// Smart entity type<br/>
    /// Example: character
    /// </summary>
    public enum CreateAssetEntityResponseEntityType
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
    public static class CreateAssetEntityResponseEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssetEntityResponseEntityType value)
        {
            return value switch
            {
                CreateAssetEntityResponseEntityType.Character => "character",
                CreateAssetEntityResponseEntityType.Environment => "environment",
                CreateAssetEntityResponseEntityType.Prop => "prop",
                CreateAssetEntityResponseEntityType.Scene => "scene",
                CreateAssetEntityResponseEntityType.Style => "style",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssetEntityResponseEntityType? ToEnum(string value)
        {
            return value switch
            {
                "character" => CreateAssetEntityResponseEntityType.Character,
                "environment" => CreateAssetEntityResponseEntityType.Environment,
                "prop" => CreateAssetEntityResponseEntityType.Prop,
                "scene" => CreateAssetEntityResponseEntityType.Scene,
                "style" => CreateAssetEntityResponseEntityType.Style,
                _ => null,
            };
        }
    }
}