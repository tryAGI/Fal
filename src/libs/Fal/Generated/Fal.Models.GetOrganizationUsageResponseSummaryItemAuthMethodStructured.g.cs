
#nullable enable

namespace Fal
{
    /// <summary>
    /// Structured authentication method identity resolved across the organization. Only populated when 'auth_method_structured' is included in the expand parameter.
    /// </summary>
    public sealed partial class GetOrganizationUsageResponseSummaryItemAuthMethodStructured
    {
        /// <summary>
        /// Human-readable summary of the authentication method (key alias, login username, or 'User token'/'None').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// API key ID, present when the request was made with an API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// Team member login username (nickname), present when the request was made with a user login token resolvable to a team member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login_username")]
        public string? LoginUsername { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationUsageResponseSummaryItemAuthMethodStructured" /> class.
        /// </summary>
        /// <param name="detail">
        /// Human-readable summary of the authentication method (key alias, login username, or 'User token'/'None').
        /// </param>
        /// <param name="apiKeyId">
        /// API key ID, present when the request was made with an API key.
        /// </param>
        /// <param name="loginUsername">
        /// Team member login username (nickname), present when the request was made with a user login token resolvable to a team member.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationUsageResponseSummaryItemAuthMethodStructured(
            string detail,
            string? apiKeyId,
            string? loginUsername)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.ApiKeyId = apiKeyId;
            this.LoginUsername = loginUsername;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationUsageResponseSummaryItemAuthMethodStructured" /> class.
        /// </summary>
        public GetOrganizationUsageResponseSummaryItemAuthMethodStructured()
        {
        }

    }
}