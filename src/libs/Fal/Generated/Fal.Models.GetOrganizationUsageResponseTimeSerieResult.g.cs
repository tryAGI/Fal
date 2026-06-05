
#nullable enable

namespace Fal
{
    /// <summary>
    /// Organization usage line item with team attribution
    /// </summary>
    public sealed partial class GetOrganizationUsageResponseTimeSerieResult
    {
        /// <summary>
        /// Team username within the organization — identifies which team incurred this line item.<br/>
        /// Example: acme-ml-team
        /// </summary>
        /// <example>acme-ml-team</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Endpoint identifier that was used (e.g., 'fal-ai/flux/dev')<br/>
        /// Example: fal-ai/flux/dev
        /// </summary>
        /// <example>fal-ai/flux/dev</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// The billing unit (e.g., 'image', 'video', or a GPU/compute unit for some models)<br/>
        /// Example: image
        /// </summary>
        /// <example>image</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Unit { get; set; }

        /// <summary>
        /// Quantity of usage in the specified billing unit<br/>
        /// Example: 4
        /// </summary>
        /// <example>4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// Unit price used to compute charges for this line item<br/>
        /// Example: 0.1F
        /// </summary>
        /// <example>0.1F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnitPrice { get; set; }

        /// <summary>
        /// Computed cost (quantity × unit_price)<br/>
        /// Example: 0.4F
        /// </summary>
        /// <example>0.4F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Three-letter currency code (ISO 4217, e.g., 'USD')<br/>
        /// Example: USD
        /// </summary>
        /// <example>USD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// Authentication method label resolved across the organization (e.g., 'my-key (owner: alice)', 'alice &lt;alice@example.com&gt;', or 'None'). Only populated when 'auth_method' is included in the expand parameter. Falls back to the raw upstream label if the decoration service cannot resolve a row.<br/>
        /// Example: production-key (owner: acme-ml-team)
        /// </summary>
        /// <example>production-key (owner: acme-ml-team)</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        public string? AuthMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationUsageResponseTimeSerieResult" /> class.
        /// </summary>
        /// <param name="username">
        /// Team username within the organization — identifies which team incurred this line item.<br/>
        /// Example: acme-ml-team
        /// </param>
        /// <param name="endpointId">
        /// Endpoint identifier that was used (e.g., 'fal-ai/flux/dev')<br/>
        /// Example: fal-ai/flux/dev
        /// </param>
        /// <param name="unit">
        /// The billing unit (e.g., 'image', 'video', or a GPU/compute unit for some models)<br/>
        /// Example: image
        /// </param>
        /// <param name="quantity">
        /// Quantity of usage in the specified billing unit<br/>
        /// Example: 4
        /// </param>
        /// <param name="unitPrice">
        /// Unit price used to compute charges for this line item<br/>
        /// Example: 0.1F
        /// </param>
        /// <param name="cost">
        /// Computed cost (quantity × unit_price)<br/>
        /// Example: 0.4F
        /// </param>
        /// <param name="currency">
        /// Three-letter currency code (ISO 4217, e.g., 'USD')<br/>
        /// Example: USD
        /// </param>
        /// <param name="authMethod">
        /// Authentication method label resolved across the organization (e.g., 'my-key (owner: alice)', 'alice &lt;alice@example.com&gt;', or 'None'). Only populated when 'auth_method' is included in the expand parameter. Falls back to the raw upstream label if the decoration service cannot resolve a row.<br/>
        /// Example: production-key (owner: acme-ml-team)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationUsageResponseTimeSerieResult(
            string username,
            string endpointId,
            string unit,
            double quantity,
            double unitPrice,
            double cost,
            string currency,
            string? authMethod)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.Cost = cost;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.AuthMethod = authMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationUsageResponseTimeSerieResult" /> class.
        /// </summary>
        public GetOrganizationUsageResponseTimeSerieResult()
        {
        }

    }
}