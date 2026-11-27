
#nullable enable

namespace Fal
{
    /// <summary>
    /// Why the item has no quote; null unless status is unavailable.
    /// </summary>
    public sealed partial class EstimatePricingResponseVariant1ItemError
    {
        /// <summary>
        /// Machine-readable reason.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.EstimatePricingResponseVariant1ItemErrorTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.EstimatePricingResponseVariant1ItemErrorType Type { get; set; }

        /// <summary>
        /// Human-readable reason.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// For invalid_input, why the input is invalid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1ItemErrorError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1ItemError" /> class.
        /// </summary>
        /// <param name="type">
        /// Machine-readable reason.
        /// </param>
        /// <param name="message">
        /// Human-readable reason.
        /// </param>
        /// <param name="errors">
        /// For invalid_input, why the input is invalid.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingResponseVariant1ItemError(
            global::Fal.EstimatePricingResponseVariant1ItemErrorType type,
            string message,
            global::System.Collections.Generic.IList<global::Fal.EstimatePricingResponseVariant1ItemErrorError>? errors)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponseVariant1ItemError" /> class.
        /// </summary>
        public EstimatePricingResponseVariant1ItemError()
        {
        }

    }
}