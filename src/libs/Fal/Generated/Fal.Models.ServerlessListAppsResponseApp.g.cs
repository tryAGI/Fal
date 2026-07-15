
#nullable enable

namespace Fal
{
    /// <summary>
    /// A serverless application owned by the caller
    /// </summary>
    public sealed partial class ServerlessListAppsResponseApp
    {
        /// <summary>
        /// Canonical endpoint identifier ('&lt;owner&gt;/&lt;name&gt;') accepted by the analytics, requests, logs, and queue endpoints<br/>
        /// Example: user_123/my-app
        /// </summary>
        /// <example>user_123/my-app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Application name (alias)<br/>
        /// Example: my-app
        /// </summary>
        /// <example>my-app</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Nickname of the app owner<br/>
        /// Example: user_123
        /// </summary>
        /// <example>user_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// Environment the app is deployed in<br/>
        /// Example: main
        /// </summary>
        /// <example>main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// Machine type the app runs on<br/>
        /// Example: GPU-H100
        /// </summary>
        /// <example>GPU-H100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("machine_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MachineType { get; set; }

        /// <summary>
        /// Endpoint authentication mode<br/>
        /// Example: private
        /// </summary>
        /// <example>private</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Fal.JsonConverters.ServerlessListAppsResponseAppAuthModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Fal.ServerlessListAppsResponseAppAuthMode AuthMode { get; set; }

        /// <summary>
        /// Seconds a runner stays warm after its last request<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_alive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double KeepAlive { get; set; }

        /// <summary>
        /// Minimum number of runners kept alive<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinConcurrency { get; set; }

        /// <summary>
        /// Maximum number of concurrent runners<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxConcurrency { get; set; }

        /// <summary>
        /// Request timeout in seconds<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_timeout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestTimeout { get; set; }

        /// <summary>
        /// Runner startup timeout in seconds<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startup_timeout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartupTimeout { get; set; }

        /// <summary>
        /// Regions the app may run in<br/>
        /// Example: [us]
        /// </summary>
        /// <example>[us]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_regions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ValidRegions { get; set; }

        /// <summary>
        /// Last update timestamp (UTC ISO8601)<br/>
        /// Example: 2026-07-01T12:00:00Z
        /// </summary>
        /// <example>2026-07-01T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppsResponseApp" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// Canonical endpoint identifier ('&lt;owner&gt;/&lt;name&gt;') accepted by the analytics, requests, logs, and queue endpoints<br/>
        /// Example: user_123/my-app
        /// </param>
        /// <param name="name">
        /// Application name (alias)<br/>
        /// Example: my-app
        /// </param>
        /// <param name="owner">
        /// Nickname of the app owner<br/>
        /// Example: user_123
        /// </param>
        /// <param name="environment">
        /// Environment the app is deployed in<br/>
        /// Example: main
        /// </param>
        /// <param name="machineType">
        /// Machine type the app runs on<br/>
        /// Example: GPU-H100
        /// </param>
        /// <param name="authMode">
        /// Endpoint authentication mode<br/>
        /// Example: private
        /// </param>
        /// <param name="keepAlive">
        /// Seconds a runner stays warm after its last request<br/>
        /// Example: 300
        /// </param>
        /// <param name="minConcurrency">
        /// Minimum number of runners kept alive<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxConcurrency">
        /// Maximum number of concurrent runners<br/>
        /// Example: 2
        /// </param>
        /// <param name="requestTimeout">
        /// Request timeout in seconds<br/>
        /// Example: 600
        /// </param>
        /// <param name="startupTimeout">
        /// Runner startup timeout in seconds<br/>
        /// Example: 300
        /// </param>
        /// <param name="validRegions">
        /// Regions the app may run in<br/>
        /// Example: [us]
        /// </param>
        /// <param name="updatedAt">
        /// Last update timestamp (UTC ISO8601)<br/>
        /// Example: 2026-07-01T12:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessListAppsResponseApp(
            string endpointId,
            string name,
            string owner,
            string environment,
            string machineType,
            global::Fal.ServerlessListAppsResponseAppAuthMode authMode,
            double keepAlive,
            double minConcurrency,
            double maxConcurrency,
            double requestTimeout,
            double startupTimeout,
            global::System.Collections.Generic.IList<string> validRegions,
            string updatedAt)
        {
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.MachineType = machineType ?? throw new global::System.ArgumentNullException(nameof(machineType));
            this.AuthMode = authMode;
            this.KeepAlive = keepAlive;
            this.MinConcurrency = minConcurrency;
            this.MaxConcurrency = maxConcurrency;
            this.RequestTimeout = requestTimeout;
            this.StartupTimeout = startupTimeout;
            this.ValidRegions = validRegions ?? throw new global::System.ArgumentNullException(nameof(validRegions));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessListAppsResponseApp" /> class.
        /// </summary>
        public ServerlessListAppsResponseApp()
        {
        }

    }
}