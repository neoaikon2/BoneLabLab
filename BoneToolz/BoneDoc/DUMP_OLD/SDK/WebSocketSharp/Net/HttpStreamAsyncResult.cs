using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace WebSocketSharp.Net
{
	internal class HttpStreamAsyncResult : IAsyncResult
	{
		private byte[] _buffer;

		private AsyncCallback _callback;

		private bool _completed;

		private int _count;

		private Exception _exception;

		private int _offset;

		private object _state;

		private object _sync;

		private int _syncRead;

		private ManualResetEvent _waitHandle;

		internal byte[] Buffer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal int Count
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		internal bool HasException
		{
			get
			{
				return default(bool);
			}
		}

		internal int Offset
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		internal int SyncRead
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public object AsyncState
		{
			get
			{
				return null;
			}
		}

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				return null;
			}
		}

		public bool CompletedSynchronously
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		internal HttpStreamAsyncResult(AsyncCallback callback, object state)
			: base()
		{
		}

		internal void Complete()
		{
		}

		internal void Complete(Exception exception)
		{
		}
	}
}
