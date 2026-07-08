
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset library section to browse<br/>
    /// Default Value: all-media<br/>
    /// Example: all-media
    /// </summary>
    public enum ListAssetsSection
    {
        /// <summary>
        /// 
        /// </summary>
        AllMedia,
        /// <summary>
        /// 
        /// </summary>
        Favorites,
        /// <summary>
        /// 
        /// </summary>
        Generated,
        /// <summary>
        /// 
        /// </summary>
        Uploads,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAssetsSectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetsSection value)
        {
            return value switch
            {
                ListAssetsSection.AllMedia => "all-media",
                ListAssetsSection.Favorites => "favorites",
                ListAssetsSection.Generated => "generated",
                ListAssetsSection.Uploads => "uploads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetsSection? ToEnum(string value)
        {
            return value switch
            {
                "all-media" => ListAssetsSection.AllMedia,
                "favorites" => ListAssetsSection.Favorites,
                "generated" => ListAssetsSection.Generated,
                "uploads" => ListAssetsSection.Uploads,
                _ => null,
            };
        }
    }
}