
#nullable enable

namespace Soniox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ApiError
    {
        /// <summary>
        /// HTTP status code of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Machine-readable error category.<br/>
        /// Examples: `invalid_request`, `unauthenticated`, `limit_exceeded`, `model_not_available`, `internal_error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorType { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// List of per-field validation errors. Populated only when `error_type` is `invalid_request` and the failure came from request-body validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Soniox.ApiErrorValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Unique identifier for this request. Include it when contacting support at support@soniox.com so we can look up server-side logs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Optional URL with additional information about this error. Points to the Soniox documentation<br/>
        /// for errors a developer can resolve via code or configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("more_info")]
        public string? MoreInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiError" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// HTTP status code of the response.
        /// </param>
        /// <param name="errorType">
        /// Machine-readable error category.<br/>
        /// Examples: `invalid_request`, `unauthenticated`, `limit_exceeded`, `model_not_available`, `internal_error`.
        /// </param>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="validationErrors">
        /// List of per-field validation errors. Populated only when `error_type` is `invalid_request` and the failure came from request-body validation.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for this request. Include it when contacting support at support@soniox.com so we can look up server-side logs.
        /// </param>
        /// <param name="moreInfo">
        /// Optional URL with additional information about this error. Points to the Soniox documentation<br/>
        /// for errors a developer can resolve via code or configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiError(
            int statusCode,
            string errorType,
            string message,
            global::System.Collections.Generic.IList<global::Soniox.ApiErrorValidationError> validationErrors,
            string requestId,
            string? moreInfo)
        {
            this.StatusCode = statusCode;
            this.ErrorType = errorType ?? throw new global::System.ArgumentNullException(nameof(errorType));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.ValidationErrors = validationErrors ?? throw new global::System.ArgumentNullException(nameof(validationErrors));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.MoreInfo = moreInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiError" /> class.
        /// </summary>
        public ApiError()
        {
        }

    }
}