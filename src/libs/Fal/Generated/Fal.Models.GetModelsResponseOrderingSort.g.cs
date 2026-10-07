
#nullable enable

namespace Fal
{
    /// <summary>
    /// List/search ordering applied to this response
    /// </summary>
    public enum GetModelsResponseOrderingSort
    {
        /// <summary>
        ///
        /// </summary>
        Recent,
        /// <summary>
        ///
        /// </summary>
        Relevant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsResponseOrderingSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsResponseOrderingSort value)
        {
            return value switch
            {
                GetModelsResponseOrderingSort.Recent => "recent",
                GetModelsResponseOrderingSort.Relevant => "relevant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsResponseOrderingSort? ToEnum(string value)
        {
            return value switch
            {
                "recent" => GetModelsResponseOrderingSort.Recent,
                "relevant" => GetModelsResponseOrderingSort.Relevant,
                _ => null,
            };
        }
    }
}