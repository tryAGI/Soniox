
#nullable enable

namespace Soniox
{
    /// <summary>
    /// Example: {"client_reference_id":"reference_id","expires_in_seconds":1800,"max_session_duration_seconds":120,"single_use":true,"usage_type":"transcribe_websocket"}
    /// </summary>
    public sealed partial class CreateTemporaryApiKeyPayload
    {
        /// <summary>
        /// Intended usage of the temporary API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Soniox.JsonConverters.TemporaryApiKeyUsageTypeJsonConverter))]
        public global::Soniox.TemporaryApiKeyUsageType UsageType { get; set; }

        /// <summary>
        /// Duration in seconds until the temporary API key expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresInSeconds { get; set; }

        /// <summary>
        /// Optional tracking identifier string. Does not need to be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_reference_id")]
        public string? ClientReferenceId { get; set; }

        /// <summary>
        /// If true, the temporary API key can be used only once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_use")]
        public bool? SingleUse { get; set; }

        /// <summary>
        /// Maximum WebSocket connection duration in seconds. If exceeded, the connection will be dropped. If not set, no limit is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_session_duration_seconds")]
        public int? MaxSessionDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemporaryApiKeyPayload" /> class.
        /// </summary>
        /// <param name="expiresInSeconds">
        /// Duration in seconds until the temporary API key expires.
        /// </param>
        /// <param name="usageType">
        /// Intended usage of the temporary API key.
        /// </param>
        /// <param name="clientReferenceId">
        /// Optional tracking identifier string. Does not need to be unique.
        /// </param>
        /// <param name="singleUse">
        /// If true, the temporary API key can be used only once.
        /// </param>
        /// <param name="maxSessionDurationSeconds">
        /// Maximum WebSocket connection duration in seconds. If exceeded, the connection will be dropped. If not set, no limit is applied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTemporaryApiKeyPayload(
            int expiresInSeconds,
            global::Soniox.TemporaryApiKeyUsageType usageType,
            string? clientReferenceId,
            bool? singleUse,
            int? maxSessionDurationSeconds)
        {
            this.UsageType = usageType;
            this.ExpiresInSeconds = expiresInSeconds;
            this.ClientReferenceId = clientReferenceId;
            this.SingleUse = singleUse;
            this.MaxSessionDurationSeconds = maxSessionDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTemporaryApiKeyPayload" /> class.
        /// </summary>
        public CreateTemporaryApiKeyPayload()
        {
        }
    }
}