
#nullable enable

namespace Fal
{
    /// <summary>
    /// Asset library section to browse<br/>
    /// Default Value: all-media<br/>
    /// Example: all-media
    /// </summary>
    public enum ListAssetCollectionAssetsSection
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
    public static class ListAssetCollectionAssetsSectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAssetCollectionAssetsSection value)
        {
            return value switch
            {
                ListAssetCollectionAssetsSection.AllMedia => "all-media",
                ListAssetCollectionAssetsSection.Favorites => "favorites",
                ListAssetCollectionAssetsSection.Generated => "generated",
                ListAssetCollectionAssetsSection.Uploads => "uploads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAssetCollectionAssetsSection? ToEnum(string value)
        {
            return value switch
            {
                "all-media" => ListAssetCollectionAssetsSection.AllMedia,
                "favorites" => ListAssetCollectionAssetsSection.Favorites,
                "generated" => ListAssetCollectionAssetsSection.Generated,
                "uploads" => ListAssetCollectionAssetsSection.Uploads,
                _ => null,
            };
        }
    }
}