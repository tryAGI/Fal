
#nullable enable

namespace Fal
{
    /// <summary>
    /// List/search ordering: relevant uses Explore's shared Trending browse order or keyword relevance; recent sorts by publication date (creation date when the publication date is missing). Defaults to relevant. Ignored in endpoint_id find mode, which preserves input order. Keep sort, filters and limit unchanged when following a cursor.<br/>
    /// Example: recent
    /// </summary>
    public enum GetModelsSort
    {
        /// <summary>
        /// relevant uses Explore's shared Trending browse order or keyword relevance; recent sorts by publication date (creation date when the publication date is missing). Defaults to relevant. Ignored in endpoint_id find mode, which preserves input order. Keep sort, filters and limit unchanged when following a cursor.
        /// </summary>
        Recent,
        /// <summary>
        /// relevant uses Explore's shared Trending browse order or keyword relevance; recent sorts by publication date (creation date when the publication date is missing). Defaults to relevant. Ignored in endpoint_id find mode, which preserves input order. Keep sort, filters and limit unchanged when following a cursor.
        /// </summary>
        Relevant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsSort value)
        {
            return value switch
            {
                GetModelsSort.Recent => "recent",
                GetModelsSort.Relevant => "relevant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsSort? ToEnum(string value)
        {
            return value switch
            {
                "recent" => GetModelsSort.Recent,
                "relevant" => GetModelsSort.Relevant,
                _ => null,
            };
        }
    }
}