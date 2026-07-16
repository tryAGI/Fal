
#nullable enable

namespace Fal
{
    /// <summary>
    /// User who triggered the event, when known
    /// </summary>
    public sealed partial class ServerlessListAppEventsResponseEventPayloadActor
    {
        /// <summary>
        /// Nickname of the user who triggered the change<br/>
        /// Example: user_123
        /// </summary>
        /// <example>user_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// Display name of the user who triggered the change<br/>
        /// Example: Ada Lovelace
        /// </summary>
        /// <example>Ada Lovelace</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppEventsResponseEventPayloadActor" /> class.
        /// </summary>
        /// <param name="nickname">
        /// Nickname of the user who triggered the change<br/>
        /// Example: user_123
        /// </param>
        /// <param name="fullName">
        /// Display name of the user who triggered the change<br/>
        /// Example: Ada Lovelace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessListAppEventsResponseEventPayloadActor(
            string? nickname,
            string? fullName)
        {
            this.Nickname = nickname;
            this.FullName = fullName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppEventsResponseEventPayloadActor" /> class.
        /// </summary>
        public ServerlessListAppEventsResponseEventPayloadActor()
        {
        }

    }
}