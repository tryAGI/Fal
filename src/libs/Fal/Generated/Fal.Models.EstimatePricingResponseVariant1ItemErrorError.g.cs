
#nullable enable

namespace Fal
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EstimatePricingResponseVariant1ItemErrorError
    {
        /// <summary>
        /// Where in the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.AnyOf<string, double?>> Loc { get; set; }

        /// <summary>
        /// What is wrong.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Msg { get; set; }

        /// <summary>
        /// Machine-readable error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Details of the constraint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ctx")]
        public object? Ctx { get; set; }

        /// <summary>
        /// The offending value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1ItemErrorError" /> class.
        /// </summary>
        /// <param name="loc">
        /// Where in the input.
        /// </param>
        /// <param name="msg">
        /// What is wrong.
        /// </param>
        /// <param name="type">
        /// Machine-readable error type.
        /// </param>
        /// <param name="ctx">
        /// Details of the constraint.
        /// </param>
        /// <param name="input">
        /// The offending value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingResponseVariant1ItemErrorError(
            global::System.Collections.Generic.IList<global::Fal.AnyOf<string, double?>> loc,
            string msg,
            string type,
            object? ctx,
            object? input)
        {
            this.Loc = loc ?? throw new global::System.ArgumentNullException(nameof(loc));
            this.Msg = msg ?? throw new global::System.ArgumentNullException(nameof(msg));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Ctx = ctx;
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1ItemErrorError" /> class.
        /// </summary>
        public EstimatePricingResponseVariant1ItemErrorError()
        {
        }

    }
}