
#nullable enable

namespace Fal
{
    /// <summary>
    /// Response containing organization team details
    /// </summary>
    public sealed partial class GetOrganizationTeamsResponse
    {
        /// <summary>
        /// List of teams in the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Fal.GetOrganizationTeamsResponseTeam> Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationTeamsResponse" /> class.
        /// </summary>
        /// <param name="teams">
        /// List of teams in the organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationTeamsResponse(
            global::System.Collections.Generic.IList<global::Fal.GetOrganizationTeamsResponseTeam> teams)
        {
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationTeamsResponse" /> class.
        /// </summary>
        public GetOrganizationTeamsResponse()
        {
        }

    }
}