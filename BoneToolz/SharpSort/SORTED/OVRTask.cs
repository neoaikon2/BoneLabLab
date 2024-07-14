using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal static class OVRTask
{
	internal static OVRTask<TResult> FromGuid<TResult>(Guid id)
	{
		return default(OVRTask<TResult>);
	}

	internal static OVRTask<TResult> FromRequest<TResult>(ulong id)
	{
		return default(OVRTask<TResult>);
	}

	internal static OVRTask<TResult> FromResult<TResult>(TResult result)
	{
		return default(OVRTask<TResult>);
	}

	internal static OVRTask<TResult> GetExisting<TResult>(Guid id)
	{
		return default(OVRTask<TResult>);
	}

	internal static OVRTask<TResult> GetExisting<TResult>(ulong id)
	{
		return default(OVRTask<TResult>);
	}

	internal static void SetResult<TResult>(Guid id, TResult result)
	{
	}

	internal static void SetResult<TResult>(ulong id, TResult result)
	{
	}

	private static OVRTask<TResult> Get<TResult>(Guid id)
	{
		return default(OVRTask<TResult>);
	}

	private static OVRTask<TResult> Create<TResult>(Guid id)
	{
		return default(OVRTask<TResult>);
	}

	internal static Guid GetId(ulong value)
	{
		return default(Guid);
	}
}
public readonly struct OVRTask<TResult> : IEquatable<OVRTask<TResult>>, IDisposable
{
	private delegate void CallbackInvoker(Guid guid, TResult result);

	private delegate bool CallbackRemover(Guid guid);

	private delegate bool InternalDataRemover(Guid guid);

	private static class InternalData<T>
	{
		private static readonly Dictionary<Guid, T> Data;

		private static readonly InternalDataRemover Remover;

		private static readonly Action Clearer;

		public static bool TryGet(Guid taskId, out T data)
		{
			data = default(T);
			return false;
		}

		public static void Set(Guid taskId, T data)
		{
		}

		private static bool Remove(Guid taskId)
		{
			return false;
		}

		private static void Clear()
		{
		}
	}

	private static class IncrementalResultSubscriber<T>
	{
		private static readonly Dictionary<Guid, Action<T>> Subscribers;

		private static readonly Action<Guid> Remover;

		private static readonly Action Clearer;

		public static void Set(Guid taskId, Action<T> subscriber)
		{
		}

		public static void Notify(Guid taskId, T result)
		{
		}

		private static void Remove(Guid id)
		{
		}

		private static void Clear()
		{
		}
	}

	public readonly struct Awaiter : INotifyCompletion
	{
		private readonly OVRTask<TResult> _task;

		public bool IsCompleted => false;

		internal Awaiter(OVRTask<TResult> task)
		{
			_task = default(OVRTask<TResult>);
		}

		public void OnCompleted(Action continuation)
		{
		}

		public TResult GetResult()
		{
			return default(TResult);
		}
	}

	private readonly struct Callback
	{
		private static readonly Dictionary<Guid, Callback> Callbacks;

		private readonly Action<TResult> _delegate;

		public static readonly CallbackInvoker Invoker;

		public static readonly CallbackRemover Remover;

		public static readonly Action Clearer;

		private static void Invoke(Guid taskId, TResult result)
		{
		}

		private static bool Remove(Guid taskId)
		{
			return false;
		}

		private static void Clear()
		{
		}

		private void Invoke(TResult result)
		{
		}

		private Callback(Action<TResult> @delegate)
		{
			_delegate = null;
		}

		public static void Add(Guid taskId, Action<TResult> @delegate)
		{
		}
	}

	private readonly struct CallbackWithState<T>
	{
		private static readonly Dictionary<Guid, CallbackWithState<T>> Callbacks;

		private readonly T _data;

		private readonly Action<TResult, T> _delegate;

		private static readonly CallbackInvoker Invoker;

		private static readonly CallbackRemover Remover;

		private static readonly Action Clearer;

		private static void Invoke(Guid taskId, TResult result)
		{
		}

		private CallbackWithState(T data, Action<TResult, T> @delegate)
		{
			_data = default(T);
			_delegate = null;
		}

		private static void Clear()
		{
		}

		private static bool Remove(Guid taskId)
		{
			return false;
		}

		private void Invoke(TResult result)
		{
		}

		public static void Add(Guid taskId, T data, Action<TResult, T> callback)
		{
		}
	}

	private static readonly HashSet<Guid> Pending;

	private static readonly Dictionary<Guid, TResult> Results;

	private static readonly Dictionary<Guid, Action> Continuations;

	private static readonly Dictionary<Guid, CallbackInvoker> CallbackInvokers;

	private static readonly Dictionary<Guid, CallbackRemover> CallbackRemovers;

	private static readonly HashSet<Action> CallbackClearers;

	private static readonly Dictionary<Guid, InternalDataRemover> InternalDataRemovers;

	private static readonly HashSet<Action> InternalDataClearers;

	private static readonly Dictionary<Guid, Action<Guid>> SubscriberRemovers;

	private static readonly HashSet<Action> SubscriberClearers;

	private readonly Guid _id;

	internal bool IsPending => false;

	public bool IsCompleted => false;

	internal static void Clear()
	{
	}

	internal OVRTask(Guid id)
	{
		_id = default(Guid);
	}

	internal void AddToPending()
	{
	}

	internal void SetInternalData<T>(T data)
	{
	}

	internal bool TryGetInternalData<T>(out T data)
	{
		data = default(T);
		return false;
	}

	internal void SetResult(TResult result)
	{
	}

	internal void SetIncrementalResultCallback<TIncrementalResult>(Action<TIncrementalResult> onIncrementalResultAvailable)
	{
	}

	internal void NotifyIncrementalResult<TIncrementalResult>(TIncrementalResult incrementalResult)
	{
	}

	public TResult GetResult()
	{
		return default(TResult);
	}

	public Awaiter GetAwaiter()
	{
		return default(Awaiter);
	}

	private void WithContinuation(Action continuation)
	{
	}

	public void ContinueWith(Action<TResult> onCompleted)
	{
	}

	public void ContinueWith<T>(Action<TResult, T> onCompleted, T state)
	{
	}

	private void ValidateDelegateAndThrow(object @delegate, string paramName)
	{
	}

	public void Dispose()
	{
	}

	public bool Equals(OVRTask<TResult> other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public static bool operator ==(OVRTask<TResult> lhs, OVRTask<TResult> rhs)
	{
		return false;
	}

	public static bool operator !=(OVRTask<TResult> lhs, OVRTask<TResult> rhs)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}
}
