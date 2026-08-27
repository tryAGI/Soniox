#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Soniox.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Soniox.Realtime.RealtimeResult? RealtimeResult { get; init; }
#else
        public global::Soniox.Realtime.RealtimeResult? RealtimeResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeResult))]
#endif
        public bool IsRealtimeResult => RealtimeResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Soniox.Realtime.RealtimeResult? value)
        {
            value = RealtimeResult;
            return IsRealtimeResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Soniox.Realtime.RealtimeResult PickRealtimeResult() => IsRealtimeResult
            ? RealtimeResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeResult' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Soniox.Realtime.RealtimeError? RealtimeError { get; init; }
#else
        public global::Soniox.Realtime.RealtimeError? RealtimeError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RealtimeError))]
#endif
        public bool IsRealtimeError => RealtimeError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRealtimeError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Soniox.Realtime.RealtimeError? value)
        {
            value = RealtimeError;
            return IsRealtimeError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Soniox.Realtime.RealtimeError PickRealtimeError() => IsRealtimeError
            ? RealtimeError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RealtimeError' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Soniox.Realtime.RealtimeResult value) => new ServerEvent((global::Soniox.Realtime.RealtimeResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Soniox.Realtime.RealtimeResult?(ServerEvent @this) => @this.RealtimeResult;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Soniox.Realtime.RealtimeResult? value)
        {
            RealtimeResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimeResult(global::Soniox.Realtime.RealtimeResult? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerEvent(global::Soniox.Realtime.RealtimeError value) => new ServerEvent((global::Soniox.Realtime.RealtimeError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Soniox.Realtime.RealtimeError?(ServerEvent @this) => @this.RealtimeError;

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(global::Soniox.Realtime.RealtimeError? value)
        {
            RealtimeError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerEvent FromRealtimeError(global::Soniox.Realtime.RealtimeError? value) => new ServerEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ServerEvent(
            global::Soniox.Realtime.RealtimeResult? realtimeResult,
            global::Soniox.Realtime.RealtimeError? realtimeError
            )
        {
            RealtimeResult = realtimeResult;
            RealtimeError = realtimeError;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RealtimeError as object ??
            RealtimeResult as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RealtimeResult?.ToString() ??
            RealtimeError?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRealtimeResult && !IsRealtimeError || !IsRealtimeResult && IsRealtimeError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Soniox.Realtime.RealtimeResult, TResult>? realtimeResult = null,
            global::System.Func<global::Soniox.Realtime.RealtimeError, TResult>? realtimeError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeResult && realtimeResult != null)
            {
                return realtimeResult(RealtimeResult!);
            }
            else if (IsRealtimeError && realtimeError != null)
            {
                return realtimeError(RealtimeError!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Soniox.Realtime.RealtimeResult>? realtimeResult = null,

            global::System.Action<global::Soniox.Realtime.RealtimeError>? realtimeError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeResult)
            {
                realtimeResult?.Invoke(RealtimeResult!);
            }
            else if (IsRealtimeError)
            {
                realtimeError?.Invoke(RealtimeError!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Soniox.Realtime.RealtimeResult>? realtimeResult = null,
            global::System.Action<global::Soniox.Realtime.RealtimeError>? realtimeError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRealtimeResult)
            {
                realtimeResult?.Invoke(RealtimeResult!);
            }
            else if (IsRealtimeError)
            {
                realtimeError?.Invoke(RealtimeError!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RealtimeResult,
                typeof(global::Soniox.Realtime.RealtimeResult),
                RealtimeError,
                typeof(global::Soniox.Realtime.RealtimeError),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Soniox.Realtime.RealtimeResult?>.Default.Equals(RealtimeResult, other.RealtimeResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Soniox.Realtime.RealtimeError?>.Default.Equals(RealtimeError, other.RealtimeError)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
