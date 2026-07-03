#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Soniox.Realtime.Tts
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
        public global::Soniox.Realtime.Tts.TtsAudio? TtsAudio { get; init; }
#else
        public global::Soniox.Realtime.Tts.TtsAudio? TtsAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TtsAudio))]
#endif
        public bool IsTtsAudio => TtsAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTtsAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Soniox.Realtime.Tts.TtsAudio? value)
        {
            value = TtsAudio;
            return IsTtsAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Soniox.Realtime.Tts.TtsAudio PickTtsAudio() => IsTtsAudio
            ? TtsAudio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TtsAudio' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Soniox.Realtime.Tts.TtsTerminated? TtsTerminated { get; init; }
#else
        public global::Soniox.Realtime.Tts.TtsTerminated? TtsTerminated { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TtsTerminated))]
#endif
        public bool IsTtsTerminated => TtsTerminated != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTtsTerminated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Soniox.Realtime.Tts.TtsTerminated? value)
        {
            value = TtsTerminated;
            return IsTtsTerminated;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Soniox.Realtime.Tts.TtsTerminated PickTtsTerminated() => IsTtsTerminated
            ? TtsTerminated!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TtsTerminated' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Soniox.Realtime.Tts.TtsError? TtsError { get; init; }
#else
        public global::Soniox.Realtime.Tts.TtsError? TtsError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TtsError))]
#endif
        public bool IsTtsError => TtsError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTtsError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Soniox.Realtime.Tts.TtsError? value)
        {
            value = TtsError;
            return IsTtsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Soniox.Realtime.Tts.TtsError PickTtsError() => IsTtsError
            ? TtsError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TtsError' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Soniox.Realtime.Tts.TtsAudio value) => new ServerEvent((global::Soniox.Realtime.Tts.TtsAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Soniox.Realtime.Tts.TtsAudio?(ServerEvent @this) => @this.TtsAudio;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Soniox.Realtime.Tts.TtsAudio? value)
        {
            TtsAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTtsAudio(global::Soniox.Realtime.Tts.TtsAudio? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Soniox.Realtime.Tts.TtsTerminated value) => new ServerEvent((global::Soniox.Realtime.Tts.TtsTerminated?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Soniox.Realtime.Tts.TtsTerminated?(ServerEvent @this) => @this.TtsTerminated;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Soniox.Realtime.Tts.TtsTerminated? value)
        {
            TtsTerminated = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTtsTerminated(global::Soniox.Realtime.Tts.TtsTerminated? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Soniox.Realtime.Tts.TtsError value) => new ServerEvent((global::Soniox.Realtime.Tts.TtsError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Soniox.Realtime.Tts.TtsError?(ServerEvent @this) => @this.TtsError;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Soniox.Realtime.Tts.TtsError? value)
        {
            TtsError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTtsError(global::Soniox.Realtime.Tts.TtsError? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::Soniox.Realtime.Tts.TtsAudio? ttsAudio,
            global::Soniox.Realtime.Tts.TtsTerminated? ttsTerminated,
            global::Soniox.Realtime.Tts.TtsError? ttsError
            )
        {
            TtsAudio = ttsAudio;
            TtsTerminated = ttsTerminated;
            TtsError = ttsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TtsError as object ??
            TtsTerminated as object ??
            TtsAudio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TtsAudio?.ToString() ??
            TtsTerminated?.ToString() ??
            TtsError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTtsAudio && !IsTtsTerminated && !IsTtsError || !IsTtsAudio && IsTtsTerminated && !IsTtsError || !IsTtsAudio && !IsTtsTerminated && IsTtsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Soniox.Realtime.Tts.TtsAudio, TResult>? ttsAudio = null,
            global::System.Func<global::Soniox.Realtime.Tts.TtsTerminated, TResult>? ttsTerminated = null,
            global::System.Func<global::Soniox.Realtime.Tts.TtsError, TResult>? ttsError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTtsAudio && ttsAudio != null)
            {
                return ttsAudio(TtsAudio!);
            }
            else if (IsTtsTerminated && ttsTerminated != null)
            {
                return ttsTerminated(TtsTerminated!);
            }
            else if (IsTtsError && ttsError != null)
            {
                return ttsError(TtsError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Soniox.Realtime.Tts.TtsAudio>? ttsAudio = null,

            global::System.Action<global::Soniox.Realtime.Tts.TtsTerminated>? ttsTerminated = null,

            global::System.Action<global::Soniox.Realtime.Tts.TtsError>? ttsError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTtsAudio)
            {
                ttsAudio?.Invoke(TtsAudio!);
            }
            else if (IsTtsTerminated)
            {
                ttsTerminated?.Invoke(TtsTerminated!);
            }
            else if (IsTtsError)
            {
                ttsError?.Invoke(TtsError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Soniox.Realtime.Tts.TtsAudio>? ttsAudio = null,
            global::System.Action<global::Soniox.Realtime.Tts.TtsTerminated>? ttsTerminated = null,
            global::System.Action<global::Soniox.Realtime.Tts.TtsError>? ttsError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTtsAudio)
            {
                ttsAudio?.Invoke(TtsAudio!);
            }
            else if (IsTtsTerminated)
            {
                ttsTerminated?.Invoke(TtsTerminated!);
            }
            else if (IsTtsError)
            {
                ttsError?.Invoke(TtsError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TtsAudio,
                typeof(global::Soniox.Realtime.Tts.TtsAudio),
                TtsTerminated,
                typeof(global::Soniox.Realtime.Tts.TtsTerminated),
                TtsError,
                typeof(global::Soniox.Realtime.Tts.TtsError),
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
                global::System.Collections.Generic.EqualityComparer<global::Soniox.Realtime.Tts.TtsAudio?>.Default.Equals(TtsAudio, other.TtsAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::Soniox.Realtime.Tts.TtsTerminated?>.Default.Equals(TtsTerminated, other.TtsTerminated) &&
                global::System.Collections.Generic.EqualityComparer<global::Soniox.Realtime.Tts.TtsError?>.Default.Equals(TtsError, other.TtsError) 
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
